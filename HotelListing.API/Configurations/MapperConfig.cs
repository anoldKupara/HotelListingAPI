using AutoMapper;
using HotelListing.API.DTOs.Countries;
using HotelListing.API.DTOs.Hotels;
using HotelListing.API.Models;

namespace HotelListing.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDetailDto>().ReverseMap();
            CreateMap<Hotel, GetHotelDto>().ReverseMap();

        }
    }
}
