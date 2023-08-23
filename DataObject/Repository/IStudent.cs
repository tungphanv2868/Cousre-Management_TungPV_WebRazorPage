using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IStudent
    {
        IList<Student> GetList();
        Student GetByIdStudent(string id);
        void addStudent(Student student);
        void deleteStudent(Student student);
        void updateStudent(Student student);
        string GetByLastNameStudent(string lastStudent);
    }
}
