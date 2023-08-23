using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICourse
    {
        IList<Course> GetList();
        Course GetByIdCourse(string id);
        void addCourse(Course course);
        void deleteCourse(Course course);
        void updateCourse(Course course);
        string GetByNameCourse(string nameCourse);
    }
}
