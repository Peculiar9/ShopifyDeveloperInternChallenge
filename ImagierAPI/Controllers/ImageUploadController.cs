using ImagierAPI.Dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImagierAPI.Controllers
{
    [Route("api/Image")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;

        public ImageUploadController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpPost("upload")]
        public async Task<string> ImageUpload([FromForm] ImageAssetCreateDto createDto)
        {
            var uploadDirectory = _environment.WebRootPath + "\\Upload\\";
            if (createDto.ImageFile.Length > 0)
            {
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }
                using (FileStream fileStream = System.IO.File.Create(uploadDirectory + createDto.ImageFile.FileName))
                {
                    await createDto.ImageFile.CopyToAsync(fileStream);
                    fileStream.Flush();
                    return "\\Upload\\" + createDto.ImageFile.FileName;

                }
            }
            else
            {
                return "Failed Upload";
            }

            
        }
    }
}
