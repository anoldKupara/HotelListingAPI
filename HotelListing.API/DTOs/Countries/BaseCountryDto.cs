using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Countries
{
    public abstract class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
