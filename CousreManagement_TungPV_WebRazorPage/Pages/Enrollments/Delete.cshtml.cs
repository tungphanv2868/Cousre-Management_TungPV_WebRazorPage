using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Enrollments
{
    public class DeleteModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public DeleteModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Enrollment Enrollment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Enrollment == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment.FirstOrDefaultAsync(m => m.Id == id);

            if (enrollment == null)
            {
                return NotFound();
            }
            else 
            {
                Enrollment = enrollment;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Enrollment == null)
            {
                return NotFound();
            }
            var enrollment = await _context.Enrollment.FindAsync(id);

            if (enrollment != null)
            {
                Enrollment = enrollment;
                _context.Enrollment.Remove(Enrollment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
