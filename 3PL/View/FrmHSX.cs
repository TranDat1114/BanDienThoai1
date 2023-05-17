using _1DAL.Models;
using _2BUS.IService;
using _2BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3PL.View
{
    public partial class FrmHSX : Form
    {
        private IHSXService _IHSX = new HSXService();
        public HangSX _HSX = new HangSX();
        public FrmHSX()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dtgv_HSX.ColumnCount = 4;
            dtgv_HSX.Columns[0].Name = "ID";
            dtgv_HSX.Columns[0].Visible = false;
            dtgv_HSX.Columns[1].Name = "STT";
            dtgv_HSX.Columns[2].Name = "Tên Hãng Sản Xuất";
            dtgv_HSX.Columns[3].Name = "Trạng Thái";
            dtgv_HSX.Rows.Clear();
            foreach (var x in _IHSX.GetAll())
            {
                dtgv_HSX.Rows.Add(x.MaHang,stt++, x.TenHang, x.TrangThai ==1? "HSX còn hoạt động":"HSX ngừng hoạt động");
            }
        }

        private void dtgv_HSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_HSX.Rows[e.RowIndex];
                _HSX = _IHSX.GetAll().FirstOrDefault(x => x.MaHang == int.Parse(r.Cells[0].Value.ToString()));
                tbt_TenHSX.Text = r.Cells[2].Value.ToString();
                rb_HoatDong.Checked = r.Cells[3].Value.ToString() == "HSX còn hoạt động"? true:false;
                rb_KHD.Checked = r.Cells[3].Value.ToString() == "HSX ngừng hoạt động" ? true : false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var Hang = _IHSX.GetAll().FirstOrDefault(p => p.TenHang == tbt_TenHSX.Text);
            if (tbt_TenHSX.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else if( rb_HoatDong.Checked == false && rb_KHD.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn trạng thái");
            }
            else if (tbt_TenHSX.TextLength > 100)
            {
                MessageBox.Show("Tên hãng không được quá 100 ký tự");
            }
            else if(Hang != null)
            {
                MessageBox.Show("Tên hãng đã tồn tại");
            }
            else
            {
                HangSX addhsx = new HangSX()
                {
                    TenHang = tbt_TenHSX.Text,
                    TrangThai = rb_HoatDong.Checked ? 1 : 0,
                };
                _IHSX.Add(addhsx);
                MessageBox.Show("Thêm hãng thành công");
                LoadData();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_HSX == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else if (rb_HoatDong.Checked != true && rb_KHD.Checked != true)
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else
            {
                if (_HSX.TenHang == tbt_TenHSX.Text || (_HSX.TenHang != tbt_TenHSX.Text && _IHSX.GetAll().FirstOrDefault(x => x.TenHang == tbt_TenHSX.Text) == null))
                {
                    _HSX.TenHang = tbt_TenHSX.Text;
                    _HSX.TrangThai = rb_HoatDong.Checked ? 1 : 0;
                    _IHSX.Update(_HSX);
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                   
                }
                else
                {
                    MessageBox.Show("Tên màu sắc đã tồn tại");
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            _HSX = null;
            LoadData();
            tbt_TenHSX.Text = "";
        }
    }
}
