using _1DAL.IRepository;
using _1DAL.Models;
using _2BUS.IService;
using _1DAL.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BUS.Service
{
    public class MauSacService : IMauSacService
    {
        IMauSacRepos _mauSac = new MauSacRepos();
        public bool Add(MauSac obj)
        {
            _mauSac.Add(obj);
            return true;
        }

        public bool Delete(MauSac obj)
        {
            _mauSac.Delete(obj);
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _mauSac.GetAll();
        }

        public bool Update(MauSac obj)
        {
            _mauSac.Update(obj);
            return true;
        }
    }
}
