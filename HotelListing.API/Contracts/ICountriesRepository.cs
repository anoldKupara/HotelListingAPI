using HotelListing.API.Models;

namespace HotelListing.API.Contracts
{
    public interface ICountriesRepository : ICountriesRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
