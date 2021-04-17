using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public  MappingProfiles ()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, a => a.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, a => a.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, a => a.MapFrom<ProductUrlResolver>());

        }
    }

}
