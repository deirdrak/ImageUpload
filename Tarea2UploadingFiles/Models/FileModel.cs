using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2UploadingFiles.Models
{
    public class FileModel
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public long FileSizeBytes { get; set; }
        public DateTime FileUploadDate { get; set; }
    }
}