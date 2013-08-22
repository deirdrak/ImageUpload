using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using BootstrapMvcSample.Controllers;
using Tarea2UploadingFiles.Models;

namespace Tarea2UploadingFiles.Controllers
{
    public class FileListController : BootstrapBaseController
    {
        //
        // GET: /FileList/
        [HttpGet]
        public ActionResult FileList()
        {
            var FileModelList = new List<FileModel>();
            var path = Server.MapPath("~/App_Data/UploadedFiles");

            var directoryInfo = new DirectoryInfo(path);

            if (directoryInfo.Exists)
            {
                var filesList = directoryInfo.GetFiles();

                foreach (var file in filesList)
                {
                    //if(file)

                    FileModelList.Add(new FileModel
                    {
                        FileName = file.Name.Split('.')[0],
                        FilePath = file.DirectoryName,
                        FileSizeBytes = file.Length,
                        FileType = file.Extension,
                        FileUploadDate = file.CreationTime
                    });

                }
                
            }
            else
            {
                Error("Folder does not exist!!!");

                FileModelList.Add(new FileModel
                {
                    FileName = "No files",
                    FilePath = "",
                    FileSizeBytes = 0,
                    FileType = "",
                    FileUploadDate = DateTime.Now
                });
            }
            return View(FileModelList);
        }

    }
}
