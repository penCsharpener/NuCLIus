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
        internal const string SOLUTIONS = @"CREATE TABLE ""Solutions"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL
)";


    }
}
