using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _dbContext;

        public CountriesRepository(HotelListingDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Country> GetDetails(int id)
        {
            return _dbContext.Countries.Include(c => c.Hotels)
                  .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
