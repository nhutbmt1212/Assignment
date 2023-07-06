using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan1
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_tendangnhap.TabStop = false;
        txt_matkhau.TabStop = false;    
        }

        private void btn_dangnhap_MouseEnter(object sender, EventArgs e)
        {
            btn_dangnhap.ForeColor = Color.Black;
        }

        private void btn_dangnhap_MouseLeave(object sender, EventArgs e)
        {
            btn_dangnhap.ForeColor = Color.Lime;

        }

        private void txt_tendangnhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                txt_tendangnhap.ForeColor = Color.White;
            }
            catch { }
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                txt_matkhau.ForeColor = Color.White;
               txt_matkhau.PasswordChar = '*';
            }
            catch { }
        }

        private void txt_tendangnhap_Click(object sender, EventArgs e)
        {
            txt_tendangnhap.Text=string.Empty;
           
        }

        private void txt_matkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.Text=string.Empty;
           
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pic_matkhau_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }
    }
}
