﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace FileUploadUpgraded2.ViewModels
{
    public class ProfileEditViewModel
    {
        [Required]
        public string Name { get; set; }
        public string AvatarPath { get; set; }
        public IFormFile AvatarFile { get; set; }
    }
}