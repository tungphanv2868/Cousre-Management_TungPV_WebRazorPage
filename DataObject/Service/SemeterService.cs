using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class SemeterService 
    {
        private static SemeterService instance = null;
        private static readonly object instanceLock = new object();
        private SemeterService() { }
        public static SemeterService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SemeterService();
                    }
                    return instance;
                }
            }
        }
        public void addSemeter(Semeter semeter)
        {
            var _context = new CousreManagementContext();
            _context.Semeter.Add(semeter);
            _context.SaveChangesAsync();
        }

        public void deleteSemeter(Semeter semeter)
        {
            var _context = new CousreManagementContext();
            _context.Semeter.Remove(semeter);
            _context.SaveChangesAsync();
        }

        public Semeter GetByIdSemeter(string id)
        {
            Semeter semeter = null;
            var _context = new CousreManagementContext();
            semeter = _context.Semeter.FirstOrDefault(item => item.Id == id);
            return semeter;
        }

        public string GetByNameSemeter(string nameSemeter)
        {
            Semeter semeter = null;
            var _context = new CousreManagementContext();
            semeter = _context.Semeter.FirstOrDefault(item => item.Name == nameSemeter);
            return semeter.Name;
        }

        public IList<Semeter> GetList()
        {

            List<Semeter> semeters;
            var _context = new CousreManagementContext();
            semeters = _context.Semeter.ToList();
            return semeters;
        }

        public void updateSemeter(Semeter semeter)
        {
            var _context = new CousreManagementContext();
            _context.Semeter.Update(semeter);
            _context.SaveChanges();
        }
    }
}
