using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Sections
{
    public class CreateModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public CreateModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id");
        ViewData["InstructorId"] = new SelectList(_context.Instructor, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Section Section { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Section == null || Section == null)
            {
                return Page();
            }

            _context.Section.Add(Section);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
