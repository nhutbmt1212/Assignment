namespace PhanMemQuanLyKhachSan1
{
    partial class frm_DangNhap
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
            this.pal_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pal_left = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pal_giua = new System.Windows.Forms.Panel();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.pal_matkhau = new System.Windows.Forms.Panel();
            this.pnl_bottom_matkhau = new System.Windows.Forms.Panel();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.pal_tendangnhap = new System.Windows.Forms.Panel();
            this.pnl_bottom_tendangnhap = new System.Windows.Forms.Panel();
            this.lbl_tendangnhap = new System.Windows.Forms.Label();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_matkhau = new System.Windows.Forms.PictureBox();
            this.pic_tendangnhap = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pal_top.SuspendLayout();
            this.pal_left.SuspendLayout();
            this.pal_giua.SuspendLayout();
            this.pal_matkhau.SuspendLayout();
            this.pal_tendangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_matkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tendangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pal_top.Controls.Add(this.label1);
            this.pal_top.Controls.Add(this.btn_Close);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Padding = new System.Windows.Forms.Padding(5);
            this.pal_top.Size = new System.Drawing.Size(786, 47);
            this.pal_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN";
            // 
            // pal_left
            // 
            this.pal_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pal_left.Controls.Add(this.label2);
            this.pal_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pal_left.Location = new System.Drawing.Point(0, 47);
            this.pal_left.Name = "pal_left";
            this.pal_left.Size = new System.Drawing.Size(236, 402);
            this.pal_left.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 40.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 85);
            this.label2.TabIndex = 0;
            this.label2.Text = "A$AP";
            // 
            // pal_giua
            // 
            this.pal_giua.Controls.Add(this.pictureBox1);
            this.pal_giua.Controls.Add(this.btn_dangnhap);
            this.pal_giua.Controls.Add(this.pal_matkhau);
            this.pal_giua.Controls.Add(this.pal_tendangnhap);
            this.pal_giua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_giua.Location = new System.Drawing.Point(236, 47);
            this.pal_giua.Name = "pal_giua";
            this.pal_giua.Size = new System.Drawing.Size(550, 402);
            this.pal_giua.TabIndex = 2;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_dangnhap.FlatAppearance.BorderSize = 2;
            this.btn_dangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Lime;
            this.btn_dangnhap.Location = new System.Drawing.Point(0, 348);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(550, 54);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            this.btn_dangnhap.MouseEnter += new System.EventHandler(this.btn_dangnhap_MouseEnter);
            this.btn_dangnhap.MouseLeave += new System.EventHandler(this.btn_dangnhap_MouseLeave);
            // 
            // pal_matkhau
            // 
            this.pal_matkhau.Controls.Add(this.pic_matkhau);
            this.pal_matkhau.Controls.Add(this.pnl_bottom_matkhau);
            this.pal_matkhau.Controls.Add(this.lbl_matkhau);
            this.pal_matkhau.Controls.Add(this.txt_matkhau);
            this.pal_matkhau.Location = new System.Drawing.Point(28, 237);
            this.pal_matkhau.Name = "pal_matkhau";
            this.pal_matkhau.Size = new System.Drawing.Size(494, 46);
            this.pal_matkhau.TabIndex = 4;
            // 
            // pnl_bottom_matkhau
            // 
            this.pnl_bottom_matkhau.BackColor = System.Drawing.Color.White;
            this.pnl_bottom_matkhau.Location = new System.Drawing.Point(174, 34);
            this.pnl_bottom_matkhau.Name = "pnl_bottom_matkhau";
            this.pnl_bottom_matkhau.Size = new System.Drawing.Size(281, 1);
            this.pnl_bottom_matkhau.TabIndex = 4;
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matkhau.Location = new System.Drawing.Point(55, 13);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(75, 20);
            this.lbl_matkhau.TabIndex = 1;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_matkhau.Location = new System.Drawing.Point(174, 9);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(284, 23);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.Text = "Nhập mật khẩu";
            this.txt_matkhau.Click += new System.EventHandler(this.txt_matkhau_Click);
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            // 
            // pal_tendangnhap
            // 
            this.pal_tendangnhap.Controls.Add(this.pic_tendangnhap);
            this.pal_tendangnhap.Controls.Add(this.pnl_bottom_tendangnhap);
            this.pal_tendangnhap.Controls.Add(this.lbl_tendangnhap);
            this.pal_tendangnhap.Controls.Add(this.txt_tendangnhap);
            this.pal_tendangnhap.Location = new System.Drawing.Point(28, 163);
            this.pal_tendangnhap.Name = "pal_tendangnhap";
            this.pal_tendangnhap.Size = new System.Drawing.Size(494, 46);
            this.pal_tendangnhap.TabIndex = 3;
            // 
            // pnl_bottom_tendangnhap
            // 
            this.pnl_bottom_tendangnhap.BackColor = System.Drawing.Color.White;
            this.pnl_bottom_tendangnhap.Location = new System.Drawing.Point(174, 35);
            this.pnl_bottom_tendangnhap.Name = "pnl_bottom_tendangnhap";
            this.pnl_bottom_tendangnhap.Size = new System.Drawing.Size(281, 1);
            this.pnl_bottom_tendangnhap.TabIndex = 4;
            // 
            // lbl_tendangnhap
            // 
            this.lbl_tendangnhap.AutoSize = true;
            this.lbl_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendangnhap.Location = new System.Drawing.Point(55, 12);
            this.lbl_tendangnhap.Name = "lbl_tendangnhap";
            this.lbl_tendangnhap.Size = new System.Drawing.Size(116, 20);
            this.lbl_tendangnhap.TabIndex = 1;
            this.lbl_tendangnhap.Text = "Tên đăng nhập";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_tendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendangnhap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_tendangnhap.Location = new System.Drawing.Point(174, 9);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(284, 23);
            this.txt_tendangnhap.TabIndex = 2;
            this.txt_tendangnhap.Text = "Nhập tên đăng nhập";
            this.txt_tendangnhap.Click += new System.EventHandler(this.txt_tendangnhap_Click);
            this.txt_tendangnhap.TextChanged += new System.EventHandler(this.txt_tendangnhap_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.icons8_user_100_2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pic_matkhau
            // 
            this.pic_matkhau.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.icons8_password_48;
            this.pic_matkhau.Location = new System.Drawing.Point(4, 3);
            this.pic_matkhau.Name = "pic_matkhau";
            this.pic_matkhau.Size = new System.Drawing.Size(45, 40);
            this.pic_matkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_matkhau.TabIndex = 6;
            this.pic_matkhau.TabStop = false;
            this.pic_matkhau.Click += new System.EventHandler(this.pic_matkhau_Click);
            // 
            // pic_tendangnhap
            // 
            this.pic_tendangnhap.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.icons8_username_48;
            this.pic_tendangnhap.Location = new System.Drawing.Point(4, 4);
            this.pic_tendangnhap.Name = "pic_tendangnhap";
            this.pic_tendangnhap.Size = new System.Drawing.Size(45, 40);
            this.pic_tendangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_tendangnhap.TabIndex = 5;
            this.pic_tendangnhap.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::PhanMemQuanLyKhachSan1.Properties.Resources.icons8_close_48;
            this.btn_Close.Location = new System.Drawing.Point(717, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(69, 47);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(786, 449);
            this.Controls.Add(this.pal_giua);
            this.Controls.Add(this.pal_left);
            this.Controls.Add(this.pal_top);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_left.ResumeLayout(false);
            this.pal_left.PerformLayout();
            this.pal_giua.ResumeLayout(false);
            this.pal_matkhau.ResumeLayout(false);
            this.pal_matkhau.PerformLayout();
            this.pal_tendangnhap.ResumeLayout(false);
            this.pal_tendangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_matkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tendangnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Panel pal_left;
        private System.Windows.Forms.Panel pal_giua;
        private System.Windows.Forms.Panel pal_tendangnhap;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Panel pnl_bottom_tendangnhap;
        private System.Windows.Forms.Panel pal_matkhau;
        private System.Windows.Forms.PictureBox pic_matkhau;
        private System.Windows.Forms.Panel pnl_bottom_matkhau;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.PictureBox pic_tendangnhap;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}