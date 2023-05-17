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
    public class MauSacRepos : IMauSacRepos
    {
        DBContextDienThoai _context = new DBContextDienThoai();
        public bool Add(MauSac mauSac)
        {
            _context.mauSacs.Add(mauSac);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(MauSac mauSac)
        {
            _context.Remove(mauSac);
            _context.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _context.mauSacs.ToList();
        }

        public bool Update(MauSac mauSac)
        {
            _context.mauSacs.Update(mauSac);
            _context.SaveChanges();
            return true;
        }
    }
}
