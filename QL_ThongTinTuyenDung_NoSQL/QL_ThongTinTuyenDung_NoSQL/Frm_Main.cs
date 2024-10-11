using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThongTinTuyenDung_NoSQL
{
    public partial class Frm_Main : Form
    {
        public string TaiKhoanQly { get; private set; }
        public string PhanQuyen { get; private set; }
        public Frm_Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí form ở giữa màn hình
            kiemtra_phanQuyen(PhanQuyen);
        }

        public Frm_Main(string name, string quyen)
        {
            this.TaiKhoanQly = name;
            this.PhanQuyen = quyen;
            InitializeComponent();
            //toolStripStatusLabel1.Text = "Xin chào: " + name;
            this.StartPosition = FormStartPosition.CenterScreen;

            kiemtra_phanQuyen(PhanQuyen);
        }

        // Kiểm tra quyền truy cập của người dùng
        public void kiemtra_phanQuyen(string quyen)
        {
            if (PhanQuyen == "User")
            {
                btn_SaoLuuPhucHoi.Enabled = false;  // Vô hiệu hóa các nút dành cho Admin
                btn_QuanLyTK.Enabled = false;
            }
        }

        private void btn_DSCty_Click(object sender, EventArgs e)
        {
            Frm_CtyTuyenDung frm = new Frm_CtyTuyenDung();
            frm.ShowDialog(this);
        }

        private void btn_ViecCanTuyen_Click(object sender, EventArgs e)
        {
            Frm_ViecCanTuyen frm = new Frm_ViecCanTuyen();
            frm.ShowDialog(this);
        }

        private void btn_QuanLyTK_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan frm = new Frm_TaiKhoan();
            frm.ShowDialog(this);
        }
    }
}
