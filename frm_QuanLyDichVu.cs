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
    public partial class frm_QuanLyDichVu : Form
    {
        public frm_QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void frm_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            lstv_ThongTinDichVu.View = View.Details;
            lstv_ThongTinDichVu.Columns.Add("Mã dịch vụ", 100);
            lstv_ThongTinDichVu.Columns.Add("Tên dịch vụ", 150);
            lstv_ThongTinDichVu.Columns.Add("Đơn giá", 130);
            lstv_ThongTinDichVu.Columns.Add("Đơn vị tính", 130);            
        }
    }
}
