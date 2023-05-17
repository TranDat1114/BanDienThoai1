using _1DAL.Models;
using _2BUS.IService;
using _1DAL.IRepository;
using _1DAL.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BUS.Service
{
    public class HSXService : IHSXService
    {
        IHSXRepos _hSX = new HSXRepos();
        public bool Add(HangSX obj)
        {
            _hSX.Add(obj);
            return true;
        }

        public bool Delete(HangSX obj)
        {
            _hSX.Delete(obj);
            return true;
        }

        public List<HangSX> GetAll()
        {
            return _hSX.GetAll();
        }

        public bool Update(HangSX obj)
        {
            _hSX.Update(obj);
            return true;
        }
    }
}
