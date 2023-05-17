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
    public partial class FrmHoaDon : Form
    {
        private IHoaDonService _order;
        private IHoaDonCTService_ _orderDetail;
        private IDTCTService _product;
        public int oID;
        public FrmHoaDon()
        {
            InitializeComponent();
            _order = new HoaDonService();
            _orderDetail = new HoaDonCTService();
            _product = new DTCTService();
            oID = 0;
            LoadHoaDon();
        }

        public void LoadHoaDon()
        {
            dtg_hoadon.Rows.Clear();
            dtg_hoadonchitiet.Rows.Clear();
            var order = _order.GetAllViewView();
            if(tbt_timk.Text != "")
            {
                order = order.Where(p => p.EmployeeEmail.ToLower().Contains(tbt_timk.Text.ToLower()) || p.Status.ToString().ToLower().Contains(tbt_timk.Text.ToLower())).ToList();
            }
            foreach (var item in order)
            {
                dtg_hoadon.Rows.Add(item.ID, item.DateCreated, item.EmployeeEmail, item.CustomerPhoneNumber == "0" ? "Khách vãng lai" : item.CustomerPhoneNumber , item.TotalPrice, item.Status ==1 ? "Đã thanh toán" : "Chờ thanh toán", item.Note);
            }
        }
        public void loadOrderDetail(int orderID)
        {
            oID = orderID;
            dtg_hoadonchitiet.Rows.Clear();
            foreach (var item in _orderDetail.GetAllViewView(orderID))
            {
                dtg_hoadonchitiet.Rows.Add( item.MaSP,
                     item.tendienthoai,
                    item.Soluong, 
                    item.DonGia);
            }
        }

        private void btn_timk_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dtg_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_hoadon.Rows[e.RowIndex];
                loadOrderDetail(Convert.ToInt32(r.Cells[0].Value));
            }
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            if (oID == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
            else
            {
                HoaDon o = _order.GetAll().FirstOrDefault(x => x.MaHD == oID);
                if (o.TrangThai == 1)
                {
                    MessageBox.Show("Chỉ được xóa các hóa đơn chưa thanh toán");
                }
                else
                {
                    var _lstOd = _orderDetail.GetAll().Where(x => x.MaHD == oID);
                    foreach (var item in _lstOd)
                    {
                        var p = _product.GetAll().FirstOrDefault(x => x.MaDTCT == item.MaDTCT);
                        p.SoLuong += item.SoLuong;
                        _product.Update(p);
                        _orderDetail.Delete(item);
                    }
                    _order.Delete(o);
                    oID = 0;
                    MessageBox.Show("Xóa thành công");
                    LoadHoaDon();
                    dtg_hoadonchitiet.Rows.Clear();
                }
            }
        }

        private void tbt_timk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
