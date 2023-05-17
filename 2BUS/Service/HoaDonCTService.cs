using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Repositorys;
using _1DAL.IRepository;
using _2BUS.IService;
using _1DAL.Models;
using _2BUS.ViewModel;

namespace _2BUS.Service
{
    public class HoaDonCTService : IHoaDonCTService_
    {
        IHoaDonRepos _HD = new HoaDonRepos();
        IDTCTRepos _IDTCT= new DTCTRepos();
        IHoaDonCTRepos _hoaDonCTRepos = new HoaDonCTRepos();
        List<HoaDonChiTiet> _lsthdct = new List<HoaDonChiTiet>();
        IDTRepos _DT = new DTRepos();
        public bool Add(HoaDonChiTiet obj)
        {
            _hoaDonCTRepos.Add(obj);
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            _hoaDonCTRepos.Delete(obj);
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _hoaDonCTRepos.GetAll();
        }

        public List<HoaDonCTView> GetAllView()
        {
            List<HoaDonCTView> list = new List<HoaDonCTView>();
            list = (from a in _hoaDonCTRepos.GetAll()
                    join b in _IDTCT.GetAll() on a.MaDTCT equals b.MaDTCT
              
                    join d in _HD.GetAll() on a.MaHD equals d.MaHD
                    select new HoaDonCTView()
                    {
                        HoaDonChiTietS = a,
                        DienThoaiCTS = b,
                      
                        HoaDonS = d,
                    }).ToList();
            return list;
        }

        public List<HoaDonChiTietView> GetAllViewView(int orderID)
        {
            var data = (from od in _hoaDonCTRepos.GetAll()
                        join o in _HD.GetAll() on od.MaHD equals o.MaHD
                        join p in _IDTCT.GetAll() on od.MaDTCT equals p.MaDTCT

                        where od.MaHD == orderID
                        select new HoaDonChiTietView
                        {
                            Id = od.MaHD,
                            MaSP = p.MaDTCT,
                            tendienthoai = p.MaQR,
                            DonGia = od.DonGia,
                            Soluong = od.SoLuong
                        }).ToList();
            return data;
        }

       

        public bool Update(HoaDonChiTiet obj)
        {
            _hoaDonCTRepos.Update(obj);
            return true;
        }
    }
}
