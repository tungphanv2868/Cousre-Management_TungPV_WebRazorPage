using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Semeters
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly SemeterRepository semeterRepository;

        public IndexModel(BusinessObject.Models.CousreManagementContext context, SemeterRepository _semeterRepository )
        {
            semeterRepository= _semeterRepository;
            _context = context;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        [BindProperty]
        public IList<Semeter> Semeter { get;set; }
        //  public IList<Semeter> SemeterList { get; set; }

        public async Task OnGetAsync()
        {
            List<Semeter> list = new List<Semeter>();
            list = await _context.Semeter.Include(x => x.Major).ToListAsync();
            Semeter = list;
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Semeter = _context.Semeter.Where(p => p.Name.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
