using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class MajorService 
    {
        private static MajorService instance = null;
        private static readonly object instanceLock = new object();
        private MajorService() { }
        public static MajorService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MajorService();
                    }
                    return instance;
                }
            }
        }
        public void addMajor(Major major)
        {

            var _context = new CousreManagementContext();
            _context.Major.Add(major);
            _context.SaveChangesAsync();
        }

        public void deleteMajor(Major major)
        {
            var _context = new CousreManagementContext();
            _context.Major.Remove(major);
            _context.SaveChangesAsync();
        }

        public Major GetByIdMajor(string id)
        {
            Major major = null;
            var _context = new CousreManagementContext();
            major = _context.Major.FirstOrDefault(item => item.Id == id);
            return major;
        }

        public string GetByNameMajor(string nameMajor)
        {
            Major major = null;
            var _context = new CousreManagementContext();
            major = _context.Major.FirstOrDefault(item => item.Name == nameMajor);
            return major.Name;
        }

        public IList<Major> GetList()
        {
            List<Major> major;
            var _context = new CousreManagementContext();
            major = _context.Major.ToList();
            return major;
        }

        public void updateMajor(Major major)
        {
            var _context = new CousreManagementContext();
            _context.Major.Update(major);
            _context.SaveChanges();
        }
    }
}
