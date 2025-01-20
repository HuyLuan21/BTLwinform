using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class UserName : Form
    {
        public UserName()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnel(btnSanPham);



        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );

        public void pnel(Button btn)
        {
            panel3.Height = btn.Height;
            panel3.Top = btn.Top;
            panel3.Left = btn.Left;
        }

        private void LoadFormIntoPanel(Form form, string title)
        {
            lblTitle.Text = title;
            this.plLoadForm.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            plLoadForm.Controls.Add(form);
            form.Show();
        }


        private void btnSanPham_Click(object sender, EventArgs e)
        {
            pnel(btnSanPham);
            Product product = new Product();
            LoadFormIntoPanel(product, "Sản Phẩm");
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pnel(btnKhachHang);
            Customer customer = new Customer();
            LoadFormIntoPanel(customer, "Khách Hàng");
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnel(btnNhanVien);
            Employee employee = new Employee();
            LoadFormIntoPanel(employee, "Nhân Viên");
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            pnel(btnHoaDon);
            Bill bill = new Bill();
            LoadFormIntoPanel(bill, "Hóa Đơn");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            pnel(btnThongKe);
            ThongKe thongKe = new ThongKe();
            LoadFormIntoPanel(thongKe, "Thống Kê");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            pnel(btnDangXuat);
            this.Close();
            Login lg = new Login();
            lg.Show();
            Close();
        }

        public void leave(Button btn)
        {
            btn.BackColor = Color.FromArgb(203, 236, 247);
        }

        private void btnSanPham_Leave(object sender, EventArgs e)
        {
            leave(btnSanPham);
        }

        private void btnKhachHang_Leave(object sender, EventArgs e)
        {
            leave(btnKhachHang);
        }

        private void btnNhanVien_Leave(object sender, EventArgs e)
        {
            leave(btnNhanVien);
        }

        private void btnHoaDon_Leave(object sender, EventArgs e)
        {
            leave(btnHoaDon);
        }

        private void btnThongKe_Leave(object sender, EventArgs e)
        {
            leave(btnThongKe);
        }

        private void btnDangXuat_Leave(object sender, EventArgs e)
        {
            leave(btnDangXuat);
        }

        

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát?", "Xác nhận",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Đóng toàn bộ ứng dụng
            }

        }

        private void MiniumBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void UserName_Load(object sender, EventArgs e)
        {
            if (Login.role == "Nhân viên")  btnNhanVien.Enabled = false;
            lblUserName.Text = Login.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report report = new report();
            this.Close();
            report.Show();
        }
    }
}
