using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Configurations
{
    public static class MapperExtensions
    {
        public static async Task<IdentityResult> AddToRoleAsync<T>(this IMapper mapper, T user, string roleName, UserManager<T> userManager) where T : class
        {
            var mappedUser = mapper.Map<T>(user);
            return await userManager.AddToRoleAsync(mappedUser, roleName);
        }
    }
}