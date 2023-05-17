using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.ConText;
using _1DAL.IRepository;
using _1DAL.Models;
namespace _1DAL.Repositorys
{
    public class HoaDonCTRepos : IHoaDonCTRepos
    {
        DBContextDienThoai _dbcontext = new DBContextDienThoai();

        public bool Add(HoaDonChiTiet hoaDon)
        {
            _dbcontext.hoaDonChiTiets.Add(hoaDon);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet hoaDon)
        {
            _dbcontext.hoaDonChiTiets.Remove(hoaDon);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbcontext.hoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet hoaDon)
        {
            _dbcontext.hoaDonChiTiets.Update(hoaDon);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
