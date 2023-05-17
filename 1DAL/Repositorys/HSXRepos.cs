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
    public class HSXRepos : IHSXRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(HangSX hangSX)
        {
            _context.hangSXs.Add(hangSX);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(HangSX hangSX)
        {
            _context.Remove(hangSX);
            _context.SaveChanges();
            return true;
        }

        public List<HangSX> GetAll()
        {
            return _context.hangSXs.ToList();
        }

        public bool Update(HangSX hangSX)
        {
            _context.hangSXs.Update(hangSX);
            _context.SaveChanges();
            return true;
        }
    }
}
