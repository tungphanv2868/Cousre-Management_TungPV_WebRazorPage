using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class StudentRepository : IStudent
    {
        public void addStudent(Student student) => StudentService.Instance.addStudent(student);
        public void deleteStudent(Student student) => StudentService.Instance.deleteStudent(student);
        public Student GetByIdStudent(string id) => StudentService.Instance.GetByIdStudent(id);
        public string GetByLastNameStudent(string lastStudent) => StudentService.Instance.GetByLastNameStudent(lastStudent);
        public IList<Student> GetList() => StudentService.Instance.GetList();
        public void updateStudent(Student student) => StudentService.Instance.updateStudent(student);
    }
}
