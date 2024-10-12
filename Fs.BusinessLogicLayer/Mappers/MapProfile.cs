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

            CreateMap<Product, ProductViewDto>();
            CreateMap<AddProductDto, Product>();


            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, UserDetail>();
            CreateMap<UploadedFileDto, UploadedFile>();
        }

    }
}
