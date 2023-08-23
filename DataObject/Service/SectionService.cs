using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class SectionService 
    {
        private static SectionService instance = null;
        private static readonly object instanceLock = new object();
        private SectionService() { }
        public static SectionService Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SectionService();
                    }
                    return instance;
                }
            }
        }
        public void addSection(Section section)
        {
            var _context = new CousreManagementContext();
            _context.Section.Add(section);
            _context.SaveChangesAsync();
        }

        public void deleteSection(Section section)
        {
            var _context = new CousreManagementContext();
            _context.Section.Remove(section);
            _context.SaveChangesAsync();
        }

        public Section GetByIdSection(string id)
        {
            Section section = null;
            var _context = new CousreManagementContext();
            section = _context.Section.FirstOrDefault(item => item.Id == id);
            return section;
        }

        public string GetByNameSection(string nameSection)
        {

            Section section = null;
            var _context = new CousreManagementContext();
            section = _context.Section.FirstOrDefault(item => item.Name == nameSection);
            return section.Name;
        }

        public IList<Section> GetList()
        {
            List<Section> course;
            var _context = new CousreManagementContext();
            course = _context.Section.ToList();
            return course;
        }

        public void updateSection(Section section)
        {
            var _context = new CousreManagementContext();
            _context.Section.Update(section);
            _context.SaveChanges();
        }
    }
}
