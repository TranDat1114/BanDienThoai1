using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IChucVuRepos
    {
        bool Add(ChucVu chucVu);
        bool Update(ChucVu chucVu);
        bool Delete(ChucVu chucVu);
        List<ChucVu> GetAll();
    }
}
