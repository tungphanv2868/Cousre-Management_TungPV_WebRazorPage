using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.Models;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Semeters
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
        ViewData["MajorId"] = new SelectList(_context.Major, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Semeter Semeter { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Semeter == null || Semeter == null)
            {
                return Page();
            }

            _context.Semeter.Add(Semeter);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
