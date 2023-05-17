using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using _1DAL.Repositorys;
using _1DAL.IRepository;
using _2BUS.IService;
namespace _2BUS.Service
{
    public class ChucVuService : IChucVuService
    {
        IChucVuRepos _CV = new  ChucVuRepos();

        public bool Add(ChucVu obj)
        {
            _CV.Add(obj);
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            _CV.Delete(obj);
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _CV.GetAll();
        }

        public bool Update(ChucVu obj)
        {
            _CV.Update(obj);
            return true;
        }
    }
}
