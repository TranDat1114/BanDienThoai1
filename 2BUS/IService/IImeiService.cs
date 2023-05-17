using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _2BUS.IService
{
    public interface IImeiService
    {
        bool Add(Imei obj);
        bool Update(Imei obj);
        bool Delete(Imei obj);
        List<Imei> GetAll();
    }
}
