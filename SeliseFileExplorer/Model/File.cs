using System;

namespace SeliseFileExplorer.Model
{
    public class File
    {
        private DateTime _modifiedOn;
        public string Name { get; set; }

        public DateTime ModifiedOn
        {
            get
            {
                if (_modifiedOn == DateTime.MinValue)
                {
                    return new DateTime(2010, 10, 10, 10, 10, 10);
                }

                return _modifiedOn;
            }

            set { _modifiedOn = value; }
        }

        public string Type { get; set; }

        public string Size { get; set; }
    }
}