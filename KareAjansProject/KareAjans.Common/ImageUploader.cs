using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Common
{
    public class ImageUploader
    {
        /*
            0=> dosya boş
            1=> "bu görsel daha önce eklenmiş"
            2=> "uymayan format"
                    -- png, jpg, jpeg, gif, bmp
            3=> "ekleme başarılı"

            parametreler;
                --file
                --path
         */
        public static string UploadImage(string filePath, IFormFile file)
        {

            var fileName = "";
            if (file != null)
            {
                var uniqueName = Guid.NewGuid();
                fileName = filePath.Replace("~", "");
                var fileArray = file.FileName.Split('.');
                string extension = fileArray[fileArray.Length - 1].ToLower();

                fileName = uniqueName + "." + extension;

                //uymayan format
                if (extension == "png" || extension == "jpg" || extension == "jpeg" || extension == "gif" || extension == "bmp")
                {



                    try
                    {
                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\manken", fileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }


                        return fileName;
                    }
                    catch (Exception ex)
                    {

                        return ex.Message;
                    }


                }
                else
                {
                    return "2";
                }


            }
            else
            {
                return "0";
            }

        }
    }
}
