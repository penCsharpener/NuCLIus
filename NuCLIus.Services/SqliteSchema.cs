using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Services {
    internal static class SqliteSchema {
        internal const string GITREPOS = @"CREATE TABLE ""GitRepos"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL UNIQUE
)";
        internal const string GITREPO_INDEXES = @"CREATE UNIQUE INDEX ""gitrepos_id_asc"" ON ""GitRepos"" (
	""ID""	ASC
)";

        internal const string NUPKGS = @"CREATE TABLE ""Nupkgs"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""ProjectID""	INTEGER,
	""PathSha1""	TEXT NOT NULL,
	""PackageSha256""	TEXT NOT NULL,
	""PackageName""	TEXT NOT NULL,
	""Version""	TEXT NOT NULL
)";

		internal const string NUPKG_INDEXES = @"CREATE UNIQUE INDEX ""nupkg_id_asc"" ON ""Nupkgs"" (
	""ID""	ASC
);
CREATE INDEX ""nupkg_projectid_asc"" ON ""Nupkgs"" (
	""ProjectID""	ASC
);";

        internal const string PREFERENCES = @"CREATE TABLE ""Preferences"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Name""	TEXT NOT NULL,
	""Type""	INTEGER NOT NULL DEFAULT 1,
	""ValueString""	TEXT,
	""ValueInt""	INTEGER
)";

        internal const string PROJECTS = @"CREATE TABLE ""Projects"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL,
	""SolutionID""	INTEGER,
	""GitRepoID""	INTEGER
)";

        internal const string ROOTFOLDERS = @"CREATE TABLE ""RootFolders"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL UNIQUE
)";

        internal const string SCANIGNOREPATHS = @"CREATE TABLE ""ScanIgnorePaths"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL UNIQUE
);
INSERT INTO ""main"".""ScanIgnorePaths""(""ID"",""Path"",""PathSha1"") VALUES (1,'.git','4b3b503e8f6a37cf74e93cb63b77f2311de95777');
INSERT INTO ""main"".""ScanIgnorePaths""(""ID"",""Path"",""PathSha1"") VALUES (2,'Release','d41f56cea1ac933d25c57aebc6522e2b6c58eb87');
INSERT INTO ""main"".""ScanIgnorePaths""(""ID"",""Path"",""PathSha1"") VALUES (3,'Debug','bd604d99e75e45d38bc7ac8fc714cde0097d901f');
INSERT INTO ""main"".""ScanIgnorePaths""(""ID"",""Path"",""PathSha1"") VALUES (4,'.vs','c3d833bba32fbff9e9618d7d87a10eca5acf72e7');
INSERT INTO ""main"".""ScanIgnorePaths""(""ID"",""Path"",""PathSha1"") VALUES (5,'obj','9b5c0b859faba061dd60fd8070fce74fcee29d0b');
INSERT INTO ""main"".""ScanIgnorePaths""(""ID"",""Path"",""PathSha1"") VALUES (6,'node_modules','9193e35d8b7fc33d768461505160c12c96c608bd');";

        internal const string SOLUTIONS = @"CREATE TABLE ""Solutions"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL
)";


    }
}
