using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using _2BUS.ViewModel;

namespace _2BUS.IService
{
    public interface IDTCTService
    {
        bool Add(DienThoaiCT obj);
        bool Update(DienThoaiCT obj);
        bool Delete(DienThoaiCT obj);
        List<DienThoaiCT> GetAll();
        List<ChiTietSPView> GetAllDTCT();
    }
}
