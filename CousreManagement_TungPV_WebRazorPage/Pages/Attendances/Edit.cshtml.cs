using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Attendances
{
    public class EditModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public EditModel(BusinessObject.Models.CousreManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Attendance Attendance { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Attendance == null)
            {
                return NotFound();
            }

            var attendance =  await _context.Attendance.FirstOrDefaultAsync(m => m.Id == id);
            if (attendance == null)
            {
                return NotFound();
            }
            Attendance = attendance;
           ViewData["SectionId"] = new SelectList(_context.Section, "Id", "Id");
           ViewData["StudentId"] = new SelectList(_context.Student, "Id", "Id");
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

            _context.Attach(Attendance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendanceExists(Attendance.Id))
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

        private bool AttendanceExists(string id)
        {
          return (_context.Attendance?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
