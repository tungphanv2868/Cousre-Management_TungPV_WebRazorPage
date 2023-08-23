using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ISemeter
    {
        IList<Semeter> GetList();
        Semeter GetByIdSemeter(string id);
        void addSemeter(Semeter semeter);
        void deleteSemeter(Semeter semeter);
        void updateSemeter(Semeter semeter);
        string GetByNameSemeter(string nameSemeter);
    }
}
