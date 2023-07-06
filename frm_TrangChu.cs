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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void btn_TTP101_Click(object sender, EventArgs e)
        {
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien nv = new frm_QuanLyNhanVien();
            nv.Show();
        }

        private void thuêPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           frm_QuanLyTraPhong traPhong = new frm_QuanLyTraPhong();
            traPhong.Show();
        }

        private void btn_ThuePhong_Click(object sender, EventArgs e)
        {
            frm_QuanLyThuePhong quanLyThuePhong = new frm_QuanLyThuePhong();
            quanLyThuePhong.Show();
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            frm_QuanLyDichVu dv = new frm_QuanLyDichVu();
            dv.Show();
        }

        private void btn_QuanLyVatTu_Click(object sender, EventArgs e)
        {
            frm_QuanLyVatTu vatTu = new frm_QuanLyVatTu();
            vatTu.Show();
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            frm_QuanLyPhong phong = new frm_QuanLyPhong();
            phong.Show();
        }

        private void qLPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyPhong phong = new frm_QuanLyPhong();
            phong.Show();
        }

        private void qLVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyVatTu vatTu = new frm_QuanLyVatTu();
            vatTu.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyDichVu dv = new frm_QuanLyDichVu();
            dv.Show();
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btn_TraPhong_Click(object sender, EventArgs e)
        {
            frm_QuanLyTraPhong tra = new frm_QuanLyTraPhong();
            tra.Show();
        }

        private void đặtNhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyThuePhong quanLyThuePhong = new frm_QuanLyThuePhong();
            quanLyThuePhong.Show();
        }
    }
}
