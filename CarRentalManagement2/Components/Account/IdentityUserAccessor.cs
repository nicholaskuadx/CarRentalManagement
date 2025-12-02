using CarRentalManagement2.Data;
using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement2.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<CarRentalManagement2User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<CarRentalManagement2User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
