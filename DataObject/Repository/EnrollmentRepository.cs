using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class EnrollmentRepository : IEnrollment
    {
        public void addEnrollment(Enrollment enrollment) => EnrollmentService.Instance.addEnrollment(enrollment);

        public void deleteEnrollment(Enrollment enrollment) => EnrollmentService.Instance.deleteEnrollment(enrollment);

        public Enrollment GetByIdEnrollment(string id) => EnrollmentService.Instance.GetByIdEnrollment(id);

        public IList<Enrollment> GetList() => EnrollmentService.Instance.GetList();

        public void updateEnrollment(Enrollment enrollment) => EnrollmentService.Instance.updateEnrollment(enrollment);

    }
}
