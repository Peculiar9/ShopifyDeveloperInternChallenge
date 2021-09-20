using AutoMapper;
using ImagierAPI.Dtos;
using ImagierWebDomain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagierAPI.Profiles
{
    public class ImagesProfile : Profile
    {
        public ImagesProfile()
        {
            //Source - Target
            CreateMap<ImageAsset, ImagesReadDto>();
            CreateMap<ImagesCreateDto, ImageAsset>();
            CreateMap<ImagesUpdateDto, ImageAsset>();
            CreateMap<ImageAsset, ImagesUpdateDto>();
        }
    }
}
