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
    public partial class Bill : Form
    {
        Data data = new Data();
        public static string[] str = new string[8];
        

  
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string query = "Select * from v_hoadon_chitiet";
            data.Select(query, dgHoaDon);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            FrmAddBill frmAddBill = new FrmAddBill();
            frmAddBill.ShowDialog();
            LoadDataGridView();
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(str[0]))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!");
                return;
            }
            else{
                FrmHoaDonBanHang frmDetail = new FrmHoaDonBanHang();
                frmDetail.ShowDialog();
            }

        }
      

        private void dgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgHoaDon.Rows[e.RowIndex];
                    str[0] = row.Cells[0].Value.ToString();
                    str[1] = row.Cells[0].Value.ToString();
                    str[2] = row.Cells[0].Value.ToString();
                    str[3] = row.Cells[0].Value.ToString();
                    str[4] = row.Cells[0].Value.ToString();
                    str[5] = row.Cells[0].Value.ToString();
                    str[6] = row.Cells[0].Value.ToString();
                    str[7] = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            }
              
            
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = $"select * from v_hoadon_chitiet where ngaytao >= '{dtNgayBD.Value.ToString("yyyy-MM-dd")}' and ngaytao <= '{dtNgayKT.Value.ToString("yyyy-MM-dd")}'";
            data.Select(query, dgHoaDon);
            dgHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dtNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dtNgayBD.MaxDate = dtNgayKT.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR_bill bill = new CR_bill();
        }
    }
}
