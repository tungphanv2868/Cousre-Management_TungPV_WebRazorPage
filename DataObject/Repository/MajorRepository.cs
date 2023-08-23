using BusinessObject.Models;
using DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MajorRepository : IMajor
    {
        public void addMajor(Major major) => MajorService.Instance.addMajor(major);

        public void deleteMajor(Major major) => MajorService.Instance.deleteMajor(major);

        public Major GetByIdMajor(string id) => MajorService.Instance.GetByIdMajor(id);

        public string GetByNameMajor(string nameMajor) => MajorService.Instance.GetByNameMajor(nameMajor);
        public IList<Major> GetList() => MajorService.Instance.GetList();
        public void updateMajor(Major major) => MajorService.Instance.updateMajor(major);

    }
}
