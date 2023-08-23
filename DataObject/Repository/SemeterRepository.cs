using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SemeterRepository : ISemeter
    {
        public void addSemeter(Semeter semeter) => SemeterService.Instance.addSemeter(semeter);

        public void deleteSemeter(Semeter semeter) => SemeterService.Instance.deleteSemeter(semeter);

        public Semeter GetByIdSemeter(string id) => SemeterService.Instance.GetByIdSemeter(id);
        public string GetByNameSemeter(string nameSemeter) => SemeterService.Instance.GetByNameSemeter(nameSemeter);

        public IList<Semeter> GetList() => SemeterService.Instance.GetList();
        public void updateSemeter(Semeter semeter) => SemeterService.Instance.updateSemeter(semeter);
    }
}
