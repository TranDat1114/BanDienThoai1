using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BUS.ViewModel
{
    public class HoaDonViewView
    {
        public int ID { get; set; }
        public int MaSP { get; set; }
        public DateTime DateCreated { get; set; }
        public string EmployeeEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public int Status { get; set; }
        public string? Note { get; set; }
    }
}
