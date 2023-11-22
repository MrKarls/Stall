using AutoMapper;
using CatalogService.Dto;
using CatalogService.Models;

namespace CatalogService.Profiles
{
    public class ProductProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
