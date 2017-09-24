using System;

namespace SeliseFileExplorer.Model
{
    public class File
    {
        public string Name { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }
    }
}