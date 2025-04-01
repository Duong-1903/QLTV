using System.Data.SqlClient;
namespace QLTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Đăng nhập";
        }

        private void lbl_taotaikhoan_Click(object sender, EventArgs e)
        {
            pnl_dangnhap.Visible = false;
            pnl_taotaikhoan.Visible = true;
            pnl_taotaikhoan.Location = pnl_dangnhap.Location;
            this.Text = "Tạo tài khoản";
        }

        private void lbl_quenmatkhau_Click(object sender, EventArgs e)
        {
            pnl_dangnhap.Visible = false;
            pnl_quenmatkhau.Visible = true;
            pnl_quenmatkhau.Location = pnl_dangnhap.Location;
            this.Text = "Quên mật khẩu";
        }

        private void txt_taikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_matkhau.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_taotaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_taomatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_taomatkhau.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_xnmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_xnmatkhau.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_taomatkhau_Click(object sender, EventArgs e)
        {
            pnl_taotaikhoan.Visible = false;
            pnl_dangnhap.Visible = true;
            this.Text = "Đăng nhập";
        }

        private void txt_timtaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_matkhaumoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_matkhaumoi.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_xnmatkhaumoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_xnmatkhaumoi.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_capnhatmatkhau_Click(object sender, EventArgs e)
        {
            pnl_quenmatkhau.Visible = false;
            pnl_dangnhap.Visible = true;
            this.Text = "Đăng nhập";
        }
    }
}
