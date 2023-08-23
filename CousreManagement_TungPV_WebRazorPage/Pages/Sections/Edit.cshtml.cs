using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Sections
{
    public class EditModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public EditModel(BusinessObject.Models.CousreManagementContext context)
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

            var section =  await _context.Section.FirstOrDefaultAsync(m => m.Id == id);
            if (section == null)
            {
                return NotFound();
            }
            Section = section;
           ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id");
           ViewData["InstructorId"] = new SelectList(_context.Instructor, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Section).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(Section.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SectionExists(string id)
        {
          return (_context.Section?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
