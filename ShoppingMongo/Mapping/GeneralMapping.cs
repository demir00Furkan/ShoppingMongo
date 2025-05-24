using AutoMapper;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using ShoppingMongo.Dtos.CategoryDto;
using ShoppingMongo.Dtos.ProductDto;
using ShoppingMongo.Dtos.SliderDto;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductByIdDto>().ReverseMap();

            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, SliderUpdateDto>().ReverseMap();
            CreateMap<Slider, GetSliderByIdDto>().ReverseMap();
        }
    }
}
