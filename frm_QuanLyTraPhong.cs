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
    public partial class frm_QuanLyTraPhong : Form
    {
        public frm_QuanLyTraPhong()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            frm_QuanLyThuePhong thue = new frm_QuanLyThuePhong();
            thue.ShowDialog();
        }

        private void frm_QuanLyTraPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
