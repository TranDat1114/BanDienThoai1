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
    public class ImeiRepos : IImeiRepos
    {
        private DBContextDienThoai _context;
        public ImeiRepos(DBContextDienThoai dBContextDienThoai)
        {
            _context = dBContextDienThoai;
        }
        public bool Add(Imei imei)
        {
            _context.Imeis.Add(imei);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(Imei imei)
        {
            _context.Remove(imei);
            _context.SaveChanges();
            return true;
        }

        public List<Imei> GetAll()
        {
            return _context.Imeis.ToList();
        }

        public bool Update(Imei imei)
        {
            _context.Imeis.Update(imei);
            _context.SaveChanges();
            return true;
        }
    }
}
