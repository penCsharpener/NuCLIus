using Dapper.Contrib.Extensions;
using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using penCsharpener.DotnetUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;

namespace NuCLIus.Services {
    public class SqliteStorageService : IStorageService {

        public const string DATABASENAME = "nuclius.db";
        public string SqliteDatabaseLocation { get; private set; }
        private SQLiteConnection db;

        public SqliteStorageService() {

        }

        public async Task SetupStorageSolution(string appdataPath) {
            SqliteDatabaseLocation = Path.Combine(appdataPath, DATABASENAME);
            // for development purposes: recreate on each debug build to apply 
            // changed table schema without migrations
            if (File.Exists(SqliteDatabaseLocation)) {
#if !RELEASE
                File.Delete(SqliteDatabaseLocation);
#endif
            }
            var dbExisted = File.Exists(SqliteDatabaseLocation);
            if (dbExisted == false) {
                SQLiteConnection.CreateFile(SqliteDatabaseLocation);
            }

            db = new SQLiteConnection($"Data Source={SqliteDatabaseLocation};Version=3;");
            await db.OpenAsync();
            if (dbExisted == false) {
                await Task.Factory.StartNew(async () => {
                    await new SQLiteCommand(SqliteSchema.GITREPOS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.NUPKGS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.PREFERENCES, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.PROJECTS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.ROOTFOLDERS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.SCANIGNOREPATHS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.SOLUTIONS, db).ExecuteNonQueryAsync();
                    
                    await new SQLiteCommand(SqliteSchema.GITREPO_INDEXES, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.NUPKG_INDEXES, db).ExecuteNonQueryAsync();
#if !RELEASE
                    var rf = new RootFolder();
                    rf.Path = Environment.ExpandEnvironmentVariables(@"%userprofile%\Source\Repos");
                    rf.PathSha1 = rf.Path.ToSha1();
                    await SaveEntity(rf);
#endif
                });
            }
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class, IPrimary {
            return await db.GetAllAsync<T>();
        }

        public async Task SaveEntity<T>(T entity) where T : class, IPrimary {
            var id = await db.InsertAsync<T>(entity);
            entity.ID = id;
        }

        public async Task DeleteEntity<T>(T entity) where T : class, IPrimary {
            await db.DeleteAsync<T>(entity);
        }

        public async Task UpdateEntity<T>(T entity) where T : class, IPrimary {
            await db.UpdateAsync<T>(entity);
        }
    }
}
