using System;
using System.Collections.Generic;

namespace SeliseFileExplorer.Model
{
    public class Directory
    {
        public List<Folder> FolderList { get; set; }

        public Directory()
        {
            FolderList = CreateFolders();
        }

        public List<Folder> GetFolders()
        {
            return FolderList;
        }

        private List<Folder> CreateFolders()
        {
            var folderList = new List<Folder>();

            var desktop = new Folder
            {
                Name = "Desktop",
                FolderList = new List<Folder>
                {
                    new Folder
                    {
                        Name = "Libraries",
                        FolderList = new List<Folder>
                        {
                            new Folder
                            {
                                Name = "Documents",
                                FileList = new List<File>
                                {
                                    new File
                                    {
                                        Name = "Word1",
                                        Size = "20 MB",
                                        Type = "DOCX"
                                    },
                                    new File
                                    {
                                        Name = "Word2",
                                        Size = "10 MB",
                                        Type = "DOCX"
                                    }
                                }
                            }
                        }
                    },
                    new Folder
                    {
                        Name = "Pictures",
                        FolderList = new List<Folder>
                        {
                            new Folder
                            {
                                Name = "My Pictures",
                                FolderList = new List<Folder>
                                {
                                    new Folder
                                    {
                                        Name = "New Folder 1",
                                        ModifiedOn = new DateTime(2016, 09, 23, 12, 39, 04)
                                    },
                                    new Folder
                                    {
                                        Name = "New Folder 2",
                                        ModifiedOn = new DateTime(2017, 09, 23, 12, 39, 04)
                                    }
                                },
                                FileList = new List<File>
                                {
                                    new File
                                    {
                                        Name = "Pic 1",
                                        Size = "5 MB",
                                        Type = "JPEG Image",
                                        ModifiedOn = new DateTime(new Random().Next(1900, 2017), 08, new Random().Next(1, 31), 03, 03, 03)
                                    },
                                    new File
                                    {
                                        Name = "Pic 2",
                                        Size = "5 KB",
                                        Type = "PNG",
                                        ModifiedOn = new DateTime(2017, 07, 14, 23, 39, 50)
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var favorite = new Folder
            {
                Name = "Favorite"
            };

            folderList.Add(favorite);
            folderList.Add(desktop);

            return folderList;
        }
    }
}