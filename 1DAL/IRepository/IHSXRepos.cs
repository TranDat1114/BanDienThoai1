using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;


namespace _1DAL.IRepository
{
    public interface IHSXRepos
    {
        bool Add(HangSX hangSX);
        bool Update(HangSX hangSX);
        bool Delete(HangSX hangSX);
        List<HangSX> GetAll();
    }
}
