using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Subjects
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly SubjectRepository _subjectRepository;

        public IndexModel(BusinessObject.Models.CousreManagementContext context, SubjectRepository subjectRepository)
        {
            _context = context;
            _subjectRepository = subjectRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        public IList<Subject> Subject { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Subject != null)
            {
                Subject = await _context.Subject
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
            Subject = _context.Subject.Where(p => p.Name.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
