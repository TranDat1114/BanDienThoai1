using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using _2BUS.ViewModel;
namespace _2BUS.IService
{
    public interface IHoaDonCTService_
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        List<HoaDonChiTiet> GetAll();
        List<HoaDonCTView> GetAllView();
        List<HoaDonChiTietView> GetAllViewView(int orderID);
    }
}
