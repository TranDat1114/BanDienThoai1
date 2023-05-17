using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.IRepository;
using _1DAL.ConText;
using _1DAL.Models;
namespace _1DAL.Repositorys
{
    public class ChucVuRepos : IChucVuRepos
    {
        DBContextDienThoai _dbcontext = new DBContextDienThoai();
        public bool Add(ChucVu chucVu)
        {
            _dbcontext.chucVus.Add(chucVu);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu chucVu)
        {
            _dbcontext.chucVus.Remove(chucVu);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dbcontext.chucVus.ToList();
        }

        public bool Update(ChucVu chucVu)
        {
            _dbcontext.chucVus.Update(chucVu);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
