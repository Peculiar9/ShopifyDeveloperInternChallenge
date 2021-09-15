using ImagierWebDomain.EntityModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagierAPI.Dtos
{
    public class ImageAssetCreateDto
    {
        public Guid ImageId { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User UpdatedBy { get; set; }
        public decimal Price { get; set; }
    }
}
