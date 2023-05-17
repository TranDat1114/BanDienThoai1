using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;

namespace _2BUS.IService
{
    public interface IChucVuService
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        List<ChucVu> GetAll();
        
    }
}
