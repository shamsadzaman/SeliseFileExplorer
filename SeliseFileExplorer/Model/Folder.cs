using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SeliseFileExplorer.Model
{
    public class Folder
    {
        public string Name { get; set; }

        public DateTime ModifiedOn
        {
            get
            {
                if (_modifiedOn == DateTime.MinValue)
                {
                    return new DateTime(new Random().Next(1900, 2017), 08, new Random().Next(1, 31), 03, 03, 03);
                }

                return _modifiedOn;
            }

            set { _modifiedOn = value; }
        }

        public string Type => "Folder";

        public string Size = "";
        private DateTime _modifiedOn;

        public List<Folder> FolderList { get; set; }

        public List<File> FileList { get; set; }

        public Folder()
        {
            FolderList = new List<Folder>();
            FileList = new List<File>();
        }
    }
}