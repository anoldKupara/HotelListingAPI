using HotelListing.API.DTOs.Users;
using Microsoft.AspNetCore.Identity;
using System.Collections;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
    }
}
