using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SeliseFileExplorer.Model
{
    public class Folder
    {
        public string Name { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string Type => "Folder";

        public List<Folder> FolderList { get; set; }

        public List<File> FileList { get; set; }
    }
}