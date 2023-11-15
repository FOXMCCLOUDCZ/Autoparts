using AutoMapper;
using AutopartsEntity.ExtensionForUsers.Entities;
using AutopartsEntity.ExtensionForUsers.ViewModels.CurrencyViewModel;

namespace AutopartsService.AutoMapper.ExtensionForUsers
{
    public class CurrencyMapper : Profile
    {
        public CurrencyMapper()
        {
            CreateMap<Currency, CurrencyListVM>().ReverseMap();
            CreateMap<Currency, CurrencyCreateVM>().ReverseMap();
            CreateMap<Currency, CurrencyEditVM>().ReverseMap();
        }
    }
}