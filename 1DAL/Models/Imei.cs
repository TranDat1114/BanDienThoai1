using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DAL.Models
{
    public class Imei
    {
        public int MaImei { get; set; }
        public string TenImei { get; set; }
        public bool TrangThai { get; set; }
        public virtual List<DienThoaiCT> DienThoaiCTs { get; set; }
    }
}
