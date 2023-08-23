using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class CourseService 
    {
        private static CourseService instance = null;
        private static readonly object instanceLock = new object();
        private CourseService() { }
        public static CourseService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CourseService();
                    }
                    return instance;
                }
            }
        }
        public void addCourse(Course course)
        {
            var _context = new CousreManagementContext();
            _context.Course.Add(course);
            _context.SaveChangesAsync();
        }

        public void deleteCourse(Course course)
        {
            var _context = new CousreManagementContext();
            _context.Course.Remove(course);
            _context.SaveChangesAsync();
        }

        public Course GetByIdCourse(string id)
        {
            Course course = null;
            var _context = new CousreManagementContext();
            course = _context.Course.FirstOrDefault(item => item.Id == id);
            return course;
        }

        public string GetByNameCourse(string nameCourse)
        {
            Course course = null;
            var _context = new CousreManagementContext();
            course = _context.Course.FirstOrDefault(item => item.Name == nameCourse);
            return course.Name;
        }

        public IList<Course> GetList()
        {
            List<Course> course;
            var _context = new CousreManagementContext();
            course = _context.Course.ToList();
            return course;
        }

        public void updateCourse(Course course)
        {
            var _context = new CousreManagementContext();
            _context.Course.Update(course);
            _context.SaveChanges();
        }
    }
}
