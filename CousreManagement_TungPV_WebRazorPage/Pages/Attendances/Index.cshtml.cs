using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repository;

namespace CousreManagement_TungPV_WebRazorPage.Pages.Attendances
{
    public class IndexModel : PageModel
    {
        private readonly BusinessObject.Models.CousreManagementContext _context;
        private readonly AttendanceRepository _attendanceRepository;


        public IndexModel(BusinessObject.Models.CousreManagementContext context, AttendanceRepository attendanceRepository)
        {
            _context = context;
            _attendanceRepository = attendanceRepository;
        }
        [BindProperty]
        public string SearchKey { get; set; }
        public IList<Attendance> Attendance { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Attendance != null)
            {
                Attendance = await _context.Attendance
                .Include(a => a.Section)
                .Include(a => a.Student).ToListAsync();
            }
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            //search by Fullname
            Attendance = _context.Attendance.Where(p => p.Id.Contains(SearchKey)).ToList();
            return Page();
        }
    }
}
