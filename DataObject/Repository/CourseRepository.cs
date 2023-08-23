using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CourseRepository : ICourse
    {
        public void addCourse(Course course) => CourseService.Instance.addCourse(course);

        public void deleteCourse(Course course) => CourseService.Instance.deleteCourse(course);

        public Course GetByIdCourse(string id) => CourseService.Instance.GetByIdCourse(id);

        public string GetByNameCourse(string nameCourse) => CourseService.Instance.GetByNameCourse(nameCourse);
        public IList<Course> GetList() => CourseService.Instance.GetList();

        public void updateCourse(Course course) => CourseService.Instance.addCourse(course);
    }
}
