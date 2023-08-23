using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAttendance
    {
        IList<Attendance> GetList();
        Attendance GetByIdAttendance(string id);
        void addAttendance(Attendance attendance);
        void deleteAttendance(Attendance attendance);
        void updateAttendance(Attendance attendance);
    }
}
