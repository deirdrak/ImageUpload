using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapMvcSample.Controllers;

namespace Tarea2UploadingFiles.Controllers
{
    public class FileUploadController : BootstrapBaseController
    {
        //
        // GET: /FileUpload/
        [HttpGet]
        public ActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase fileControl)
        {
            if (fileControl == null)
            {
                Error("There was a problem uploading the file :( , please try again!!!");
                return View();
            }

            var fileName = Path.GetFileName(fileControl.FileName);
            var serverFolderPath = Server.MapPath("~/App_Data/UploadedFiles/");
            var directoryInfo = new DirectoryInfo(serverFolderPath);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            var path = Path.Combine(serverFolderPath, fileName);
            
            fileControl.SaveAs(path);

            Success("File uploaded successfully!!! :D");
            return View();
        }

        public ActionResult GoToFileList()
        {
            return RedirectToAction("FileList", "FileList");
        }
    }
}
