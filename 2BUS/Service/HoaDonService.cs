using _1DAL.IRepository;
using _1DAL.Models;
using _1DAL.Repositorys;

using _2BUS.IService;
using _2BUS.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BUS.Service
{
    public class HoaDonService : IHoaDonService
    {

        private IHoaDonRepos _hd;
        private IKhachHangRepos _hkachHangRepos;
        private INhanVienRepos _nhanVienRepos;


        public HoaDonService(IKhachHangRepos khachHangRepos, INhanVienRepos nhanVienRepos, IHoaDonRepos hoaDonRepos)
        {
            _hkachHangRepos = khachHangRepos;
            _nhanVienRepos = nhanVienRepos;
            _hd = hoaDonRepos;
        }
        public bool Add(HoaDon obj)
        {
            _hd.Add(obj);
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            _hd.Delete(obj);
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _hd.GetAll();
        }

        public List<HoaDonView> GetAllView()
        {
            List<HoaDonView> list = new List<HoaDonView>();
            list = (from a in _hd.GetAll()
                    join b in _nhanVienRepos.GetAll() on a.MaNV equals b.MaNV
                    join c in _hkachHangRepos.GetAll() on a.MaKH equals c.MaKH

                    select new HoaDonView()
                    {
                        hoaDon = a,
                        nhanVien = b,
                        khachHang = c,
                    }).ToList();
            return list;
        }

        public List<HoaDonViewView> GetAllViewView()
        {
            var data = (from o in _hd.GetAll()
                        join c in _hkachHangRepos.GetAll() on o.MaKH equals c.MaKH
                        join e in _nhanVienRepos.GetAll() on o.MaNV equals e.MaNV
                        select new HoaDonViewView
                        {
                            ID = o.MaHD,
                            DateCreated = o.NgayBan,
                            EmployeeEmail = e.TenNV,
                            CustomerPhoneNumber = c.SDT,
                            TotalPrice = o.Tong,
                            Status = o.TrangThai,
                            Note = o.Ghichu
                        }).ToList();

            return data;
        }

        public bool Update(HoaDon obj)
        {
            _hd.Update(obj);
            return true;
        }
    }
}
