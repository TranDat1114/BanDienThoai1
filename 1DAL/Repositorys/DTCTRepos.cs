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
    public class DTCTRepos : IDTCTRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(DienThoaiCT dienThoaiCT)
        {
            _context.dienThoaiCTs.Add(dienThoaiCT);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(DienThoaiCT dienThoaiCT)
        {
            _context.Remove(dienThoaiCT);
            _context.SaveChanges();
            return true;
        }

        public List<DienThoaiCT> GetAll()
        {
            return _context.dienThoaiCTs.ToList();
        }

        public bool Update(DienThoaiCT dienThoaiCT)
        {
            _context.dienThoaiCTs.Update(dienThoaiCT);
            _context.SaveChanges();
            return true;
        }
    }
}
