using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IHoaDonCTRepos
    {
        bool Add(HoaDonChiTiet hoaDon);
        bool Update(HoaDonChiTiet hoaDon);
        bool Delete(HoaDonChiTiet hoaDon);
        List<HoaDonChiTiet> GetAll();
    }
}
