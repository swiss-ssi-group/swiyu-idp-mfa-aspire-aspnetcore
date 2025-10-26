using Idp.Swiyu.IdentityProvider.Models;
using Microsoft.AspNetCore.Identity;

namespace Idp.Swiyu.IdentityProvider.SwiyuServices;

public class SwiyuUserTwoFactorTokenProvider : IUserTwoFactorTokenProvider<ApplicationUser>
{
    public Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
    {
        return Task.FromResult(true);
    }

    public Task<string> GenerateAsync(string purpose, UserManager<ApplicationUser> manager, ApplicationUser user)
    {
        return Task.FromResult(SwiyuConsts.SWIYU);
    }

    public Task<bool> ValidateAsync(string purpose, string token, UserManager<ApplicationUser> manager, ApplicationUser user)
    {
        return Task.FromResult(true);
    }
}