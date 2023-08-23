using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly EnrollmentRepository _enrollmentRepository;
        public IndexModel(BusinessObject.Models.CousreManagementContext context, EnrollmentRepository enrollmentRepository)
        {
            _context = context;
            _enrollmentRepository = enrollmentRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        public IList<Enrollment> Enrollment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Enrollment != null)
            {
                Enrollment = await _context.Enrollment
                .Include(e => e.Course)
                .Include(e => e.Student).ToListAsync();
            }
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Enrollment = _context.Enrollment.Where(p => p.Id.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
