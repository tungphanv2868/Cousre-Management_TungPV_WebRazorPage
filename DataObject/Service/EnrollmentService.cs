using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class EnrollmentService : IEnrollment
    {
        private static EnrollmentService instance = null;
        private static readonly object instanceLock = new object();
        private EnrollmentService() { }
        public static EnrollmentService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EnrollmentService();
                    }
                    return instance;
                }
            }
        }
        public void addEnrollment(Enrollment enrollment)
        {
            var _context = new CousreManagementContext();
            _context.Enrollment.Add(enrollment);
            _context.SaveChangesAsync();
        }

        public void deleteEnrollment(Enrollment enrollment)
        {
            var _context = new CousreManagementContext();
            _context.Enrollment.Remove(enrollment);
            _context.SaveChangesAsync();
        }

        public Enrollment GetByIdEnrollment(string id)
        {
            Enrollment enrollment = null;
            var _context = new CousreManagementContext();
            enrollment = _context.Enrollment.FirstOrDefault(item => item.Id == id);
            return enrollment;
        }

        public IList<Enrollment> GetList()
        {
            List<Enrollment> enrollment;
            var _context = new CousreManagementContext();
            enrollment = _context.Enrollment.ToList();
            return enrollment;
        }

        public void updateEnrollment(Enrollment enrollment)
        {
            var _context = new CousreManagementContext();
            _context.Enrollment.Update(enrollment);
            _context.SaveChanges();
        }
    }
}
