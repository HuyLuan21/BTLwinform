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
            string query = "Select * from v_khachhang";
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
            if (!string.IsNullOrEmpty(txtTenKH.Text) &&
             !string.IsNullOrEmpty(txtDiaChi.Text) &&
             !string.IsNullOrEmpty(txtSDT.Text) &&
             !string.IsNullOrEmpty(cboGioiTinh.Text))
            {
                // Tạo một từ điển chứa các tham số
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@tenkh", (txtTenKH.Text) },
                    {"@makh",  (dgKhachHang[0,row].Value.ToString()) },
                    { "@gioitinh" , (cboGioiTinh.Text) },
                    { "@sdt", int.Parse(txtSDT.Text) },
                    { "@diachi", (txtDiaChi.Text) }

                };

                // Gọi phương thức Insert với tên Stored Procedure và tham số
                data.Insert_Update("sp_upkh", parameters);

                MessageBox.Show("Cập nhật khách hàng thành công");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    errorProvider1.SetError(txtTenKH, "tên khách hàng không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    errorProvider1.SetError(txtDiaChi, "tên khách hàng không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    errorProvider1.SetError(txtSDT, "tên khách hàng không được bỏ trống");
                }
                if (string.IsNullOrEmpty(cboGioiTinh.Text))
                {
                    errorProvider1.SetError(cboGioiTinh, "tên khách hàng không được bỏ trống");
                }
            }
        }
        private void Add()
        {
            errorProvider1.Clear();
            if (!string.IsNullOrEmpty(txtTenKH.Text) &&
            !string.IsNullOrEmpty(txtDiaChi.Text) &&
            !string.IsNullOrEmpty(txtSDT.Text) &&
            !string.IsNullOrEmpty(cboGioiTinh.Text))
            {
                // Tạo một từ điển chứa các tham số
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@tenkh", (txtTenKH.Text) },
                    { "@gioitinh" , (cboGioiTinh.Text) },
                    { "@sdt", int.Parse(txtSDT.Text) },
                    { "@diachi", (txtDiaChi.Text) }

                };

                // Gọi phương thức Insert với tên Stored Procedure và tham số
                data.Insert_Update("sp_addkh", parameters);

                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    errorProvider1.SetError(txtTenKH, "tên khách hàng không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    errorProvider1.SetError(txtDiaChi, "địa chỉ không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    errorProvider1.SetError(txtSDT, "Số điện thoại không được bỏ trống");
                }
                if (string.IsNullOrEmpty(cboGioiTinh.Text))
                {
                    errorProvider1.SetError(cboGioiTinh, "giới tính không được bỏ trống");
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoadDataGirdView();
            txtSearch.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = "";
                }
            }
        }

 

      
        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgKhachHang.Rows[e.RowIndex];
                    txtTenKH.Text = row.Cells[1].Value.ToString().Trim();
                    cboGioiTinh.Text = row.Cells[2].Value.ToString().Trim();
                    txtSDT.Text = row.Cells[3].Value.ToString().Trim();
                    txtDiaChi.Text = row.Cells[4].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            Update();
            LoadDataGirdView();
        }
        int row;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng xóa!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xoá không?", "Xoá khách hàng", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string makh = dgKhachHang.CurrentRow.Cells[0].Value.ToString();
                    string query = $"delete from khachhang WHERE makh = '{makh}'";
                    data.Delete(query);
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadDataGirdView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
               
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = $"select * from khachhang where tenkh like N'%{txtSearch.Text}%' and status = 'active'";
            data.Select(query, dgKhachHang);
        }
    }
}
