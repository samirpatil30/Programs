using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommanLayer.Model
{
   public class CloudinaryImageUpload
    {
        public string UploadImageOnCloud(IFormFile file)
        {
            var nameOfImage = file.FileName;
            Account myAccount = new Account("mypersonalimagecloud", "195418184769875", "KsBsYEpjmd2RJ-B11TIAtlEOots");
            Cloudinary _cloudinary = new Cloudinary(myAccount);
            var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(nameOfImage, stream)
            };
            var uploadResult = _cloudinary.Upload(uploadParams);
            return uploadResult.Uri.ToString();
        }
   }
}
