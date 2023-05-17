using _1DAL.IRepository;
using _1DAL.Models;
using _2BUS.IService;
using _1DAL.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2BUS.ViewModel;

namespace _2BUS.Service
{
    public class DTCTService : IDTCTService
    {
        IDTCTRepos _iDT = new DTCTRepos();
        IDTRepos _dienthoai = new DTRepos();
        IMauSacRepos _mausac = new MauSacRepos();
        IImeiRepos _imei = new ImeiRepos();
        IDungLuongRepos _dungluong = new DungLuongRepos();
        IHSXRepos _HSX = new HSXRepos();
        public bool Add(DienThoaiCT obj)
        {
            _iDT.Add(obj);
            return true;
        }

        public bool Delete(DienThoaiCT obj)
        {
            _iDT.Delete(obj);
            return true;
        }

        public List<DienThoaiCT> GetAll()
        {
            return _iDT.GetAll();
        }

        public bool Update(DienThoaiCT obj)
        {
            _iDT.Update(obj);
            return true;
        }
        public List<ChiTietSPView> GetAllDTCT()
        {
            List<ChiTietSPView> list = new List<ChiTietSPView>();
            list = (from a in _iDT.GetAll()
                    join b in _HSX.GetAll() on a.MaHang equals b.MaHang
                    join c in _dienthoai.GetAll() on a.MaDT equals c.MaDT
                    join d in _dungluong.GetAll() on a.MaDungLuong equals d.MaDungLuong
                    join e in _imei.GetAll() on a.MaImei equals e.MaImei
                    join f in _mausac.GetAll() on a.MaMau equals f.MaMau
                    select new ChiTietSPView()
                    {
                        dienThoaiCT = a,
                        hangSX = b,
                        dienThoai = c,
                        dungLuong = d,
                        imei = e,
                        mauSac = f,
                    }).ToList();
            return list;
        }
    }
}
