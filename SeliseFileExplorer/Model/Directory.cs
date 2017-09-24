using System;
using System.Collections.Generic;
using SeliseFileExplorer.Constants;

namespace SeliseFileExplorer.Model
{
    public class Directory
    {
        public IList<Folder> GetFolders()
        {
            //var folderList = new List<DirectoryContent>();

            //var desktop = new DirectoryContent { Name = "Desktop" };
            //desktop.ContentList.Add(new DirectoryContent()
            //{
            //    Name = "Libraries",
            //    ContentList = new List<DirectoryContent>
            //    {
            //        new DirectoryContent()
            //        {
            //            Name = "Documents"
            //        },
            //        new DirectoryContent()
            //        {
            //            Name = "Music",
            //            ContentList = new List<DirectoryContent>
            //            {
            //                new DirectoryContent
            //                {
            //                    Name = "Song 1",
            //                    ModifiedOn = new DateTime(2010, 10, 10, 10, 10, 10),
            //                    Size = "30 KB",
            //                    Type = "MP3",
            //                    ContentType = DirectoryContentType.File
            //                },
            //                new DirectoryContent
            //                {
            //                    Name = "Song 2",
            //                    ModifiedOn = new DateTime(2011, 11, 11, 11, 11, 11),
            //                    Size = "5 MB",
            //                    Type = "MP3",
            //                    ContentType = DirectoryContentType.File
            //                }
            //            }
            //        }
            //    }
            //});
            //desktop.ContentList.Add(new DirectoryContent() { Name = "Computer" });

            //var favorites = new DirectoryContent { Name = "Favorites" };
            //favorites.ContentList.Add(new DirectoryContent { Name = "Desktop" });
            //favorites.ContentList.Add(new DirectoryContent { Name = "Downloads" });
            //favorites.ContentList.Add(new DirectoryContent { Name = "Recent Places" });
            

            //folderList.Add(favorites);
            //folderList.Add(desktop);

            //return folderList;

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