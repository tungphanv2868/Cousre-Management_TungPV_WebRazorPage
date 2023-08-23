using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly CourseRepository _courseRepository;
        public IndexModel(BusinessObject.Models.CousreManagementContext context, CourseRepository courseRepository)
        {
            _context = context;
            _courseRepository = courseRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Course != null)
            {
                Course = await _context.Course
                .Include(c => c.Instructor)
                .Include(c => c.Subject).ToListAsync();
            }
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Course = _context.Course.Where(p => p.Name.Contains(SearchKey)).ToList();
            return Page();
        }

    }
}
