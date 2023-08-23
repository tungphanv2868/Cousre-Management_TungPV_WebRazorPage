using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly StudentRepository _studentRepository;
        public IndexModel(BusinessObject.Models.CousreManagementContext context, StudentRepository studentRepository)
        {
            _context = context;
            _studentRepository = studentRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student
                .Include(s => s.Major).ToListAsync();
            }
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Student = _context.Student.Where(p => p.LastName.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
