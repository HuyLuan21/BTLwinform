using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class Regiter : Form
    {
        public Regiter()
        {
            InitializeComponent();
        }
        Data data = new Data();
        

    

        private void Regiter_Load(object sender, EventArgs e)
        {
            List<string> roles = new List<string>();
            data.Loadrole(roles);
            roles.Sort();
            foreach (string role in roles)
            {
                cbbrole.Items.Add(role);
            }
            if (cbbrole.Items.Count > 0)
            {
                cbbrole.SelectedIndex = 1;
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (data.checkuser(txbUsername.Text))
            {
                MessageBox.Show("Tai khoan nay da ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPass.KeyDown += ClearPass_User_onBackspace;
                txbUsername.KeyDown += ClearPass_User_onBackspace;
            }
            else
            {
                data.adduser(txbUsername.Text, txbPass.Text, cbbrole.SelectedItem.ToString());
            }
        }
        private void ClearPass_User_onBackspace(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txbUsername.Text = string.Empty;
                txbPass.Text = string.Empty;
                txbPass.KeyDown -= ClearPass_User_onBackspace; // Gỡ bỏ event handler sau khi đã xử lý
                txbUsername.KeyDown -= ClearPass_User_onBackspace;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void checkboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxShow.Checked)
            {
                txbPass.PasswordChar = '\0';
            }
            else
            {
                txbPass.PasswordChar = '*';
            }
        }
    }
}
