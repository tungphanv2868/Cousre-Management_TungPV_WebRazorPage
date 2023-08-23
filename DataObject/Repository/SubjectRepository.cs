using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Repository
{
    public class SubjectRepository : ISubject
    {
        public void addSubject(Subject subject) => SubjectService.Instance.addSubject(subject);
        public void deleteSubject(Subject subject) => SubjectService.Instance.deleteSubject(subject);

        public Subject GetByIdSubject(string id) => SubjectService.Instance.GetByIdSubject(id);
        public string GetByNameSubject(string nameSubject) => SubjectService.Instance.GetByNameSubject(nameSubject);
        public IList<Subject> GetList() => SubjectService.Instance.GetList();
        public void updateSubject(Subject subject) => SubjectService.Instance.updateSubject(subject);
    }
}
