using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _2BUS.IService
{
    public interface IDTService
    {
        bool Add(DienThoai obj);
        bool Update(DienThoai obj);
        bool Delete(DienThoai obj);
        List<DienThoai> GetAll();
    }
}
