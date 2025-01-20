using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Phone_Store
{
    public partial class Product : Form
    {
        Data data = new Data();
        public Product()
        {
            InitializeComponent();
        }

        private void LoadDataGirdView()
        {
            string query = "Select * from v_SanPham";
            data.Select(query, dgSanPham);
        }
        private int row;

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }
        //tao 1 bien chua gia tri row 
        private void Add()
        {
            errorProvider.Clear();

            if (!string.IsNullOrEmpty(txtTenSanPham.Text) &&
                !string.IsNullOrEmpty(cboBoNho.Text) &&
                !string.IsNullOrEmpty(cboRam.Text) &&
                !string.IsNullOrEmpty(cboTinhTrang.Text) &&
                !string.IsNullOrEmpty(txtSoLuong.Text) &&
                !string.IsNullOrEmpty(txtGiaNhap.Text) &&
                !string.IsNullOrEmpty(txtGiaBan.Text))
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>
{
                 { "@tensp", txtTenSanPham.Text },
    { "@bonho", int.Parse(cboBoNho.Text) },
    { "@ram", int.Parse(cboRam.Text) },
    { "@tinhtrang", cboTinhTrang.Text },
    { "@soluong", int.Parse(txtSoLuong.Text) },
    { "@gianhap", float.Parse(txtGiaNhap.Text) },
    { "@giaban", float.Parse(txtGiaBan.Text) }
                    };

                    data.Insert_Update("sp_addsp", parameters);
                    MessageBox.Show("Thêm sản phẩm thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenSanPham.Text))
                {
                    errorProvider.SetError(txtTenSanPham, "Tên sản phẩm không được bỏ trống.");
                }
                if (string.IsNullOrEmpty(cboBoNho.Text))
                {
                    errorProvider.SetError(cboBoNho, "Bộ nhớ không được bỏ trống.");
                }
                if (string.IsNullOrEmpty(cboRam.Text))
                {
                    errorProvider.SetError(cboRam, "RAM không được bỏ trống.");
                }
                if (string.IsNullOrEmpty(cboTinhTrang.Text))
                {
                    errorProvider.SetError(cboTinhTrang, "Tình trạng không được bỏ trống.");
                }
                if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    errorProvider.SetError(txtSoLuong, "Số lượng không được bỏ trống.");
                }
                else if (!int.TryParse(txtSoLuong.Text, out _))
                {
                    errorProvider.SetError(txtSoLuong, "Số lượng phải là số nguyên.");
                }
                if (string.IsNullOrEmpty(txtGiaNhap.Text))
                {
                    errorProvider.SetError(txtGiaNhap, "Giá nhập không được bỏ trống.");
                }
                else if (!float.TryParse(txtGiaNhap.Text, out _))
                {
                    errorProvider.SetError(txtGiaNhap, "Giá nhập phải là số.");
                }
                if (string.IsNullOrEmpty(txtGiaBan.Text))
                {
                    errorProvider.SetError(txtGiaBan, "Giá bán không được bỏ trống.");
                }
                else if (!float.TryParse(txtGiaBan.Text, out _))
                {
                    errorProvider.SetError(txtGiaBan, "Giá bán phải là số.");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            btnReset_Click(sender, e);
            LoadDataGirdView();
        }


        private new void Update()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@masp", dgSanPham[0,row].Value.ToString() },
                { "@tensp", txtTenSanPham.Text },
                { "@bonho", int.Parse(cboBoNho.Text) },
                { "@ram", int.Parse(cboRam.Text) },
                { "@tinhtrang", cboTinhTrang.Text },
                { "@soluong", int.Parse(txtSoLuong.Text) },
                { "@gianhap", float.Parse(txtGiaNhap.Text) },
                { "@giaban", float.Parse(txtGiaBan.Text) }
            };
            data.Insert_Update("sp_upsp", parameters);
            MessageBox.Show("Sửa sản phẩm thành công");
        }

        private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) //dam bao khi click vao header thi khong xay ra loi
                {
                    row = e.RowIndex;
                    txtTenSanPham.Text = dgSanPham[1, row].Value.ToString();
                    cboBoNho.Text = dgSanPham[2, row].Value.ToString();
                    cboRam.Text = dgSanPham[3, row].Value.ToString();
                    cboTinhTrang.Text = dgSanPham[4, row].Value.ToString();
                    txtSoLuong.Text = dgSanPham[5, row].Value.ToString();
                    txtGiaNhap.Text = dgSanPham[7, row].Value.ToString();
                    txtGiaBan.Text = dgSanPham[8, row].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xoá không?", "Xoá sản phẩm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = $"delete sanpham WHERE masp = '{dgSanPham[0, row].Value.ToString()}'";
                    data.Delete(query);
                    LoadDataGirdView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string query = "Select * from v_sanpham order by giaban asc";
                data.Select(query, dgSanPham);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string query = "Select * from v_sanpham order by giaban desc";
                data.Select(query, dgSanPham);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataGirdView();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = "";
                }
            }
            comboBox1.Text = "Sắp xếp theo";
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadDataGirdView();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            Update();
            LoadDataGirdView();
        }
    }
}
