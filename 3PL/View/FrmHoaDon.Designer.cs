namespace _3PL.View
{
    partial class FrmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            groupBox2 = new GroupBox();
            dtg_hoadonchitiet = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn_XoaHD = new Button();
            btn_timk = new Button();
            dtg_hoadon = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tbt_timk = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadonchitiet).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadon).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_hoadonchitiet);
            groupBox2.Location = new Point(36, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1044, 271);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // dtg_hoadonchitiet
            // 
            dtg_hoadonchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_hoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoadonchitiet.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10, Column11 });
            dtg_hoadonchitiet.Location = new Point(13, 33);
            dtg_hoadonchitiet.Name = "dtg_hoadonchitiet";
            dtg_hoadonchitiet.RowHeadersWidth = 51;
            dtg_hoadonchitiet.RowTemplate.Height = 25;
            dtg_hoadonchitiet.Size = new Size(536, 232);
            dtg_hoadonchitiet.TabIndex = 4;
            // 
            // Column8
            // 
            Column8.HeaderText = "Mã Sản Phẩm";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Mã QR Sản Phẩm";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Số Lượng";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Đơn Giá";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_XoaHD);
            groupBox1.Controls.Add(btn_timk);
            groupBox1.Controls.Add(dtg_hoadon);
            groupBox1.Controls.Add(tbt_timk);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1044, 339);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // btn_XoaHD
            // 
            btn_XoaHD.BackColor = Color.FromArgb(128, 255, 255);
            btn_XoaHD.Image = (Image)resources.GetObject("btn_XoaHD.Image");
            btn_XoaHD.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XoaHD.Location = new Point(890, 26);
            btn_XoaHD.Name = "btn_XoaHD";
            btn_XoaHD.Size = new Size(149, 43);
            btn_XoaHD.TabIndex = 15;
            btn_XoaHD.Text = "Xóa hoá đơn";
            btn_XoaHD.UseVisualStyleBackColor = false;
            btn_XoaHD.Click += btn_XoaHD_Click;
            // 
            // btn_timk
            // 
            btn_timk.BackColor = Color.FromArgb(128, 255, 255);
            btn_timk.Image = (Image)resources.GetObject("btn_timk.Image");
            btn_timk.ImageAlign = ContentAlignment.MiddleLeft;
            btn_timk.Location = new Point(339, 26);
            btn_timk.Name = "btn_timk";
            btn_timk.Size = new Size(85, 23);
            btn_timk.TabIndex = 3;
            btn_timk.Text = "Tìm kiếm";
            btn_timk.TextAlign = ContentAlignment.MiddleRight;
            btn_timk.UseVisualStyleBackColor = false;
            btn_timk.Click += btn_timk_Click;
            // 
            // dtg_hoadon
            // 
            dtg_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoadon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dtg_hoadon.Location = new Point(7, 85);
            dtg_hoadon.Name = "dtg_hoadon";
            dtg_hoadon.RowHeadersWidth = 51;
            dtg_hoadon.RowTemplate.Height = 25;
            dtg_hoadon.Size = new Size(1032, 248);
            dtg_hoadon.TabIndex = 2;
            dtg_hoadon.CellClick += dtg_hoadon_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Hóa Đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngày Tạo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên Nhân Viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số Điện Thoại Khách Hàng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Tổng Giá";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Trạng Thái";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Ghi Chú";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // tbt_timk
            // 
            tbt_timk.Location = new Point(135, 26);
            tbt_timk.Name = "tbt_timk";
            tbt_timk.Size = new Size(190, 23);
            tbt_timk.TabIndex = 1;
            tbt_timk.TextChanged += tbt_timk_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm hóa đơn";
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1116, 627);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHoaDon";
            Text = "FrmHoaDon";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_hoadonchitiet).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dtg_hoadonchitiet;
        private GroupBox groupBox1;
        private Button btn_XoaHD;
        private Button btn_timk;
        private DataGridView dtg_hoadon;
        private TextBox tbt_timk;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}