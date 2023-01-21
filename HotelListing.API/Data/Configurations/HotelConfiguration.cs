using HotelListing.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Royal Bahamian",
                    Address = "Nassau, New Providence Island",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Sandals Royal Caribbean",
                    Address = "Montego Bay, Jamaica",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Sandals Montego Bay",
                    Address = "Montego Bay, Jamaica",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Sandals Negril Beach Resort & Spa",
                    Address = "Negril, Jamaica",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Sandals South Coast",
                    Address = "Whitehouse, Jamaica",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Sandals Ochi Beach Resort",
                    Address = "Ocho Rios, Jamaica",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Sandals Grande St. Lucian Spa & Beach Resort",
                    Address = "Castries, St. Lucia",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Sandals LaSource Grenada Resort & Spa",
                    Address = "St. George's, Grenada",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 9,
                    Name = "Sandals Emerald Bay Golf, Tennis & Spa Resort",
                    Address = "Great Exuma, Bahamas",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 10,
                    Name = "Sandals Royal Caribbean",
                    Address = "Montego Bay, Jamaica",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 11,
                    Name = "Sandals Grande Antigua Resort & Spa",
                    Address = "St. John's, Antigua",
                    CountryId = 1,
                    Rating = 4.5
                });
        }
    }
}
