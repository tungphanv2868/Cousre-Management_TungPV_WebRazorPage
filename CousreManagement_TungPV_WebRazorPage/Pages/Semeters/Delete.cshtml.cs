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
    public class DeleteModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public DeleteModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Semeter == null)
            {
                return NotFound();
            }
            var semeter = await _context.Semeter.FindAsync(id);

            if (semeter != null)
            {
                Semeter = semeter;
                _context.Semeter.Remove(Semeter);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
