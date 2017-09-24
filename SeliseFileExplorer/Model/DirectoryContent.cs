using System;
using System.Collections.Generic;
using System.Windows.Documents;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Model
{
    public class DirectoryContent
    {
        public string Name { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string Size { get; set; }

        public string Type { get; set; }

        public DirectoryContentType ContentType { get; set; }

        public List<DirectoryContent> ContentList { get; set; }

        public DirectoryContent()
        {
            ContentList = new List<DirectoryContent>();
        }
    }
}