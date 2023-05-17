using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2BUS.IService;
using _1DAL.IRepository;
using _1DAL.Models;
using _1DAL.Repositorys;
namespace _2BUS.Service
{
    public class KhachHangService : IKhachHangService
    {
      private  IKhachHangRepos _KH;
        public KhachHangService(
            IKhachHangRepos khachHangRepos
            ) {
            _KH = khachHangRepos;
        }
        public bool Add(KhachHang obj)
        {
            _KH.Add(obj);
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            _KH.Delete(obj);
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _KH.GetAll();
        }

        public bool Update(KhachHang obj)
        {
            _KH.Update(obj);
            return true;
        }
    }
}
