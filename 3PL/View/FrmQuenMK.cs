using _1DAL.ConText;
using _1DAL.Models;
using _2BUS.IService;
using _2BUS.Service;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3PL.View
{
    public partial class FrmQuenMK : Form
    {
        INhanVienService _NV = new NhanVienService();
        public FrmQuenMK()
        {
            InitializeComponent();
           
        }

        public void Loadmk()
        {
            var mk = _NV.GetAll();
          
            if(txt_nhap_sdt.Text != "")
            {
                mk = mk.Where(p => p.SDT.Contains(txt_nhap_sdt.Text)).ToList();
            }
            foreach(var item in mk)
            {
                dtg_showmk.Rows.Add(item.matKhau);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var userName = txt_nhap_sdt.Text;
            var sdt = _NV.GetAll();
           var mk = _NV.GetAll().FirstOrDefault(p=>p.SDT == txt_nhap_sdt.Text);
            if(txt_nhap_sdt.Text == "")
            {
                MessageBox.Show("SĐT không được để trống");
            }
            else if (cb_nguoimay.Checked == false)
            {
                MessageBox.Show("Bạn là người máy ư");
            }
            else if( mk == null)
            {
                MessageBox.Show("Tai Khoan Sai");
            }
            else
            {
                dtg_showmk.Visible = true;
                Loadmk();
                
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
