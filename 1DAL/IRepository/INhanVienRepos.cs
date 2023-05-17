using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface INhanVienRepos
    {
        bool Add(NhanVien nhanVien);
        bool Update(NhanVien nhanVien);
        bool Delete(NhanVien nhanVien);
        List<NhanVien> GetAll();
    }
}
