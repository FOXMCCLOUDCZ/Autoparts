using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.BrandViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class BrandMapper : Profile
    {
        public BrandMapper()
        {
            CreateMap<Brand, BrandListVM>().ReverseMap();
            CreateMap<Brand, BrandCreateVM>().ReverseMap();
            CreateMap<Brand, BrandEditVM>().ReverseMap();
        }
    }
}