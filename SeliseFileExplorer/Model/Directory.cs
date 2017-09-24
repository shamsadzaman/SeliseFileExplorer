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
                                        Name = "New Folder 1"
                                    },
                                    new Folder
                                    {
                                        Name = "New Folder 2"
                                    }
                                },
                                FileList = new List<File>
                                {
                                    new File
                                    {
                                        Name = "Pic 1",
                                        Size = "5 MB",
                                        Type = "JPEG Image"
                                    },
                                    new File
                                    {
                                        Name = "Pic 2",
                                        Size = "5 KB",
                                        Type = "PNG"
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