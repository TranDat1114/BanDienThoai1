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
    public partial class FrmQuanLySP : Form
    {
        FrmDienThoaiCT frmDienThoaiCT;
        FrmDienThoai dt;
        FrmImei im;
        FrmHSX hsx;
        FrmDungLuong dl;
        FrmMauSac ms;
        public FrmQuanLySP(FrmDienThoaiCT frmDienThoai, FrmDienThoai frmDienThoai1, FrmImei frmImei, FrmHSX hsx, FrmDungLuong frmDungLuong, FrmMauSac frmMauSac)
        {
            InitializeComponent();
            dt = frmDienThoai1;
            im = frmImei;
            this.frmDienThoaiCT = frmDienThoai;
            ChangeForm(this.frmDienThoaiCT);
            this.hsx = hsx;
            this.dl = frmDungLuong;
            this.ms = frmMauSac;
        }
        private Form activeForm;
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void ChangeForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            pn_QLSP.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(frmDienThoaiCT);
        }

        private void pn_QLSP_Load(object sender, EventArgs e)
        {

        }

        private void điệnThoạiChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(dt);
        }

        private void imeiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(im);
        }
        //vailoz???
        private void hãngSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            ChangeForm(hsx);
        }

        private void dungLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ChangeForm(dl);
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(ms);
        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
