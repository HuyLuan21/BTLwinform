﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class Login : Form

    {
        Data data = new Data();
   
        public static string role = role;
        public static string manv, username;
        public Login()
        {
            InitializeComponent();
            KeyPreview = true;
    

        }
        private Point origiCapsPos;
        private void Login_Load(object sender, EventArgs e)
        {
            origiCapsPos = Caplocks.Location;
            Caplocks.Location = Showpassword.Location;
            cbbRole.Items.Clear();

            // Tạo list để chứa roles từ database
            List<string> roles = new List<string>();
            data.Loadrole(roles);  // Gọi hàm Loadrole từ class Data

            roles.Sort();
            //sap xep role theo thu tu abc

            // Thêm các role vào combobox
            foreach (string role in roles)
            {
                cbbRole.Items.Add(role);
            }

            // Set index mặc định  ( 0 = Admin, 1 = Nhân viên)
            if (cbbRole.Items.Count > 0)
            {
                cbbRole.SelectedIndex = 1;
            }

            toolTip1.SetToolTip(Showpassword, "Hiện/Ẩn mật khẩu");
            toolTip1.SetToolTip(Caplocks, "Caps Lock đang bật");
            tbxPass.PasswordChar = '\0';    // Mặc định hiển thị password

            Showpassword.Visible = false;   // Ẩn button show password khi khong o trong textbox

            Caplocks.Visible = false;       //an caplocks khi khong o trong textbox va an khi chua bat casplock

            tbxPass.KeyDown += tbxPass_KeyDown;
            txbUser.Focus();

        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            Showpassword.Visible = true;
            bool capsLock = (Control.IsKeyLocked(Keys.CapsLock));
            Caplocks.Location = origiCapsPos; // Khi focus, đưa Caplocks về vị trí gốc
            Caplocks.Visible = capsLock;
            if (capsLock)
            {
                Caplocks.BringToFront();
            }
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (!Showpassword.ClientRectangle.Contains(Showpassword.PointToClient(Control.MousePosition)))
            {
                Showpassword.Visible = false;
                Caplocks.Location = Showpassword.Location;
            }

        }


        private void Createbtn_Click(object sender, EventArgs e)
        {
            Regiter rg = new Regiter();
            rg.Show();
            this.Hide();
        }

        private void Loginbtnn_Click(object sender, EventArgs e)
        {
            UserName us = new UserName();
            if (data.checklogin(txbUser.Text, tbxPass.Text, cbbRole.Text))
            {
                username = txbUser.Text;
                role = cbbRole.Text;
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                us.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxPass.KeyDown += ClearPasswordOnBackspace;
            }
        }
        private void ClearPasswordOnBackspace(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                tbxPass.Text = string.Empty;
                tbxPass.KeyDown -= ClearPasswordOnBackspace; // Gỡ bỏ event handler sau khi đã xử lý
            }
        }

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra trạng thái Caps Lock
            bool capsLock = (Control.IsKeyLocked(Keys.CapsLock));

            // Hiển thị/ẩn biểu tượng Caps Lock
            if (capsLock)
            {
                Caplocks.Visible = true;
                Caplocks.BringToFront();
            }
            else
            {
                Caplocks.Visible = false;
            }
        }


        private bool showpass = false;//bien theo doi trang thai cua showpassword
        private void Showpassword_Click(object sender, EventArgs e)
        {
            showpass = !showpass;
            tbxPass.PasswordChar = showpass ? '\0' : '*';
            Showpassword.Image = showpass ? Properties.Resources.eye_open : Properties.Resources.eye_close;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            bool capsLock = (Control.IsKeyLocked(Keys.CapsLock));
            Caplocks.Visible = capsLock;
            if (capsLock)
            {
                Caplocks.BringToFront();
            }
        }

        private void MiniumBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        
    }

}
