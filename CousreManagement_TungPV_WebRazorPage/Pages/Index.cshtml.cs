using ASP.NETCoreWebApp.Binding;
using ASP.NETCoreWebApp.Validation;
using BusinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CousreManagement_TungPV_WebRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private CousreManagementContext context = new CousreManagementContext();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Page();
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost(string ID, string password)
        {
            AccountAdmin admin = new AccountAdmin();
            Admin loginAdmin = new Admin();
            admin = loginAdmin.getAdminAccount();
            if (admin.Email.Equals(ID) && admin.Password.Equals(password))
            {
                HttpContext.Session.SetString("ROLE", "AD");
                return RedirectToPage("./Semeters/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}