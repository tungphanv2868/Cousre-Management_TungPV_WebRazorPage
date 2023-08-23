using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ISubject
    {
        IList<Subject> GetList();
        Subject GetByIdSubject(string id);
        void addSubject(Subject subject);
        void deleteSubject(Subject subject);
        void updateSubject(Subject subject);
        string GetByNameSubject(string nameSubject);
    }
}
