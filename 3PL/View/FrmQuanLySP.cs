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
        public FrmQuanLySP()
        {
            InitializeComponent();
            FrmDienThoaiCT frmChiTietSP = new FrmDienThoaiCT();
            ChangeForm(frmChiTietSP);
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
            FrmDienThoaiCT dtct = new FrmDienThoaiCT();
            ChangeForm(dtct);
        }

        private void pn_QLSP_Load(object sender, EventArgs e)
        {

        }

        private void điệnThoạiChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDienThoai dt = new FrmDienThoai();
            ChangeForm(dt);
        }

        private void imeiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImei im = new FrmImei();
            ChangeForm(im);
        }

        private void hãngSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHSX hsx = new FrmHSX();
            ChangeForm(hsx);
        }

        private void dungLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDungLuong dl = new FrmDungLuong();
            ChangeForm(dl);
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMauSac ms = new FrmMauSac();
            ChangeForm(ms);
        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
