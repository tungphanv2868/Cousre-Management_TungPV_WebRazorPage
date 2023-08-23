using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Attendances
{
    public class DeleteModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public DeleteModel(BusinessObject.Models.CousreManagementContext context)
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

            var attendance = await _context.Attendance.FirstOrDefaultAsync(m => m.Id == id);

            if (attendance == null)
            {
                return NotFound();
            }
            else 
            {
                Attendance = attendance;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Attendance == null)
            {
                return NotFound();
            }
            var attendance = await _context.Attendance.FindAsync(id);

            if (attendance != null)
            {
                Attendance = attendance;
                _context.Attendance.Remove(Attendance);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
