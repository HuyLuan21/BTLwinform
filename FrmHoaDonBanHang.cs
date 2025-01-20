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
using TheArtOfDevHtmlRenderer.Core;

namespace Phone_Store
{
    public partial class FrmHoaDonBanHang : Form
    {
        Data data = new Data();
        Bill frmBill = new Bill();
        public FrmHoaDonBanHang()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        private void LoadDataGridView_Sanpham(string mahd)
        {
            string query = $"Select * from v_chitiet where mahd = '{mahd}'";
            data.Select(query, dgSanPham);
            dgSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            // Làm sạch các điều khiển trước khi tải dữ liệu mới
            txtMaHD.Clear();
            txtMaNV.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtNgayMua.Clear();
            txtTongTien.Clear();
            dgSanPham.DataSource = null; // Xóa dữ liệu trong DataGridView

            string[] str = Bill.str;

            // Kiểm tra độ dài của mảng trước khi truy cập
            if (str.Length >= 8) // Đảm bảo có đủ phần tử
            {
                txtMaHD.Text = str[0];
                txtMaNV.Text = str[1];
                txtTenKH.Text = str[2];
                txtSDT.Text = str[3];

                if (str[5].Length >= 10)
                {
                    txtNgayMua.Text = str[5].Substring(0, 10);
                }
                else
                {
                    txtNgayMua.Text = str[5]; // hoặc xử lý lỗi một cách thích hợp
                }
                txtTongTien.Text = str[7];
                LoadDataGridView_Sanpham(str[0]);
            }
            else
            {
                // Xử lý trường hợp mảng không đủ phần tử
                MessageBox.Show("Dữ liệu không hợp lệ.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
