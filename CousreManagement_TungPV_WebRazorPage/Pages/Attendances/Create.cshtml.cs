using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Attendances
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
        ViewData["SectionId"] = new SelectList(_context.Section, "Id", "Id");
        ViewData["StudentId"] = new SelectList(_context.Student, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Attendance Attendance { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Attendance == null || Attendance == null)
            {
                return Page();
            }

            _context.Attendance.Add(Attendance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
