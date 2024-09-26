using AutoMapper;
using Server.Data.Dtos.Customer;
using Server.Data.Dtos;
using Server.Models;
using Server.Data.Dtos.Product;
using Server.Data.Enums;

namespace Server.Profiles
{
    public class ProductProfile : Profile
    {

        public ProductProfile()
        {
            CreateMap<CreateProductDto, ProductModel>();
            CreateMap<UpdateProductDto, ProductModel>();
            CreateMap<ProductModel, UpdateProductDto>();
            CreateMap<ProductModel, ReadProductDto>();
        }
    }
}
