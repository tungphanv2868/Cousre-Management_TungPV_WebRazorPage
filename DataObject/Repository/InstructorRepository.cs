using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class InstructorRepository : IInstructor
    {
        public void addInstructor(Instructor instructor) => InstructorService.Instance.addInstructor(instructor);
        public void deleteInstructor(Instructor instructor) => InstructorService.Instance.deleteInstructor(instructor);
        public Instructor GetByIdInstructor(string id) => InstructorService.Instance.GetByIdInstructor(id);
        public string GetByNameInstructor(string nameInstructor) => InstructorService.Instance.GetByNameInstructor(nameInstructor);
        public IList<Instructor> GetList() => InstructorService.Instance.GetList();
        public void updateInstructor(Instructor instructor) => InstructorService.Instance.updateInstructor(instructor);
    }
}
