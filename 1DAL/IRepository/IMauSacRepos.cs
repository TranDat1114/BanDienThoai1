using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
namespace _1DAL.IRepository
{
    public interface IMauSacRepos
    {
        bool Add(MauSac mauSac);
        bool Update(MauSac mauSac);
        bool Delete(MauSac mauSac);
        List<MauSac> GetAll();
    }
}
