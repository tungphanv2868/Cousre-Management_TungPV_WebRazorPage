using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Semeters
{
    public class DetailsModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public DetailsModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

      public Semeter Semeter { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Semeter == null)
            {
                return NotFound();
            }

            var semeter = await _context.Semeter.FirstOrDefaultAsync(m => m.Id == id);
            if (semeter == null)
            {
                return NotFound();
            }
            else 
            {
                Semeter = semeter;
            }
            return Page();
        }
    }
}
