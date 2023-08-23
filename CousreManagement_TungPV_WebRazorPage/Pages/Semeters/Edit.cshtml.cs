using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Semeters
{
    public class EditModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;

        public EditModel(BusinessObject.Models.CousreManagementContext context)
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

            var semeter =  await _context.Semeter.FirstOrDefaultAsync(m => m.Id == id);
            if (semeter == null)
            {
                return NotFound();
            }
            Semeter = semeter;
           ViewData["MajorId"] = new SelectList(_context.Major, "Id", "Id");
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

            _context.Attach(Semeter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SemeterExists(Semeter.Id))
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

        private bool SemeterExists(string id)
        {
          return (_context.Semeter?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
