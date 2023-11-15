using AutoMapper;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;

namespace AutopartsService.AutoMapper.Catalog
{
    public class WarrantyMapper : Profile
    {
        public WarrantyMapper()
        {
            CreateMap<Warranty, WarrantyListVM>().ReverseMap();
            CreateMap<Warranty, WarrantyCreateVM>().ReverseMap();
            CreateMap<Warranty, WarrantyEditVM>().ReverseMap();
        }
    }
}