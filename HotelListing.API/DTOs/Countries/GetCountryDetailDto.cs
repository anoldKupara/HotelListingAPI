﻿using HotelListing.API.DTOs.Hotels;

namespace HotelListing.API.DTOs.Countries
{
    public class GetCountryDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public List<GetHotelDto> Hotels { get; set; }
    }
}
