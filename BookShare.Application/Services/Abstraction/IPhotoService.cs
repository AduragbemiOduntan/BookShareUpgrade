﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Services.Abstraction
{
    public interface IPhotoService
    {
        string UploadPhoto(IFormFile file, string id, string folder);
        bool RemoveUploadedPhoto(string id, string folder);
        /*void CheckQuality(string folder, string publicId);*/
    }
}
