using _1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2BUS.ViewModel;
namespace _2BUS.IService
{
    public interface IHoaDonService
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        List<HoaDon> GetAll();
        List<HoaDonView> GetAllView();
        List<HoaDonViewView> GetAllViewView();

    }
}
