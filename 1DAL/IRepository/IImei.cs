using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IImeiRepos
    {
        bool Add(Imei imei);
        bool Update(Imei imei);
        bool Delete(Imei imei);
        List<Imei> GetAll();
    }
}
