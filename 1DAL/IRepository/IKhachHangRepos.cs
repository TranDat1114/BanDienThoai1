using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IKhachHangRepos
    {
        bool Add(KhachHang KhachHang);
        bool Update(KhachHang KhachHang);
        bool Delete(KhachHang KhachHang);
        List<KhachHang> GetAll();
    }
}
