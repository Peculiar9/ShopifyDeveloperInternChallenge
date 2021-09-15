﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImagierWebDomain.EntityModels
{
    public class ImageAsset
    {
        [Key]
        public Guid ImageId { get; set; }
        public string ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User UpdatedBy { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}