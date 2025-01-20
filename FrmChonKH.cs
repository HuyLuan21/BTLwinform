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
    public partial class FrmChonKH : Form
    {
        Data data = new Data();
        public static string[] str = new string[5];
        public FrmChonKH()
        {
            InitializeComponent();
        }



        private void Chonbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChonKH_Load(object sender, EventArgs e)
        {
            string query = "select * from v_khachhang";
            data.Select(query, dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        int row;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    row = e.RowIndex;
                
                    for (int i = 0; i < str.Length; i++)
                    {
                        var cellValue = dataGridView1[i, row].Value;
                        str[i] = cellValue?.ToString() ?? string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn khách hàng: " + ex.Message);
                }
            }
        }
    }
}
