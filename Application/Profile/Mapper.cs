using Application.Dto;
using AutoMapper;
using Domain.Entities;

namespace Application.profile
{
    public class Mapper:Profile
    {
        public Mapper() {
            CreateMap<AddProductDto, Product>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
        }
    }
}
