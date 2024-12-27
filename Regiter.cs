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

        private void button1_Click(object sender, EventArgs e)
        {
            Data Data = new Data();
            if (Data.checkuser(txbUsername.Text))
            {
                MessageBox.Show("Tai khoan nay da ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Data.adduser(txbUsername.Text, txbPass.Text,cbbrole.ToString());
                MessageBox.Show("Dang ky thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Regiter_Load(object sender, EventArgs e)
        {
            cbbrole.Items.Clear();
            cbbrole.Items.Add("Nhân viên");
            cbbrole.Items.Add("Admin");
            cbbrole.SelectedIndex = 0;
        }
    }
}
