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
    public partial class FrmDungLuong : Form
    {
        private IDungLuongService _IDL = new DungLuongService();
        public DungLuong _DL = new DungLuong();
        public FrmDungLuong()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_DL.ColumnCount = 4;
            dtg_DL.Columns[0].Name  = "ID";
            dtg_DL.Columns[0].Visible= false;
            dtg_DL.Columns[1].Name = "STT";
            dtg_DL.Columns[2].Name = "Số Dung Lượng";
            dtg_DL.Columns[3].Name = "Trạng Thái";
            dtg_DL.Rows.Clear();
            foreach (var x in _IDL.GetAll())
            {
                dtg_DL.Rows.Add(x.MaDungLuong,stt++, x.SoDungLuong, x.TrangThai ==1?"Còn dung lượng":"Hết dung lượng");
            }
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            _DL = null;
            tbt_SDL.Text = "";
            rb_HoatDong.Checked = false;
            rb_KHD.Checked= false;
        }

        private void dtg_DL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_DL.Rows[e.RowIndex];
                _DL = _IDL.GetAll().FirstOrDefault(x => x.MaDungLuong == int.Parse(r.Cells[0].Value.ToString()));
                tbt_SDL.Text = r.Cells[2].Value.ToString();
                rb_HoatDong.Checked = r.Cells[3].Value.ToString() == "Còn dung lượng"? true : false;
                rb_KHD.Checked = r.Cells[3].Value.ToString() =="Hết dung lượng"? true : false;
            }
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            DungLuong dl = _IDL.GetAll().FirstOrDefault
           (p => p.SoDungLuong == tbt_SDL.Text);
            if (tbt_SDL.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else if (rb_HoatDong.Checked == false && rb_KHD.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn trạng thái");
            }
            else if(tbt_SDL.TextLength > 50)
            {
                MessageBox.Show("Số dung lượng không được quá 50 ký tự");
            }
            else if (dl != null)
            {
                MessageBox.Show("Dung lượng đã tồn tại");
            }
            else
            {
                DungLuong adddl = new DungLuong()
                {
                    SoDungLuong = tbt_SDL.Text,
                    TrangThai = rb_HoatDong.Checked ? 1 : 0,
                };
                _IDL.Add(adddl);
                MessageBox.Show("Thêm dung lượng thành công");
                LoadData();
            }
        }

        private void btb_CapNhat_Click(object sender, EventArgs e)
        {
            if (_DL == null)
            {
                MessageBox.Show("Vui lòng chọn dung lượng");
            }
            else if (rb_HoatDong.Checked != true && rb_KHD.Checked != true)
            {
                MessageBox.Show("Vui lòng chọn dung lượng");
            }
            else
            {
                if (_DL.SoDungLuong == tbt_SDL.Text || (_DL.SoDungLuong != tbt_SDL.Text && _IDL.GetAll().FirstOrDefault(x => x.SoDungLuong == tbt_SDL.Text) == null))
                {
                    _DL.SoDungLuong = tbt_SDL.Text;
                    _DL.TrangThai = rb_HoatDong.Checked ? 1 : 0;
                    _IDL.Update(_DL);
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                    
                }
                else
                {
                    MessageBox.Show("Số dung lượng đã tồn tại");
                }
            }
        }
    }
}
