using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IDTRepos
    {
        bool Add(DienThoai dienThoai);
        bool Update(DienThoai dienThoai);
        bool Delete(DienThoai dienThoai);
        List<DienThoai> GetAll();
    }
}
