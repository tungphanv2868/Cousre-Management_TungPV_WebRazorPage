using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AttendanceRepository : IAttendance
    {
        public void addAttendance(Attendance attendance) => AttendanceService.Instance.addAttendance(attendance);
        public void deleteAttendance(Attendance attendance) => AttendanceService.Instance.deleteAttendance(attendance);
        public Attendance GetByIdAttendance(string id) => AttendanceService.Instance.GetByIdAttendance(id);
        public IList<Attendance> GetList() => AttendanceService.Instance.GetList();
        public void updateAttendance(Attendance attendance) => AttendanceService.Instance.updateAttendance(attendance);
    }
}
