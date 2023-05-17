using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using _2BUS.ViewModel;
namespace _2BUS.IService
{
    public interface INhanVienService
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        List<NhanVien> GetAll();
        List<NhanVienView> GetAllView();
    }
}
