using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using _1DAL.IRepository;
using _1DAL.ConText;
namespace _1DAL.Repositorys
{
    public class NhanVienRepos : INhanVienRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(NhanVien nhanVien)
        {
            _context.nhanViens.Add(nhanVien);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien nhanVien)
        {
            _context.nhanViens.Remove(nhanVien);
            _context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _context.nhanViens.ToList();
        }

        public bool Update(NhanVien nhanVien)
        {
            _context.nhanViens.Update(nhanVien);
            _context.SaveChanges();
            return true;
        }
    }
}
