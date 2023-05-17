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
    public partial class FrmDienThoai : Form
    {
        private IDTService _DTSV = new DTService();
        public DienThoai _DT;
        public FrmDienThoai()
        {
            InitializeComponent();
            LoadTodata();
        }

        public void LoadTodata()
        {
            dtgv_DT.Rows.Clear();
            foreach (var item in _DTSV.GetAll())
            {
                dtgv_DT.Rows.Add(item.MaDT, item.TenDT,
                    item.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }
        private void dtgv_DT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_DT.Rows[e.RowIndex];
                _DT = _DTSV.GetAll().FirstOrDefault(x => x.MaDT == Convert.ToInt32(row.Cells[0].Value));
                tbt_TenDT.Text = row.Cells[1].Value.ToString();
                rb_HoatDong.Checked = row.Cells[2].Value.ToString() == "Còn hàng" ? true : false;
                rb_KHD.Checked = row.Cells[2].Value.ToString() == "Hết hàng" ? true : false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DienThoai accDT = _DTSV.GetAll().FirstOrDefault
           (p => p.TenDT == tbt_TenDT.Text);
            if (tbt_TenDT.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if(rb_HoatDong.Checked != true && rb_KHD.Checked != true)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else if (tbt_TenDT.Text.Length >= 50)
            {
                MessageBox.Show("Nhập quá Ký tự cho phép vui lòng nhập lại");
            }
            else if (accDT != null)
            {
                MessageBox.Show("Tên điện thoại đã tồn tại");
            }
            else
            {
                DienThoai DT = new DienThoai()
                {
                    TenDT = tbt_TenDT.Text,
                    TrangThai = rb_HoatDong.Checked ? 1 : 0,
                };
                _DTSV.Add(DT);
                MessageBox.Show("Thêm Điện Thoại thành công");
                LoadTodata();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_DT == null)
            {
                MessageBox.Show("Vui lòng chọn Điện Thoại");
            }
            else if(tbt_TenDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Điện thoại");
            }
            else
            {
                if (_DT.TenDT == tbt_TenDT.Text || (_DT.TenDT != tbt_TenDT.Text && _DTSV.GetAll().FirstOrDefault(x => x.TenDT == tbt_TenDT.Text) == null))
                {
                    _DT.TenDT = tbt_TenDT.Text;
                    _DT.TrangThai = rb_HoatDong.Checked ? 1 : 0;
                    _DTSV.Update(_DT);
                    MessageBox.Show("Cập nhật thành công");
                    LoadTodata();
                }
                else
                {
                    MessageBox.Show("Tên Điện Thoại đã tồn tại");
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            _DT = null;
            LoadTodata();
            tbt_TenDT.Text = "";
            rb_HoatDong.Checked = false;
            rb_KHD.Checked = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
