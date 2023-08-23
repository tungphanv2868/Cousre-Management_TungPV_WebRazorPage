using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SectionRepository : ISection
    {
        public void addSection(Section section) => SectionService.Instance.addSection(section);
        public void deleteSection(Section section) => SectionService.Instance.deleteSection(section);

        public Section GetByIdSection(string id) => SectionService.Instance.GetByIdSection(id);

        public string GetByNameSection(string nameSection) => SectionService.Instance.GetByNameSection(nameSection);


        public IList<Section> GetList() => SectionService.Instance.GetList();

        public void updateSection(Section section) => SectionService.Instance.updateSection(section);

    }
}
