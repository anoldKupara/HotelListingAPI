using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelListingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
