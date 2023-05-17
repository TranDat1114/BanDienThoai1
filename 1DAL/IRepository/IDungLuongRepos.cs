using _1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IDungLuongRepos
    {
        bool Add(DungLuong dungLuong);
        bool Update(DungLuong dungLuong);
        bool Delete(DungLuong dungLuong);
        List<DungLuong> GetAll();

    }
}
