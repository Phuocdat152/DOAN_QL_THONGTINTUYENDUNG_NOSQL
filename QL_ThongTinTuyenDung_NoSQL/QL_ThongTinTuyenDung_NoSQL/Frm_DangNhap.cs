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
    public partial class Frm_DangNhap : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL("QL_Tuyendung");
        public Frm_DangNhap()
        {
            InitializeComponent();
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Text = "123456";
            txt_TaiKhoan.Text = "admin1";
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tk = txt_TaiKhoan.Text;
            string mk = txt_MatKhau.Text;

            if (tk.Length == 0 || mk.Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            Xuly_NoSQL thongTinDangNhap = xuly.kiemTraDN(tk, mk);
            // Kiểm tra đăng nhập
            if (thongTinDangNhap == null)
            {
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }

            // Nếu đăng nhập thành công, tắt form hiện hành và mở form frm_main
            this.Hide();
            Frm_Main mainForm = new Frm_Main(thongTinDangNhap.TaiKhoanQly, thongTinDangNhap.PhanQuyen);
            mainForm.Show(); // Mở form frm_main
        }
    }
}
