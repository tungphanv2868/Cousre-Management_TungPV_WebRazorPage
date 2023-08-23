using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Sections
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly SectionRepository _sectionRepository;
        public IndexModel(BusinessObject.Models.CousreManagementContext context, SectionRepository sectionRepository)
        {
            _context = context;
            _sectionRepository = sectionRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        public IList<Section> Section { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Section != null)
            {
                Section = await _context.Section
                .Include(s => s.Course)
                .Include(s => s.Instructor)
                .Include(s => s.Attendance)
                .ToListAsync();
            }
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Section = _context.Section.Where(p => p.Name.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
