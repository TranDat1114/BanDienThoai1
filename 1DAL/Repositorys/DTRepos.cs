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
    public class DTRepos : IDTRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(DienThoai dienThoai)
        {
            _context.dienThoais.Add(dienThoai);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(DienThoai dienThoai)
        {
            _context.Remove(dienThoai);
            _context.SaveChanges();
            return true;
        }

        public List<DienThoai> GetAll()
        {
            return _context.dienThoais.ToList();
        }

        public bool Update(DienThoai dienThoai)
        {
            _context.dienThoais.Update(dienThoai);
            _context.SaveChanges();
            return true;
        }
    }
}
