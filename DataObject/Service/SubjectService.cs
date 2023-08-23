using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Service
{
    public class SubjectService 
    {
        private static SubjectService instance = null;
        private static readonly object instanceLock = new object();
        private SubjectService() { }
        public static SubjectService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SubjectService();
                    }
                    return instance;
                }
            }
        }
        public void addSubject(Subject subject)
        {
            var _context = new CousreManagementContext();
            _context.Subject.Add(subject);
            _context.SaveChangesAsync();
        }

        public void deleteSubject(Subject subject)
        {
            var _context = new CousreManagementContext();
            _context.Subject.Remove(subject);
            _context.SaveChangesAsync();
        }

        public Subject GetByIdSubject(string id)
        {
            Subject subject = null;
            var _context = new CousreManagementContext();
            subject = _context.Subject.FirstOrDefault(item => item.Id == id);
            return subject;
        }

        public string GetByNameSubject(string nameSubject)
        {
            Subject subject = null;
            var _context = new CousreManagementContext();
            subject = _context.Subject.FirstOrDefault(item => item.Name == nameSubject);
            return subject.Name;
        }

        public IList<Subject> GetList()
        {
            List<Subject> subject;
            var _context = new CousreManagementContext();
            subject = _context.Subject.ToList();
            return subject;
        }

        public void updateSubject(Subject subject)
        {
            var _context = new CousreManagementContext();
            _context.Subject.Update(subject);
            _context.SaveChanges();
        }
    }
}
