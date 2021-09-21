using AutoMapper;
using ImageServices.ImageServices;
using ImagierAPI.Dtos;
using ImagierWebDomain.EntityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ImagierAPI.Controllers
{
    [Route("api/images")]
    [ApiController]
    [Authorize]
    public class ImageController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IRepositoryServices _service;
        private readonly IMapper _mapper;
        private readonly ApplicationUser _userModel = new ApplicationUser();
        public ImageController(IRepositoryServices service, IMapper mapper, ApplicationUser userModel, IWebHostEnvironment environment)
        {
            _service = service;
            _mapper = mapper;
            _userModel = userModel;
            _environment = environment;
        }



        [HttpGet]
        [Route("")]
        // GET api/images
        public ActionResult<IEnumerable<ImagesReadDto>> GetAllImages()
        {

            var commandItems = _service.GetImageAssets();

            return Ok(_mapper.Map<IEnumerable<ImagesReadDto>>(commandItems));
        }
        
        // GET api/images/{id}
        [HttpGet("{id}", Name = "GetImageById")]
        public ActionResult<ImagesReadDto> GetImagesById(Guid id)
        {
            var images = _service.GetAssetById(id);
            if (images != null)
                return Ok(_mapper.Map<ImagesReadDto>(images));
            return NotFound();
        }
        public class Response
        {
            public string Status { get; set; }
            public string Message { get; set; }
        }
        //POST api/images
        [HttpPost]
        public async Task<ActionResult<ImagesReadDto>> CreateCommand([FromForm]ImagesCreateDto imagesCreateDto)
        {
            var uploadDirectory = _environment.WebRootPath + "\\Upload\\";
            if (imagesCreateDto.ImageFile.Length > 0)
            {
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }
                using (FileStream fileStream = System.IO.File.Create(uploadDirectory + imagesCreateDto.ImageFile.FileName))
                {
                     await imagesCreateDto.ImageFile.CopyToAsync(fileStream);
                     fileStream.Flush();
                    new Response
                    {
                        Status = "Success",
                        Message = "Upload Successful"
                    };
                }
                    
            }
            else
            {
                new Response
                {
                    Status = "Error",
                    Message = "Upload Not Successful"
                };
            }

            var imagesAsset = new ImageAsset()  
            {
                ImageFile = imagesCreateDto.ImageFile.ToString(),
                CreatedAt = DateTime.Now,
                CreatedBy = _userModel.UserName.ToString(),
                Id = Guid.NewGuid(),
                ImageName = imagesCreateDto.ImageName,
                ImageType = imagesCreateDto.ImageType,
                CategoryId = imagesCreateDto.CategoryId,
            };
            _service.CreateAsset(imagesAsset);
            _service.SaveChanges();

               
            var imagesReadDto = _mapper.Map<ImagesReadDto>(imagesAsset);

            return CreatedAtRoute(nameof(GetImagesById), new { Id = imagesReadDto.Id }, imagesReadDto);
        }


    }
}
