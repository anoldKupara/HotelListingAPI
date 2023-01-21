using AutoMapper;
using HotelListing.API.Configurations;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.DTOs.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;
        
        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            bool isValidUser;
            try
            {
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                var validPassword = await _userManager.CheckPasswordAsync(user, loginDto.Password);

                return validPassword;
            }
            catch (Exception)
            {

                throw;
            }

            return isValidUser; 
        }

        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email;

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                var addToRoleResult = await _mapper.AddToRoleAsync(user, "User", _userManager);
                if (!addToRoleResult.Succeeded)
                {
                    return addToRoleResult.Errors;
                }
            }
            return result.Errors;
        }

    }
}
