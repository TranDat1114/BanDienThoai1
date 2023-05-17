using _1DAL.ConText;
using _1DAL.IRepository;
using _1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Repositorys
{
    public class HoaDonRepos : IHoaDonRepos
    {
        DBContextDienThoai _dbcontext = new DBContextDienThoai();

        public bool Add(HoaDon hoaDon)
        {
            _dbcontext.hoaDons.Add(hoaDon);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon hoaDon)
        {
            _dbcontext.Remove(hoaDon);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _dbcontext.hoaDons.ToList();
        }

        public bool Update(HoaDon hoaDon)
        {
            _dbcontext.hoaDons.Update(hoaDon);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
