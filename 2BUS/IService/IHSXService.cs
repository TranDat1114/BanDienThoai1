using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;

namespace _2BUS.IService
{
    public interface IHSXService
    {
        bool Add(HangSX obj);
        bool Update(HangSX obj);
        bool Delete(HangSX obj);
        List<HangSX> GetAll();
    }
}
