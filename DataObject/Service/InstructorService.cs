using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class InstructorService
    {
            private static InstructorService instance = null;
            private static readonly object instanceLock = new object();
            private InstructorService() { }
            public static InstructorService Instance
            {
                get
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new InstructorService();
                        }
                        return instance;
                    }
                }
            }
        
        public void addInstructor(Instructor instructor)
        {
            var _context = new CousreManagementContext();
            _context.Instructor.Add(instructor);
            _context.SaveChangesAsync();
        }

        public void deleteInstructor(Instructor instructor)
        {
            var _context = new CousreManagementContext();
            _context.Instructor.Remove(instructor);
            _context.SaveChangesAsync();
        }

        public Instructor GetByIdInstructor(string id)
        {
            Instructor instructor = null;
            var _context = new CousreManagementContext();
            instructor = _context.Instructor.FirstOrDefault(item => item.Id == id);
            return instructor;
        }

        public string GetByNameInstructor(string nameInstructor)
        {
            Instructor instructor = null;
            var _context = new CousreManagementContext();
            instructor = _context.Instructor.FirstOrDefault(item => item.Name == nameInstructor);
            return instructor.Name;
        }

        public IList<Instructor> GetList()
        {
            List<Instructor> instructor;
            var _context = new CousreManagementContext();
            instructor = _context.Instructor.ToList();
            return instructor;
        }

        public void updateInstructor(Instructor instructor)
        {
            var _context = new CousreManagementContext();
            _context.Instructor.Update(instructor);
            _context.SaveChanges();
        }
    }
}
