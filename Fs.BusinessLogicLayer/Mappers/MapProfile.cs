using AutoMapper;
using Fs.BusinessLogicLayer.Dtos;
using Fs.Entity.Accounts;
using Fs.Entity.Commons;
using Fs.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.BusinessLogicLayer.Mappers
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {

            CreateMap<AddProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, UserDetail>();
            CreateMap<UploadedFileDto, UploadedFile>();
            CreateMap<Product, ProductViewDto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Value))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.UploadedFiles.FirstOrDefault().FileName));
        }

    }
}
