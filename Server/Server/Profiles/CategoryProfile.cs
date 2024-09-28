using AutoMapper;
using Server.Data.Dtos.Customer;
using Server.Data.Dtos;
using Server.Models;
using Server.Data.Dtos.Product;
using Server.Data.Enums;
using Server.Data.Dtos.Category;

namespace Server.Profiles
{
    public class CategoryProfile : Profile
    {

        public CategoryProfile()
        {
            CreateMap<CreateCategoryDto, CategoryModel>();
            CreateMap<UpdateCategoryDto, CategoryModel>();
            CreateMap<CategoryModel, UpdateCategoryDto>();
            CreateMap<CategoryModel, ReadCategoryDto>();
        }
    }
}
