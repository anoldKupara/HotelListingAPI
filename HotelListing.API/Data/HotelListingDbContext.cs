
using HotelListing.API.Data.Configurations;
using HotelListing.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : IdentityDbContext<ApiUser>
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            {
                modelBuilder.Entity<Country>().HasData(
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
                modelBuilder.Entity<Hotel>().HasData(new Hotel
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
}



