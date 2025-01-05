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
    public partial class Customer : Form
    {
        Data data = new Data();
        public Customer()
        {
            InitializeComponent();
        }

        private void LoadDataGirdView()
        {
            string query = "Select * from khachhang";
            data.Select(query, dgKhachHang);
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadDataGirdView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            btnQuayLai_Click(sender, e);
            LoadDataGirdView();
        }

        private new void Update()
        {
            if (dgKhachHang.CurrentRow != null)
            {
                int row = dgKhachHang.CurrentRow.Index;
                Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "makh", (dgKhachHang[0, row].Value.ToString()) },
                        { "@tenkh", (txtTenKH.Text) },
                        { "@gioitinh" , (cboGioiTinh.Text) },
                        { "@sdt", int.Parse(txtSDT.Text) },
                        { "@diachi", (txtDiaChi.Text) }
                    };

                // Gọi phương thức Insert với tên Stored Procedure và tham số
                data.Insert_Update("sp_upkh", parameters);
                MessageBox.Show("Sửa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }
        private void Add()
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

        }
    }
}
