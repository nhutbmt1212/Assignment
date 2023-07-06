namespace PhanMemQuanLyKhachSan1
{
    partial class frm_QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyNhanVien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.msk_NgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.chk_Nu = new System.Windows.Forms.CheckBox();
            this.chk_Nam = new System.Windows.Forms.CheckBox();
            this.msk_DienThoai = new System.Windows.Forms.MaskedTextBox();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_MaNhanVien = new System.Windows.Forms.Label();
            this.lbl_TieuDeQLNhanVien = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.GioiTinh,
            this.DiaChi,
            this.SoDienThoai,
            this.NgaySinh});
            this.dataGridView1.Location = new System.Drawing.Point(12, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 308);
            this.dataGridView1.TabIndex = 14;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.FillWeight = 73.09557F;
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.FillWeight = 85.96093F;
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // GioiTinh
            // 
            this.GioiTinh.FillWeight = 96.49546F;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.FillWeight = 106.4369F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.FillWeight = 115.2042F;
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // NgaySinh
            // 
            this.NgaySinh.FillWeight = 122.807F;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txt_TimKiemNhanVien);
            this.panel1.Controls.Add(this.lbl_TimKiem);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.txt_TenNhanVien);
            this.panel1.Controls.Add(this.txt_MaNhanVien);
            this.panel1.Controls.Add(this.msk_NgaySinh);
            this.panel1.Controls.Add(this.lbl_NgaySinh);
            this.panel1.Controls.Add(this.lbl_GioiTinh);
            this.panel1.Controls.Add(this.chk_Nu);
            this.panel1.Controls.Add(this.chk_Nam);
            this.panel1.Controls.Add(this.msk_DienThoai);
            this.panel1.Controls.Add(this.lbl_SoDienThoai);
            this.panel1.Controls.Add(this.lbl_DiaChi);
            this.panel1.Controls.Add(this.lbl_TenNhanVien);
            this.panel1.Controls.Add(this.lbl_MaNhanVien);
            this.panel1.Controls.Add(this.lbl_TieuDeQLNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 278);
            this.panel1.TabIndex = 20;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.Location = new System.Drawing.Point(807, 233);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(129, 31);
            this.btn_TimKiem.TabIndex = 67;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemNhanVien
            // 
            this.txt_TimKiemNhanVien.Location = new System.Drawing.Point(450, 237);
            this.txt_TimKiemNhanVien.Name = "txt_TimKiemNhanVien";
            this.txt_TimKiemNhanVien.Size = new System.Drawing.Size(351, 22);
            this.txt_TimKiemNhanVien.TabIndex = 66;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TimKiem.Location = new System.Drawing.Point(230, 237);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(201, 24);
            this.lbl_TimKiem.TabIndex = 65;
            this.lbl_TimKiem.Text = "Tìm kiếm mã nhân viên:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(832, 91);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(214, 22);
            this.txt_DiaChi.TabIndex = 27;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(307, 137);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(179, 22);
            this.txt_TenNhanVien.TabIndex = 26;
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(307, 91);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(179, 22);
            this.txt_MaNhanVien.TabIndex = 25;
            // 
            // msk_NgaySinh
            // 
            this.msk_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_NgaySinh.Location = new System.Drawing.Point(832, 181);
            this.msk_NgaySinh.Mask = "00/00/0000";
            this.msk_NgaySinh.Name = "msk_NgaySinh";
            this.msk_NgaySinh.Size = new System.Drawing.Size(214, 27);
            this.msk_NgaySinh.TabIndex = 24;
            this.msk_NgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(635, 181);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(133, 29);
            this.lbl_NgaySinh.TabIndex = 23;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.ForeColor = System.Drawing.Color.Blue;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(121, 181);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(113, 29);
            this.lbl_GioiTinh.TabIndex = 22;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // chk_Nu
            // 
            this.chk_Nu.AutoSize = true;
            this.chk_Nu.BackColor = System.Drawing.SystemColors.Control;
            this.chk_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Nu.ForeColor = System.Drawing.Color.Blue;
            this.chk_Nu.Location = new System.Drawing.Point(419, 181);
            this.chk_Nu.Name = "chk_Nu";
            this.chk_Nu.Size = new System.Drawing.Size(59, 29);
            this.chk_Nu.TabIndex = 21;
            this.chk_Nu.Text = "Nữ";
            this.chk_Nu.UseVisualStyleBackColor = false;
            // 
            // chk_Nam
            // 
            this.chk_Nam.AutoSize = true;
            this.chk_Nam.BackColor = System.Drawing.SystemColors.Control;
            this.chk_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Nam.ForeColor = System.Drawing.Color.Blue;
            this.chk_Nam.Location = new System.Drawing.Point(299, 181);
            this.chk_Nam.Name = "chk_Nam";
            this.chk_Nam.Size = new System.Drawing.Size(75, 29);
            this.chk_Nam.TabIndex = 20;
            this.chk_Nam.Text = "Nam";
            this.chk_Nam.UseVisualStyleBackColor = false;
            // 
            // msk_DienThoai
            // 
            this.msk_DienThoai.Location = new System.Drawing.Point(832, 137);
            this.msk_DienThoai.Mask = "(999) 000-0000";
            this.msk_DienThoai.Name = "msk_DienThoai";
            this.msk_DienThoai.Size = new System.Drawing.Size(214, 22);
            this.msk_DienThoai.TabIndex = 19;
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.ForeColor = System.Drawing.Color.Blue;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(636, 136);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(168, 29);
            this.lbl_SoDienThoai.TabIndex = 18;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.ForeColor = System.Drawing.Color.Blue;
            this.lbl_DiaChi.Location = new System.Drawing.Point(635, 91);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(98, 29);
            this.lbl_DiaChi.TabIndex = 17;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(121, 136);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(180, 29);
            this.lbl_TenNhanVien.TabIndex = 16;
            this.lbl_TenNhanVien.Text = "Tên nhân viên:";
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.AutoSize = true;
            this.lbl_MaNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(121, 91);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(172, 29);
            this.lbl_MaNhanVien.TabIndex = 15;
            this.lbl_MaNhanVien.Text = "Mã nhân viên:";
            // 
            // lbl_TieuDeQLNhanVien
            // 
            this.lbl_TieuDeQLNhanVien.AutoSize = true;
            this.lbl_TieuDeQLNhanVien.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDeQLNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TieuDeQLNhanVien.Location = new System.Drawing.Point(439, 29);
            this.lbl_TieuDeQLNhanVien.Name = "lbl_TieuDeQLNhanVien";
            this.lbl_TieuDeQLNhanVien.Size = new System.Drawing.Size(289, 39);
            this.lbl_TieuDeQLNhanVien.TabIndex = 14;
            this.lbl_TieuDeQLNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1167, 26);
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel1.Text = "A$AP";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Thoat.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.logout;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(986, 613);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(110, 41);
            this.btn_Thoat.TabIndex = 47;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.floppy_disk;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(870, 613);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 46;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(638, 613);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(110, 41);
            this.btn_Xoa.TabIndex = 45;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.wrench;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(754, 613);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(110, 41);
            this.btn_Sua.TabIndex = 44;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.button;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(522, 613);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(110, 41);
            this.btn_Them.TabIndex = 43;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 688);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuanLyNhanVien";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.MaskedTextBox msk_NgaySinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.CheckBox chk_Nu;
        private System.Windows.Forms.CheckBox chk_Nam;
        private System.Windows.Forms.MaskedTextBox msk_DienThoai;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.Label lbl_MaNhanVien;
        private System.Windows.Forms.Label lbl_TieuDeQLNhanVien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiemNhanVien;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}