using IdentityCustom.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityCustom.Areas.Identity.Pages.Account.Manage
{
    public class PhotoModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _singInManager;

        public PhotoModel(UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> singInManager)
        {
            _userManager = userManager;
            _singInManager = singInManager;
        }
        public void OnGet()
        {
        }

        public void onPost()
        {

        }
    }
}
