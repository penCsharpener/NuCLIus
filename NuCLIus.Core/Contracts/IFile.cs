﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NuCLIus.Core.Contracts {
    public interface IFile : IPrimary {
        string Path { get; set; }
        string PathSha1 { get; set; }
        FileInfo GetFileInfo();
        DirectoryInfo GetDirectoryInfo();
    }
}
