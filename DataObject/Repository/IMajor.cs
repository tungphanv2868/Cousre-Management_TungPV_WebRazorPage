using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMajor
    {
        IList<Major> GetList();
        Major GetByIdMajor(string id);
        void addMajor(Major major);
        void deleteMajor(Major major);
        void updateMajor(Major major);
        string GetByNameMajor(string nameMajor);
    }
}
