using HotelListing.API.DTOs.Hotels;

namespace HotelListing.API.DTOs.Countries
{
    public class GetCountryDetailDto : BaseCountryDto
    {
        public int Id { get; set; }

        public List<GetHotelDto> Hotels { get; set; }
    }
}
