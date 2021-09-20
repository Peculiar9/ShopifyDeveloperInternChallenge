using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace ImagierWebDomain.EntityModels
{
    public class ImageAsset
    {
        [Key]
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }   
        public string CreatedBy { get; set; }

    }
}

