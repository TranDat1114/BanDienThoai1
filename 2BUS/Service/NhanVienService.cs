using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Repositorys;
using _1DAL.IRepository;
using _2BUS.IService;
using _2BUS.ViewModel;
using _1DAL.Models;

namespace _2BUS.Service
{
    public class NhanVienService : INhanVienService
    {
        private IChucVuRepos _chucVuRepos { get; set; }
        private INhanVienRepos _NV { get; set; }
        public NhanVienService(IChucVuRepos  chucVuRepos, INhanVienRepos nhanVienRepos)
        {
            _chucVuRepos = chucVuRepos;
            _NV = nhanVienRepos;
        }
        
        public bool Add(NhanVien obj)
        {
           _NV.Add(obj);
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            _NV.Delete(obj);
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _NV.GetAll();
        }

        public List<NhanVienView> GetAllView()
        {
            List<NhanVienView> list = new List<NhanVienView>();
            list = (from a in _NV.GetAll()
                    join b in _chucVuRepos.GetAll() on a.MaCV equals b.MaCV
                 
                    select new NhanVienView()
                    {
                        nhanVien = a,
                        chucVu = b,
                    }).ToList();
            return list;
        }

        public bool Update(NhanVien obj)
        {
            _NV.Update(obj);
            return true;
        }
    }
}
