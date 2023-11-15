using AutoMapper;
using AutopartsEntity.ExtensionForUsers.Entities;
using AutopartsEntity.ExtensionForUsers.ViewModels.CountryViewModel;

namespace AutopartsService.AutoMapper.ExtensionForUsers
{
    public class CountryMapper : Profile
    {
        public CountryMapper()
        {
            CreateMap<Country, CountryListVM>().ReverseMap();
            CreateMap<Country, CountryCreateVM>().ReverseMap();
            CreateMap<Country, CountryEditVM>().ReverseMap();
        }
    }
}