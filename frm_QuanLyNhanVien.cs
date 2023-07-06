using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhanMemQuanLyKhachSan1
{
    public partial class frm_QuanLyNhanVien : Form
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNhanVien.Text;
            string tnv = txt_TenNhanVien.Text;
            string gt = chk_Nam.Checked ? "Nam" : "Nữ";
            string dc = txt_DiaChi.Text;
            string sdt = msk_DienThoai.Text;
            string ns = msk_NgaySinh.Text;

            dataGridView1.Rows.Add(manv, tnv, gt,dc,sdt,ns );
        }
    }
}
