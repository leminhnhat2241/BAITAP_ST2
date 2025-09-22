using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST2
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        // Sự kiện này được tạo ra khi bạn double-click vào nút Đăng nhập
   

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ô textbox
            string username = txt_username.Text;
            string password = txtPassword2.Text;

            // Kiểm tra nếu tên đăng nhập và mật khẩu là "admin"
            if (username == "admin" && password == "admin")
            {
                // Nếu đúng, hiển thị thông báo thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tạo một đối tượng của form trang chủ
                frm_TrangChu trangChu = new frm_TrangChu();

                // Hiển thị form trang chủ
                trangChu.Show();

                // Ẩn form đăng nhập hiện tại đi
                this.Hide();
            }
            else
            {
                // Nếu sai, hiển thị thông báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}