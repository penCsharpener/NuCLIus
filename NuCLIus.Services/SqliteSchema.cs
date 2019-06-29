﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Services {
    internal static class SqliteSchema {
        internal const string GITREPOS = @"CREATE TABLE ""gitrepos"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL
)";

        internal const string NUPKGS = @"CREATE TABLE ""nupkgs"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""ProjectID""	INTEGER,
	""PathSha1""	TEXT NOT NULL,
	""PackageSha256""	TEXT NOT NULL,
	""PackageName""	TEXT NOT NULL,
	""Version""	TEXT NOT NULL
)";
        internal const string PREFERENCES = @"CREATE TABLE ""preferences"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Name""	TEXT NOT NULL,
	""Value""	TEXT
)";
        internal const string PROJECTS = @"CREATE TABLE ""projects"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL,
	""SolutionID""	INTEGER
)";
        internal const string ROOTFOLDERS = @"CREATE TABLE ""root_folders"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	INTEGER NOT NULL
)";
        internal const string SOLUTIONS = @"CREATE TABLE ""solutions"" (
	""ID""	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	""Path""	TEXT NOT NULL,
	""PathSha1""	TEXT NOT NULL,
	""GitRepoID""	INTEGER
)";


    }
}
