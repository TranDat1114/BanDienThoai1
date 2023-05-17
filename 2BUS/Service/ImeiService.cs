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
    public class IMeiService : IImeiService
    {
        IImeiRepos _iDT = new ImeiRepos();

        public bool Add(Imei obj)
        {
            _iDT.Add(obj);
            return true;
        }

        public bool Delete(Imei obj)
        {
            _iDT.Delete(obj);
            return true;
        }

        public List<Imei> GetAll()
        {
            return _iDT.GetAll();
        }

        public bool Update(Imei obj)
        {
            _iDT.Update(obj);
            return true;
        }
    }
}
