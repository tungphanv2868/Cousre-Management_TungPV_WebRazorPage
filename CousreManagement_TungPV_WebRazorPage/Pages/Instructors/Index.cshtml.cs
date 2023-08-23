using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly InstructorRepository _instructorRepository;

        public IndexModel(BusinessObject.Models.CousreManagementContext context, InstructorRepository instructorRepository)
        {
            _context = context;
            _instructorRepository = instructorRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        public IList<Instructor> Instructor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Instructor != null)
            {
                Instructor = await _context.Instructor.ToListAsync();
            }
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Instructor = _context.Instructor.Where(p => p.Name.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
