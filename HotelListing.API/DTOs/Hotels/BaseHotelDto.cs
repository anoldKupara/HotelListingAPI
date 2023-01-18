using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Hotels
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public double? Rating { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Country Id is required")]
        public int CountryId { get; set; }
    }
}
