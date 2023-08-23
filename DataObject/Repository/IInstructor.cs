using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IInstructor
    {
        IList<Instructor> GetList();
        Instructor GetByIdInstructor(string id);
        void addInstructor(Instructor instructor);
        void deleteInstructor(Instructor instructor);
        void updateInstructor(Instructor instructor);
        string GetByNameInstructor(string nameInstructor);
    }
}
