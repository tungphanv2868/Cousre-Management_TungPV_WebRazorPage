using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IEnrollment
    {
        IList<Enrollment> GetList();
        Enrollment GetByIdEnrollment(string id);
        void addEnrollment(Enrollment enrollment);
        void deleteEnrollment(Enrollment enrollment);
        void updateEnrollment(Enrollment enrollment);
    }
}
