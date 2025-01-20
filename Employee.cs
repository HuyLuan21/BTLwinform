using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Core;

namespace Phone_Store
{
    public partial class Employee : Form
    {
        Data data = new Data();
        public Employee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataGridView()
        {
            dtpNgaySinh.MaxDate = DateTime.Now.Date;
            string query = "select * from v_nhanvien";
            data.Select(query, dgNhanVien);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            dgNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Add()
        {
            errorProvider1.Clear(); // Clear previous errors

            // Validate inputs
            if (!string.IsNullOrEmpty(txtHoTen.Text) &&
                !string.IsNullOrEmpty(txtDiaChi.Text) &&
                !string.IsNullOrEmpty(txtSDT.Text) &&
                !string.IsNullOrEmpty(cboGioiTinh.Text) &&
                !string.IsNullOrEmpty(cboChucVu.Text))
            {
                // Ensure phone number is valid
                if (!int.TryParse(txtSDT.Text, out int sdt) || txtSDT.Text.Length != 10)
                {
                    errorProvider1.SetError(txtSDT, "Số điện thoại phải là số và có 10 chữ số");
                    txtSDT.Focus();
                    return; // Stop further execution
                }

                // Create a dictionary to store the parameters
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@hoten", txtHoTen.Text },
                    { "@ngaysinh", dtpNgaySinh.Value.Date },
                    { "@gioitinh", cboGioiTinh.Text },
                    { "@sdt", sdt },
                    { "@diachi", txtDiaChi.Text },
                    { "@chucvu", cboChucVu.Text }
                };

                try
                {
                    data.Insert_Update("sp_addnv", parameters);
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    errorProvider1.SetError(txtHoTen, "Họ tên nhân viên không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    errorProvider1.SetError(txtDiaChi, "Địa chỉ không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    errorProvider1.SetError(txtSDT, "Số điện thoại phải có 10 số");
                }
                if (string.IsNullOrEmpty(cboGioiTinh.Text))
                {
                    errorProvider1.SetError(cboGioiTinh, "Giới tính không được bỏ trống");
                }
                if (string.IsNullOrEmpty(cboChucVu.Text))
                {
                    errorProvider1.SetError(cboChucVu, "Chức vụ không được bỏ trống");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            LoadDataGridView();
        }
        int row;
        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Ensure not clicking on header
                {
                    DataGridViewRow row = dgNhanVien.Rows[e.RowIndex];

                    txtHoTen.Text = row.Cells[1].Value.ToString().Trim();
                    dtpNgaySinh.Text = row.Cells[2].Value.ToString().Trim();
                    cboGioiTinh.Text = row.Cells[3].Value.ToString().Trim();
                    txtSDT.Text = row.Cells[4].Value.ToString().Trim();
                    txtDiaChi.Text = row.Cells[5].Value.ToString().Trim();
                    cboChucVu.Text = row.Cells[6].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
            }
        }

        private new void Update()
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text) &&
                !string.IsNullOrEmpty(txtDiaChi.Text) &&
                !string.IsNullOrEmpty(txtSDT.Text) &&
                !string.IsNullOrEmpty(cboChucVu.Text) &&
                !string.IsNullOrEmpty(cboGioiTinh.Text) &&
                !string.IsNullOrEmpty(dtpNgaySinh.Text))
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@manv", (dgNhanVien[0,row].Value.ToString()) },
                    { "@hoten", (txtHoTen.Text) },
                    { "@ngaysinh", DateTime.Parse(dtpNgaySinh.Text)},
                    { "@gioitinh" , (cboGioiTinh.Text) },
                    { "@sdt", int.Parse(txtSDT.Text) },
                    { "@diachi", (txtDiaChi.Text) },
                    { "@chucvu", (cboChucVu.Text) }
                };

                // Gọi phương thức Insert với tên Stored Procedure và tham số
                data.Insert_Update("sp_upnv", parameters);
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    errorProvider1.SetError(txtHoTen, "Họ tên nhân viên không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    errorProvider1.SetError(txtDiaChi, "Địa chỉ nhân viên không được bỏ trống");
                }
                if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    errorProvider1.SetError(txtSDT, "Số điện thoại nhân viên không được bỏ trống");
                }
                if (string.IsNullOrEmpty(cboChucVu.Text))
                {
                    errorProvider1.SetError(cboChucVu, "Chức vụ nhân viên không được bỏ trống");
                }
                if (string.IsNullOrEmpty(cboGioiTinh.Text))
                {
                    errorProvider1.SetError(cboGioiTinh, "Giới tính nhân viên không được bỏ trống");
                }
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            Update();
            btnLoad_Click(sender, e);
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xoá không?", "Xoá nhân viên", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try 
                {
                    string manv = dgNhanVien.CurrentRow.Cells[0].Value.ToString();
                    string query = $"delete from nhanvien WHERE manv = '{manv}'";
                    data.Delete(query);
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"select * from v_nhanvien where hoten like N'%{txtSearch.Text}%'";
            data.Select(query, dgNhanVien);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtSearch.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = "";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
