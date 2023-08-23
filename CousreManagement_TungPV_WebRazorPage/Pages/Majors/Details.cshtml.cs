using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Majors
{
    public class DetailsModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public DetailsModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

      public Major Major { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Major == null)
            {
                return NotFound();
            }

            var major = await _context.Major.FirstOrDefaultAsync(m => m.Id == id);
            if (major == null)
            {
                return NotFound();
            }
            else 
            {
                Major = major;
            }
            return Page();
        }
    }
}
