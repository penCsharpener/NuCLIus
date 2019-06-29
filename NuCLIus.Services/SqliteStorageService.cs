using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Services {
    public class SqliteStorageService : IStorageService {

        public const string DATABASENAME = "nuclius.db";
        private SQLiteConnection db;

        public SqliteStorageService() {

        }

        public async Task SetupStorageSolution(string appdataPath) {
            var fullFilePath = Path.Combine(appdataPath, DATABASENAME);
            // for development purposes: recreate on each debug build to apply 
            // changed table schema
            if (File.Exists(fullFilePath)) {
#if DEBUG
                File.Delete(fullFilePath);
#endif
            }
            var dbExisted = File.Exists(fullFilePath);
            if (dbExisted == false) {
                SQLiteConnection.CreateFile(fullFilePath);
            }

            db = new SQLiteConnection($"Data Source={fullFilePath};Version=3;");
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
