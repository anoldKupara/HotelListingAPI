using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.DTOs.Countries;
using HotelListing.API.DTOs.Hotels;
using HotelListing.API.DTOs.Users;
using HotelListing.API.Models;

namespace HotelListing.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            #region Countries
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDetailDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            #endregion
            
            #region Hotels
            CreateMap<Hotel, GetHotelDto>().ReverseMap();
            #endregion

            #region ApiUsers
            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
            #endregion

        }
    }
}
