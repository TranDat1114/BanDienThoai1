using _1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;

namespace _1DAL.IRepository
{
    public interface IHoaDonRepos
    {
        bool Add(HoaDon hoaDon);
        bool Update(HoaDon hoaDon);
        bool Delete(HoaDon hoaDon);
        List<HoaDon> GetAll();
    }
}
