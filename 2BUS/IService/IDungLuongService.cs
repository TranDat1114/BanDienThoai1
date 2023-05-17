using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;

namespace _2BUS.IService
{
    public interface IDungLuongService
    {
        bool Add(DungLuong obj);
        bool Update(DungLuong obj);
        bool Delete(DungLuong obj);
        List<DungLuong> GetAll();
    }
}
