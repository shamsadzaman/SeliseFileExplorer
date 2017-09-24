using System.Collections.Generic;

namespace SeliseFileExplorer.Model
{
    public class DirectoryInfo
    {
        public List<Folder> Folders { get; set; }
        public List<File> Files { get; set; }
    }
}