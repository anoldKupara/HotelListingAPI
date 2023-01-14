using Microsoft.Build.Framework;

namespace HotelListing.API.DTOs.Hotels
{
    public class CreateHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Rating { get; set; }
    }
}
