using HotelListing.API.Models;

namespace HotelListing.API.Contracts
{
    public class ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> IGenericRepository<Country>.AddAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<Country>.DeleteAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Country>.Exists(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Country>> IGenericRepository<Country>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Country> IGenericRepository<Country>.GetAsync(int? id)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<Country>.UpdateAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
