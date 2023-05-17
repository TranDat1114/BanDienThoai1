using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1DAL.Models;
using _2BUS.IService;
using _2BUS.Service;
namespace _3PL.View
{
    public partial class FrmMauSac : Form
    {
        private IMauSacService _MSSV = new MauSacService();
        public MauSac _MS;
        public FrmMauSac()
        { 
            InitializeComponent();
            LoadToData();
        }
        public void LoadToData()
        {
            dtgv_Mau.Rows.Clear();
            foreach (var item in _MSSV.GetAll())
            {
                dtgv_Mau.Rows.Add(item.MaMau, item.TenMau,
                    item.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }
        private void dtgv_Mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_Mau.Rows[e.RowIndex];
                _MS = _MSSV.GetAll().FirstOrDefault(x => x.MaMau == Convert.ToInt32(row.Cells[0].Value));
                tbt_TenMau.Text = row.Cells[1].Value.ToString();
                rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rb_KHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MauSac accMau = _MSSV.GetAll().FirstOrDefault
            (p => p.TenMau == tbt_TenMau.Text);
            if (tbt_TenMau.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if(rb_HoatDong.Checked == false && rb_KHD.Checked == false) 
            {
                MessageBox.Show("Bạn phải chọn trạng thái");
            }
            else if(tbt_TenMau.Text.Length >= 50)
            {
                MessageBox.Show("Nhập quá Ký tự cho phép vui lòng nhập lại");
            }
            else if (accMau != null)
            {
                MessageBox.Show("Tên màu đã tồn tại");
            }
            else
            {
                MauSac addMau = new MauSac()
                {
                    TenMau = tbt_TenMau.Text,
                    TrangThai = rb_HoatDong.Checked ?1 :0,
                };
                _MSSV.Add(addMau);
                MessageBox.Show("Thêm màu sắc thành công");
                LoadToData();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_MS == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else if(rb_HoatDong.Checked != true && rb_KHD.Checked != true)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                if (_MS.TenMau == tbt_TenMau.Text || (_MS.TenMau != tbt_TenMau.Text && _MSSV.GetAll().FirstOrDefault(x => x.TenMau == tbt_TenMau.Text) == null))
                {
                    _MS.TenMau = tbt_TenMau.Text;
                    _MS.TrangThai = rb_HoatDong.Checked ?1 :0;
                    _MSSV.Update(_MS);
                    MessageBox.Show("Cập nhật thành công");
                    LoadToData();
                    
                }
                else
                {
                    MessageBox.Show("Tên màu sắc đã tồn tại");
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            _MS = null;
            LoadToData();
            tbt_TenMau.Text = "";
            rb_HoatDong.Checked = false;
            rb_KHD.Checked = false;
        }
    }
}
