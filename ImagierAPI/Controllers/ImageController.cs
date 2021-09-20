using AutoMapper;
using ImageServices.ImageServices;
using ImagierAPI.Dtos;
using ImagierWebDomain.EntityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagierAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ImageController : ControllerBase
    {
        private readonly IRepositoryServices _service;
        private readonly IMapper _mapper;
        private readonly ApplicationUser _userModel = new ApplicationUser();
        public ImageController(IRepositoryServices service, IMapper mapper, ApplicationUser userModel)
        {
            _service = service;
            _mapper = mapper;
            _userModel = userModel;
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

        //POST api/images
        [HttpPost]
        public ActionResult<ImagesReadDto> CreateCommand(ImagesCreateDto imagesCreateDto)
        {
            var imagesAsset = _mapper.Map<ImageAsset>(imagesCreateDto);
            _service.CreateAsset(imagesAsset);
            _service.SaveChanges();

            var imagesReadDto = _mapper.Map<ImagesReadDto>(imagesAsset);

            return CreatedAtRoute(nameof(GetImagesById), new { Id = imagesReadDto.Id }, imagesReadDto);
        }


    }
}
