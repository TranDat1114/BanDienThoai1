using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using _1DAL.IRepository;
using _1DAL.ConText;
using Microsoft.EntityFrameworkCore;

namespace _1DAL.Repositorys
{
    public class KhachHangRepos : IKhachHangRepos
    {
        private readonly DBContextDienThoai dbcontext;
        public KhachHangRepos(DBContextDienThoai dBContextDienThoai) {
            dbcontext = dBContextDienThoai;
        }
        public bool Add(KhachHang KhachHang)
        {
            dbcontext.khachHangs.Add(KhachHang);
            dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang KhachHang)
        {
            dbcontext.khachHangs.Remove(KhachHang);
            dbcontext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return dbcontext.khachHangs.ToList();
        }

        public bool Update(KhachHang KhachHang)
        {
            dbcontext.khachHangs.Update(KhachHang);
            dbcontext.SaveChanges();
            return true;
        }
    }
}
