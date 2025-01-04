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
            cbbrole.Items.Clear();
            cbbrole.Items.Add("Nhân viên");
            cbbrole.Items.Add("Admin");
            cbbrole.SelectedIndex = 0;
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (data.checkuser(txbUsername.Text))
            {
                MessageBox.Show("Tai khoan nay da ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data.adduser(txbUsername.Text, txbPass.Text, cbbrole.SelectedItem.ToString());
            }
        }
    }
}
