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
    public class DungLuongRepos : IDungLuongRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(DungLuong dungLuong)
        {
            _context.dungLuongs.Add(dungLuong);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(DungLuong dungLuong)
        {
            _context.Remove(dungLuong);
            _context.SaveChanges();
            return true;
        }

        public List<DungLuong> GetAll()
        {
            return _context.dungLuongs.ToList();
        }

        public bool Update(DungLuong dungLuong)
        {
            _context.dungLuongs.Update(dungLuong);
            _context.SaveChanges();
            return true;
        }
    }
}
