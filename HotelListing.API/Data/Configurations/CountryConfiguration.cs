using HotelListing.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Jamaica",
                        ShortName = "JM"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Bahamas",
                        ShortName = "BS"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Cayman Islands",
                        ShortName = "CI"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "Cuba",
                        ShortName = "CU"
                    },
                    new Country
                    {
                        Id = 5,
                        Name = "Dominican Republic",
                        ShortName = "DR"
                    },
                    new Country
                    {
                        Id = 6,
                        Name = "Haiti",
                        ShortName = "HT"
                    },
                    new Country
                    {
                        Id = 7,
                        Name = "Trinidad and Tobago",
                        ShortName = "TT"
                    },
                    new Country
                    {
                        Id = 8,
                        Name = "United States",
                        ShortName = "US"
                    }
            );
        }
    }
}
