using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IDTCTRepos
    {
        bool Add(DienThoaiCT dienThoaiCT);
        bool Update(DienThoaiCT dienThoaiCT);
        bool Delete(DienThoaiCT dienThoaiCT);
        List<DienThoaiCT> GetAll();
    }
}
