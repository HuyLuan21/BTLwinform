using System;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class FrmChonSP : Form
    {
        Data data = new Data();
        public static string[] str = new string[6];
        public FrmChonSP()
        {
            InitializeComponent();
        }


        int row;


        private void FrmChonSP_Load(object sender, EventArgs e)
        {
            string query = "select * from v_chonsp";
            data.Select(query, dataGridView1);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(str[0]))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi nhấn nút Chọn!");
                return;
            }
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {

                    str[0] = dataGridView1[0, row].Value.ToString();
                    str[1] = dataGridView1[1, row].Value.ToString();
                    str[2] = dataGridView1[2, row].Value.ToString();
                    str[3] = dataGridView1[3, row].Value.ToString();
                    str[4] = dataGridView1[5, row].Value.ToString();
                    str[5] = dataGridView1[6, row].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn sản phẩm: " + ex.Message);
                }
            }
        }
    }
}

