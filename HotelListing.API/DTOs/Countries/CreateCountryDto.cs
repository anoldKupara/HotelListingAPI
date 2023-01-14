using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Countries
{
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; } 
        public string ShortName { get; set; } 

    }
}
