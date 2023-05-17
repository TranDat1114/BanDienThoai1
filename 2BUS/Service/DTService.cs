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
    public class DTService : IDTService
    {
        IDTRepos _iDT = new DTRepos();

        public bool Add(DienThoai obj)
        {
            _iDT.Add(obj);
            return true;
        }

        public bool Delete(DienThoai obj)
        {
            _iDT.Delete(obj);
            return true;
        }

        public List<DienThoai> GetAll()
        {
            return _iDT.GetAll();
        }

        public bool Update(DienThoai obj)
        {
            _iDT.Update(obj);
            return true;
        }
    }
}
