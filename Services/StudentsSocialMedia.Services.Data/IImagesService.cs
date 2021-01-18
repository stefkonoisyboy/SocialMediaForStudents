﻿using StudentsSocialMedia.Web.ViewModels.Images;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface IImagesService
    {
        IEnumerable<ImageViewModel> GetAllByUsername(string username);
    }
}
