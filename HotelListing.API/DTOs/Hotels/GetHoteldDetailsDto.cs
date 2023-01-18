using HotelListing.API.DTOs.Countries;
using HotelListing.API.Models;

namespace HotelListing.API.DTOs.Hotels
{
    public class GetHoteldDetailsDto : BaseHotelDto
    {
        public int Id { get; set; }


        public List<GetCountryDto> Countries { get; set; }
    }
}
