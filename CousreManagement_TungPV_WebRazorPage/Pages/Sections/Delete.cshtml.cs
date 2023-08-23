using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Sections
{
    public class DeleteModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public DeleteModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Section Section { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Section == null)
            {
                return NotFound();
            }

            var section = await _context.Section.FirstOrDefaultAsync(m => m.Id == id);

            if (section == null)
            {
                return NotFound();
            }
            else 
            {
                Section = section;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Section == null)
            {
                return NotFound();
            }
            var section = await _context.Section.FindAsync(id);

            if (section != null)
            {
                Section = section;
                _context.Section.Remove(Section);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
