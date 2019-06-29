﻿using NuCLIus.Core.Contracts;
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
            // changed table schema
            if (File.Exists(SqliteDatabaseLocation)) {
#if DEBUG
                File.Delete(SqliteDatabaseLocation);
#endif
            }
            var dbExisted = File.Exists(SqliteDatabaseLocation);
            if (dbExisted == false) {
                SQLiteConnection.CreateFile(SqliteDatabaseLocation);
            }

            db = new SQLiteConnection($"Data Source={SqliteDatabaseLocation};Version=3;");
            if (dbExisted == false) {
                await Task.Factory.StartNew(async () => {
                    await db.OpenAsync();
                    await new SQLiteCommand(SqliteSchema.GITREPOS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.NUPKGS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.PREFERENCES, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.PROJECTS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.ROOTFOLDERS, db).ExecuteNonQueryAsync();
                    await new SQLiteCommand(SqliteSchema.SOLUTIONS, db).ExecuteNonQueryAsync();
                    db.Close();
                });
            }
        }
    }
}
