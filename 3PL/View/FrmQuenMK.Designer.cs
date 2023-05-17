namespace _3PL.View
{
    partial class FrmQuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuenMK));
            this.button2 = new System.Windows.Forms.Button();
            this.txt_nhap_sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_nguoimay = new System.Windows.Forms.CheckBox();
            this.dtg_showmk = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showmk)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 448);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Lấy lại mật khẩu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_nhap_sdt
            // 
            this.txt_nhap_sdt.Location = new System.Drawing.Point(158, 268);
            this.txt_nhap_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nhap_sdt.Multiline = true;
            this.txt_nhap_sdt.Name = "txt_nhap_sdt";
            this.txt_nhap_sdt.Size = new System.Drawing.Size(330, 32);
            this.txt_nhap_sdt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhập SĐT:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cb_nguoimay
            // 
            this.cb_nguoimay.AutoSize = true;
            this.cb_nguoimay.Location = new System.Drawing.Point(81, 324);
            this.cb_nguoimay.Name = "cb_nguoimay";
            this.cb_nguoimay.Size = new System.Drawing.Size(140, 23);
            this.cb_nguoimay.TabIndex = 20;
            this.cb_nguoimay.Text = "Bạn là người máy?";
            this.cb_nguoimay.UseVisualStyleBackColor = true;
            this.cb_nguoimay.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtg_showmk
            // 
            this.dtg_showmk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_showmk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showmk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtg_showmk.Location = new System.Drawing.Point(204, 353);
            this.dtg_showmk.Name = "dtg_showmk";
            this.dtg_showmk.RowTemplate.Height = 28;
            this.dtg_showmk.Size = new System.Drawing.Size(240, 54);
            this.dtg_showmk.TabIndex = 22;
            this.dtg_showmk.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mật Khẩu Của Bạn Là:";
            this.Column1.Name = "Column1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Image = global::_3PL.Properties.Resources.icon_left_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 39);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(698, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtg_showmk);
            this.Controls.Add(this.cb_nguoimay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_nhap_sdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQuenMK";
            this.Text = "FrmQuenMK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showmk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private TextBox txt_nhap_sdt;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox cb_nguoimay;
        private DataGridView dtg_showmk;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
    }
}