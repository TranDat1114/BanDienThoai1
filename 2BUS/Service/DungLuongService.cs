using _1DAL.Models;
using _2BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.IRepository;
using _1DAL.Repositorys;

namespace _2BUS.Service
{
    public class DungLuongService : IDungLuongService
    {
        IDungLuongRepos _dungLuong = new DungLuongRepos();
        public bool Add(DungLuong obj)
        {
            _dungLuong.Add(obj);
            return true;
        }

        public bool Delete(DungLuong obj)
        {
            _dungLuong.Delete(obj);
            return true;
        }

        public List<DungLuong> GetAll()
        {
            return _dungLuong.GetAll();
        }

        public bool Update(DungLuong obj)
        {
            _dungLuong.Update(obj);
            return true;
        }
    }
}
