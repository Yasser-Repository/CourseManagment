using CourseManagment.DAL.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagment.BL.Helper
{
    public static class Helper
    {
        public static async Task<fileSpecification> UploadFile(IFormFile file)
        {
            string folder = "";
            fileSpecification FS = new();
            if (isImage(file.FileName))
            {
                folder="Imgs";
            }       
            else if (isMedia(file.FileName))
            {
                folder="Media";
            }    
            else 
            {
                folder="Docs";
            }
            try
            {
                string directory =Path.Combine( Directory.GetCurrentDirectory() , "wwwroot/Files" , folder);
                string fileName = Guid.NewGuid() + Path.GetFileName(file.FileName);
                string finalPath = Path.Combine(directory, fileName);
                using (var stream = new FileStream(finalPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                FS.fileName = fileName;
                FS.filePath = finalPath;
                FS.Message = "Valid File Upload";
                return FS;
            }
            catch (Exception ex)
            {
                FS.Message = "ex.Message";
                return FS;
            }

        }
        public static bool isExistIn(string element, IEnumerable<Category> itemsCollection)
        {
            foreach (var item in itemsCollection)
            {
                if (item.Name.ToLower() == element.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        #region FileExtensions
        public static bool isImage(this string source)
        {
            source.ToLower();
            return  source.EndsWith(".png") ||
                    source.EndsWith(".jpg") ||
                    source.EndsWith(".bmp") ||
                    source.EndsWith(".tif") ||
                    source.EndsWith(".gif") ||
                    source.EndsWith(".jpeg")||
                    source.EndsWith(".jfif")||
                    source.EndsWith(".tiff");
        }
        public static bool isMedia(this string source)
        {
            source = source.ToLower();
            return source.EndsWith(".mp3") ||
                    source.EndsWith(".mp4") ||
                    source.EndsWith(".wav") ||
                    source.EndsWith(".3gb") ||
                    source.EndsWith(".mov") ||
                    source.EndsWith(".mkv") ||
                    source.EndsWith(".avi") ||
                    source.EndsWith(".mpeg") ||
                    source.EndsWith(".wmv");
        }
        #endregion

    }
}
