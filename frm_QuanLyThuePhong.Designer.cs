namespace PhanMemQuanLyKhachSan1
{
    partial class frm_QuanLyThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyThuePhong));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.chk_Nu = new System.Windows.Forms.CheckBox();
            this.chk_Nam = new System.Windows.Forms.CheckBox();
            this.lbl_TieuDeQLThuePhong = new System.Windows.Forms.Label();
            this.dtp_NgayDen = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_NgayDen = new System.Windows.Forms.Label();
            this.lbl_SoPhong = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_cmnd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbl_GioiTinh);
            this.panel2.Controls.Add(this.chk_Nu);
            this.panel2.Controls.Add(this.chk_Nam);
            this.panel2.Controls.Add(this.lbl_TieuDeQLThuePhong);
            this.panel2.Controls.Add(this.dtp_NgayDen);
            this.panel2.Controls.Add(this.txt_DiaChi);
            this.panel2.Controls.Add(this.txt_SoPhong);
            this.panel2.Controls.Add(this.txt_HoTen);
            this.panel2.Controls.Add(this.txt_cmnd);
            this.panel2.Controls.Add(this.lbl_DiaChi);
            this.panel2.Controls.Add(this.lbl_NgayDen);
            this.panel2.Controls.Add(this.lbl_SoPhong);
            this.panel2.Controls.Add(this.lbl_HoTen);
            this.panel2.Controls.Add(this.lbl_cmnd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 206);
            this.panel2.TabIndex = 36;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.ForeColor = System.Drawing.Color.Blue;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(35, 151);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(102, 30);
            this.lbl_GioiTinh.TabIndex = 40;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // chk_Nu
            // 
            this.chk_Nu.AutoSize = true;
            this.chk_Nu.BackColor = System.Drawing.SystemColors.Control;
            this.chk_Nu.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Nu.ForeColor = System.Drawing.Color.Blue;
            this.chk_Nu.Location = new System.Drawing.Point(313, 151);
            this.chk_Nu.Name = "chk_Nu";
            this.chk_Nu.Size = new System.Drawing.Size(64, 34);
            this.chk_Nu.TabIndex = 39;
            this.chk_Nu.Text = "Nữ";
            this.chk_Nu.UseVisualStyleBackColor = false;
            // 
            // chk_Nam
            // 
            this.chk_Nam.AutoSize = true;
            this.chk_Nam.BackColor = System.Drawing.SystemColors.Control;
            this.chk_Nam.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Nam.ForeColor = System.Drawing.Color.Blue;
            this.chk_Nam.Location = new System.Drawing.Point(180, 151);
            this.chk_Nam.Name = "chk_Nam";
            this.chk_Nam.Size = new System.Drawing.Size(81, 34);
            this.chk_Nam.TabIndex = 38;
            this.chk_Nam.Text = "Nam";
            this.chk_Nam.UseVisualStyleBackColor = false;
            // 
            // lbl_TieuDeQLThuePhong
            // 
            this.lbl_TieuDeQLThuePhong.AutoSize = true;
            this.lbl_TieuDeQLThuePhong.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDeQLThuePhong.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TieuDeQLThuePhong.Location = new System.Drawing.Point(425, 9);
            this.lbl_TieuDeQLThuePhong.Name = "lbl_TieuDeQLThuePhong";
            this.lbl_TieuDeQLThuePhong.Size = new System.Drawing.Size(351, 39);
            this.lbl_TieuDeQLThuePhong.TabIndex = 37;
            this.lbl_TieuDeQLThuePhong.Text = "THÔNG TIN PHÒNG THUÊ";
            // 
            // dtp_NgayDen
            // 
            this.dtp_NgayDen.Location = new System.Drawing.Point(829, 154);
            this.dtp_NgayDen.Name = "dtp_NgayDen";
            this.dtp_NgayDen.Size = new System.Drawing.Size(321, 27);
            this.dtp_NgayDen.TabIndex = 9;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(829, 50);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(321, 27);
            this.txt_DiaChi.TabIndex = 8;
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Location = new System.Drawing.Point(829, 104);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(321, 27);
            this.txt_SoPhong.TabIndex = 7;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(181, 106);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(335, 27);
            this.txt_HoTen.TabIndex = 6;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(181, 56);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(335, 27);
            this.txt_cmnd.TabIndex = 5;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.ForeColor = System.Drawing.Color.Blue;
            this.lbl_DiaChi.Location = new System.Drawing.Point(703, 50);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(88, 30);
            this.lbl_DiaChi.TabIndex = 4;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_NgayDen
            // 
            this.lbl_NgayDen.AutoSize = true;
            this.lbl_NgayDen.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayDen.ForeColor = System.Drawing.Color.Blue;
            this.lbl_NgayDen.Location = new System.Drawing.Point(703, 151);
            this.lbl_NgayDen.Name = "lbl_NgayDen";
            this.lbl_NgayDen.Size = new System.Drawing.Size(111, 30);
            this.lbl_NgayDen.TabIndex = 3;
            this.lbl_NgayDen.Text = "Ngày đến:";
            // 
            // lbl_SoPhong
            // 
            this.lbl_SoPhong.AutoSize = true;
            this.lbl_SoPhong.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoPhong.ForeColor = System.Drawing.Color.Blue;
            this.lbl_SoPhong.Location = new System.Drawing.Point(703, 101);
            this.lbl_SoPhong.Name = "lbl_SoPhong";
            this.lbl_SoPhong.Size = new System.Drawing.Size(112, 30);
            this.lbl_SoPhong.TabIndex = 2;
            this.lbl_SoPhong.Text = "Số phòng:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.ForeColor = System.Drawing.Color.Blue;
            this.lbl_HoTen.Location = new System.Drawing.Point(35, 103);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(119, 30);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "Họ và Tên:";
            // 
            // lbl_cmnd
            // 
            this.lbl_cmnd.AutoSize = true;
            this.lbl_cmnd.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmnd.ForeColor = System.Drawing.Color.Blue;
            this.lbl_cmnd.Location = new System.Drawing.Point(35, 53);
            this.lbl_cmnd.Name = "lbl_cmnd";
            this.lbl_cmnd.Size = new System.Drawing.Size(146, 30);
            this.lbl_cmnd.TabIndex = 0;
            this.lbl_cmnd.Text = "CMND/CCCD:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.CMND,
            this.HoVaTen,
            this.GioiTinh,
            this.DiaChi,
            this.NgayDen});
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 350);
            this.dataGridView1.TabIndex = 37;
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.MinimumWidth = 6;
            this.SoPhong.Name = "SoPhong";
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND/CCCD";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            // 
            // HoVaTen
            // 
            this.HoVaTen.HeaderText = "Họ và Tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // NgayDen
            // 
            this.NgayDen.HeaderText = "Ngày đến";
            this.NgayDen.MinimumWidth = 6;
            this.NgayDen.Name = "NgayDen";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1215, 26);
            this.statusStrip1.TabIndex = 43;
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
            this.btn_Thoat.Location = new System.Drawing.Point(1093, 605);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(110, 41);
            this.btn_Thoat.TabIndex = 42;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.floppy_disk;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(977, 605);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Luu.Size = new System.Drawing.Size(110, 41);
            this.btn_Luu.TabIndex = 41;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(745, 605);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(110, 41);
            this.btn_Xoa.TabIndex = 40;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.wrench;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(861, 605);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(110, 41);
            this.btn_Sua.TabIndex = 39;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.button;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(629, 605);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(110, 41);
            this.btn_Them.TabIndex = 38;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // frm_QuanLyThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 691);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuanLyThuePhong";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thuê phòng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_NgayDen;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_NgayDen;
        private System.Windows.Forms.Label lbl_SoPhong;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_cmnd;
        private System.Windows.Forms.Label lbl_TieuDeQLThuePhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.CheckBox chk_Nu;
        private System.Windows.Forms.CheckBox chk_Nam;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
    }
}