using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Majors
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly MajorRepository _majorRepository;

        public IndexModel(BusinessObject.Models.CousreManagementContext context, MajorRepository majorRepository)
        {
            _context = context;
            _majorRepository = majorRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        [BindProperty]
        public IList<Major> Major { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Major != null)
            {
                List<Major> list = new List<Major>();
                list = await _context.Major.ToListAsync();
                Major = list;
            }
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Major = _context.Major.Where(p => p.Name.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
