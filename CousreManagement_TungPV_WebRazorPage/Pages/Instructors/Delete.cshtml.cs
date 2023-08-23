using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Instructors
{
    public class DeleteModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public DeleteModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Instructor Instructor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Instructor == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructor.FirstOrDefaultAsync(m => m.Id == id);

            if (instructor == null)
            {
                return NotFound();
            }
            else 
            {
                Instructor = instructor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Instructor == null)
            {
                return NotFound();
            }
            var instructor = await _context.Instructor.FindAsync(id);

            if (instructor != null)
            {
                Instructor = instructor;
                _context.Instructor.Remove(Instructor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
