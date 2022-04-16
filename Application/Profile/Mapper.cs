using Application.Dto;
using AutoMapper;
using Domain.Entities;

namespace Application.profile
{
    public class Mapper:Profile
    {
        public Mapper() {
            //Product Map
            CreateMap<AddProductDto, Product>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            //Product Type Map
            CreateMap<AddProductTypeDto, ProductType>().ReverseMap();
            CreateMap<ProductTypeDto, ProductType>().ReverseMap();
            CreateMap<UpdateProductTypeDto, ProductType>().ReverseMap();
        }
    }
}
