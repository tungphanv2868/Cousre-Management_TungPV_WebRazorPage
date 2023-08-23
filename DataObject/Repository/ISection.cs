using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ISection
    {
        IList<Section> GetList();
        Section GetByIdSection(string id);
        void addSection(Section section);
        void deleteSection(Section section);
        void updateSection(Section section);
        string GetByNameSection(string nameSection);
    }
}
