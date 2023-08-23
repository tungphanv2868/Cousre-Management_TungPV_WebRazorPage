using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class StudentService
    {
        private static StudentService instance = null;
        private static readonly object instanceLock = new object();
        private StudentService() { }
        public static StudentService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StudentService();
                    }
                    return instance;
                }
            }
        }
        public void addStudent(Student student)
        {
            var _context = new CousreManagementContext();
            _context.Student.Add(student);
            _context.SaveChangesAsync();
        }

        public void deleteStudent(Student student)
        {
            var _context = new CousreManagementContext();
            _context.Student.Remove(student);
            _context.SaveChangesAsync();
        }

        public Student GetByIdStudent(string id)
        {
            Student student = null;
            var _context = new CousreManagementContext();
            student = _context.Student.FirstOrDefault(item => item.Id == id);
            return student;
        }

        public string GetByLastNameStudent(string lastStudent)
        {
            Student student = null;
            var _context = new CousreManagementContext();
            student = _context.Student.FirstOrDefault(item => item.LastName == lastStudent);
            return student.LastName;
        }

        public IList<Student> GetList()
        {
            List<Student> instructor;
            var _context = new CousreManagementContext();
            instructor = _context.Student.ToList();
            return instructor;
        }

        public void updateStudent(Student student)
        {
            var _context = new CousreManagementContext();
            _context.Student.Update(student);
            _context.SaveChanges();
        }
    }
}
