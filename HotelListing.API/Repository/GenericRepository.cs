using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelListingDbContext _dBcontext;
        public GenericRepository(HotelListingDbContext dbContext)
        {
            _dBcontext = dbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dBcontext.AddAsync(entity);
            await _dBcontext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            var entry = _dBcontext.Entry(entity);
            _dBcontext.Set<T>().Remove(entity);
            await _dBcontext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await _dBcontext.FindAsync<T>(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dBcontext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }

            return await _dBcontext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dBcontext.Update(entity);
            await _dBcontext.SaveChangesAsync();
        }
    }
}
