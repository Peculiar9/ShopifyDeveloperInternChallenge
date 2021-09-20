using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagierAPI.Dtos
{
    public class ImagesUpdateDto
    {

        public Guid Id { get; set; }
        public int UserId { get; set; }
        public FormFile ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
