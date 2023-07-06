namespace PhanMemQuanLyKhachSan1
{
    partial class frm_QuanLyVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyVatTu));
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.txt_NguoiQuanLy = new System.Windows.Forms.TextBox();
            this.lbl_NguoiQuanLy = new System.Windows.Forms.Label();
            this.txt_NhaCungCap = new System.Windows.Forms.TextBox();
            this.lbl_NhaCungCap = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.txt_TenVatTu = new System.Windows.Forms.TextBox();
            this.lbl_TenVatTu = new System.Windows.Forms.Label();
            this.txt_MaVatTu = new System.Windows.Forms.TextBox();
            this.lbl_MaVatTu = new System.Windows.Forms.Label();
            this.lbl_ThongTinVatTu = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.lbl_TimKiemMaVatTu = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Thoat.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.logout;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(977, 677);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(110, 41);
            this.btn_Thoat.TabIndex = 91;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(861, 677);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(110, 41);
            this.btn_Xoa.TabIndex = 89;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.wrench;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(745, 677);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(110, 41);
            this.btn_Sua.TabIndex = 88;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.button;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(629, 677);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(110, 41);
            this.btn_Them.TabIndex = 87;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVatTu,
            this.TenVatTu,
            this.DonGia,
            this.NhaCungCap,
            this.NguoiQuanLy,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(11, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 361);
            this.dataGridView1.TabIndex = 92;
            // 
            // MaVatTu
            // 
            this.MaVatTu.HeaderText = "Mã vật tư";
            this.MaVatTu.MinimumWidth = 6;
            this.MaVatTu.Name = "MaVatTu";
            // 
            // TenVatTu
            // 
            this.TenVatTu.HeaderText = "Tên vật tư";
            this.TenVatTu.MinimumWidth = 6;
            this.TenVatTu.Name = "TenVatTu";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.HeaderText = "Nhà cung cấp";
            this.NhaCungCap.MinimumWidth = 6;
            this.NhaCungCap.Name = "NhaCungCap";
            // 
            // NguoiQuanLy
            // 
            this.NguoiQuanLy.HeaderText = "Người quản lý";
            this.NguoiQuanLy.MinimumWidth = 6;
            this.NguoiQuanLy.Name = "NguoiQuanLy";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú / Bổ sung";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(751, 102);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(336, 98);
            this.txt_GhiChu.TabIndex = 105;
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_GhiChu.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GhiChu.ForeColor = System.Drawing.Color.Blue;
            this.lbl_GhiChu.Location = new System.Drawing.Point(605, 102);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(78, 24);
            this.lbl_GhiChu.TabIndex = 104;
            this.lbl_GhiChu.Text = "Ghi Chú:";
            // 
            // txt_NguoiQuanLy
            // 
            this.txt_NguoiQuanLy.Location = new System.Drawing.Point(750, 65);
            this.txt_NguoiQuanLy.Name = "txt_NguoiQuanLy";
            this.txt_NguoiQuanLy.Size = new System.Drawing.Size(336, 22);
            this.txt_NguoiQuanLy.TabIndex = 103;
            // 
            // lbl_NguoiQuanLy
            // 
            this.lbl_NguoiQuanLy.AutoSize = true;
            this.lbl_NguoiQuanLy.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NguoiQuanLy.ForeColor = System.Drawing.Color.Blue;
            this.lbl_NguoiQuanLy.Location = new System.Drawing.Point(605, 65);
            this.lbl_NguoiQuanLy.Name = "lbl_NguoiQuanLy";
            this.lbl_NguoiQuanLy.Size = new System.Drawing.Size(126, 24);
            this.lbl_NguoiQuanLy.TabIndex = 102;
            this.lbl_NguoiQuanLy.Text = "Người quản lý:";
            // 
            // txt_NhaCungCap
            // 
            this.txt_NhaCungCap.Location = new System.Drawing.Point(189, 176);
            this.txt_NhaCungCap.Name = "txt_NhaCungCap";
            this.txt_NhaCungCap.Size = new System.Drawing.Size(336, 22);
            this.txt_NhaCungCap.TabIndex = 101;
            // 
            // lbl_NhaCungCap
            // 
            this.lbl_NhaCungCap.AutoSize = true;
            this.lbl_NhaCungCap.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_NhaCungCap.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhaCungCap.ForeColor = System.Drawing.Color.Blue;
            this.lbl_NhaCungCap.Location = new System.Drawing.Point(42, 176);
            this.lbl_NhaCungCap.Name = "lbl_NhaCungCap";
            this.lbl_NhaCungCap.Size = new System.Drawing.Size(125, 24);
            this.lbl_NhaCungCap.TabIndex = 100;
            this.lbl_NhaCungCap.Text = "Nhà cung cấp:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(188, 139);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(336, 22);
            this.txt_DonGia.TabIndex = 99;
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.ForeColor = System.Drawing.Color.Blue;
            this.lbl_DonGia.Location = new System.Drawing.Point(42, 139);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(77, 24);
            this.lbl_DonGia.TabIndex = 98;
            this.lbl_DonGia.Text = "Đơn giá:";
            // 
            // txt_TenVatTu
            // 
            this.txt_TenVatTu.Location = new System.Drawing.Point(188, 102);
            this.txt_TenVatTu.Name = "txt_TenVatTu";
            this.txt_TenVatTu.Size = new System.Drawing.Size(336, 22);
            this.txt_TenVatTu.TabIndex = 97;
            // 
            // lbl_TenVatTu
            // 
            this.lbl_TenVatTu.AutoSize = true;
            this.lbl_TenVatTu.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TenVatTu.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenVatTu.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TenVatTu.Location = new System.Drawing.Point(42, 102);
            this.lbl_TenVatTu.Name = "lbl_TenVatTu";
            this.lbl_TenVatTu.Size = new System.Drawing.Size(95, 24);
            this.lbl_TenVatTu.TabIndex = 96;
            this.lbl_TenVatTu.Text = "Tên vật tư:";
            // 
            // txt_MaVatTu
            // 
            this.txt_MaVatTu.Location = new System.Drawing.Point(187, 65);
            this.txt_MaVatTu.Name = "txt_MaVatTu";
            this.txt_MaVatTu.Size = new System.Drawing.Size(336, 22);
            this.txt_MaVatTu.TabIndex = 95;
            // 
            // lbl_MaVatTu
            // 
            this.lbl_MaVatTu.AutoSize = true;
            this.lbl_MaVatTu.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaVatTu.ForeColor = System.Drawing.Color.Blue;
            this.lbl_MaVatTu.Location = new System.Drawing.Point(42, 65);
            this.lbl_MaVatTu.Name = "lbl_MaVatTu";
            this.lbl_MaVatTu.Size = new System.Drawing.Size(92, 24);
            this.lbl_MaVatTu.TabIndex = 94;
            this.lbl_MaVatTu.Text = "Mã vật tư:";
            // 
            // lbl_ThongTinVatTu
            // 
            this.lbl_ThongTinVatTu.AutoSize = true;
            this.lbl_ThongTinVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTinVatTu.Location = new System.Drawing.Point(397, 9);
            this.lbl_ThongTinVatTu.Name = "lbl_ThongTinVatTu";
            this.lbl_ThongTinVatTu.Size = new System.Drawing.Size(340, 38);
            this.lbl_ThongTinVatTu.TabIndex = 93;
            this.lbl_ThongTinVatTu.Text = "THÔNG TIN VẬT TƯ";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.Location = new System.Drawing.Point(785, 211);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(129, 31);
            this.btn_TimKiem.TabIndex = 108;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemNhanVien
            // 
            this.txt_TimKiemNhanVien.Location = new System.Drawing.Point(428, 215);
            this.txt_TimKiemNhanVien.Name = "txt_TimKiemNhanVien";
            this.txt_TimKiemNhanVien.Size = new System.Drawing.Size(351, 22);
            this.txt_TimKiemNhanVien.TabIndex = 107;
            // 
            // lbl_TimKiemMaVatTu
            // 
            this.lbl_TimKiemMaVatTu.AutoSize = true;
            this.lbl_TimKiemMaVatTu.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiemMaVatTu.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TimKiemMaVatTu.Location = new System.Drawing.Point(208, 215);
            this.lbl_TimKiemMaVatTu.Name = "lbl_TimKiemMaVatTu";
            this.lbl_TimKiemMaVatTu.Size = new System.Drawing.Size(170, 24);
            this.lbl_TimKiemMaVatTu.TabIndex = 106;
            this.lbl_TimKiemMaVatTu.Text = "Tìm kiếm mã vật tư:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 721);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 26);
            this.statusStrip1.TabIndex = 109;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel1.Text = "A$AP";
            // 
            // frm_QuanLyVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 747);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiemNhanVien);
            this.Controls.Add(this.lbl_TimKiemMaVatTu);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.lbl_GhiChu);
            this.Controls.Add(this.txt_NguoiQuanLy);
            this.Controls.Add(this.lbl_NguoiQuanLy);
            this.Controls.Add(this.txt_NhaCungCap);
            this.Controls.Add(this.lbl_NhaCungCap);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.txt_TenVatTu);
            this.Controls.Add(this.lbl_TenVatTu);
            this.Controls.Add(this.txt_MaVatTu);
            this.Controls.Add(this.lbl_MaVatTu);
            this.Controls.Add(this.lbl_ThongTinVatTu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuanLyVatTu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý vật tư";
            this.Load += new System.EventHandler(this.frm_QuanLyVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label lbl_GhiChu;
        private System.Windows.Forms.TextBox txt_NguoiQuanLy;
        private System.Windows.Forms.Label lbl_NguoiQuanLy;
        private System.Windows.Forms.TextBox txt_NhaCungCap;
        private System.Windows.Forms.Label lbl_NhaCungCap;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.TextBox txt_TenVatTu;
        private System.Windows.Forms.Label lbl_TenVatTu;
        private System.Windows.Forms.TextBox txt_MaVatTu;
        private System.Windows.Forms.Label lbl_MaVatTu;
        private System.Windows.Forms.Label lbl_ThongTinVatTu;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiemNhanVien;
        private System.Windows.Forms.Label lbl_TimKiemMaVatTu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}