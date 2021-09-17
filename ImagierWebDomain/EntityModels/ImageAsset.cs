using Microsoft.AspNetCore.Http;
using System;

namespace ImagierWebDomain.EntityModels
{
    public class ImageAsset
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public string ImageCategory { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public User UpdatedAt { get; set; }

    }
}
