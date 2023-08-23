using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class AttendanceService
    {
        private static AttendanceService instance = null;
        private static readonly object instanceLock = new object();
        private AttendanceService() { }
        public static AttendanceService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AttendanceService();
                    }
                    return instance;
                }
            }
        }
        public void addAttendance(Attendance attendance)
        {
            var _context = new CousreManagementContext();
            _context.Attendance.Add(attendance);
            _context.SaveChangesAsync();
        }

        public void deleteAttendance(Attendance attendance)
        {
            var _context = new CousreManagementContext();
            _context.Attendance.Remove(attendance);
            _context.SaveChangesAsync();
        }

        public Attendance GetByIdAttendance(string id)
        {
            Attendance attendance = null;
            var _context = new CousreManagementContext();
            attendance = _context.Attendance.FirstOrDefault(item => item.Id == id);
            return attendance;
        }

        public IList<Attendance> GetList()
        {
            List<Attendance> attendance;
            var _context = new CousreManagementContext();
            attendance = _context.Attendance.ToList();
            return attendance;
        }

        public void updateAttendance(Attendance attendance)
        {
            var _context = new CousreManagementContext();
            _context.Attendance.Update(attendance);
            _context.SaveChanges();
        }
    }
}
