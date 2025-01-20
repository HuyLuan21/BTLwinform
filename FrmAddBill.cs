using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Phone_Store
{
    public partial class FrmAddBill : Form
    {
        Data data = new Data();
        public FrmAddBill()
        {
            InitializeComponent();
            dtpNgayMua.MaxDate = DateTime.Now.Date;
        }



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddBill_Load(object sender, EventArgs e)
        {

        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            FrmChonKH frmChonKH = new FrmChonKH();
            frmChonKH.ShowDialog();
            string[] str = FrmChonKH.str;
            txtMaKH.Text = str[0];
            txtHoTen.Text = str[1];
            txtGioiTinh.Text = str[2];
            txtSDT.Text = str[3];
            txtDiaChi.Text = str[4];
        }
  


        private bool KtraSolg(int x)
        {

            if (int.Parse(txtSoLuong.Text) > x)
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            }

            if (KtraSolg(soluong))
            {
                if (float.TryParse(txtDonGia.Text, out float donGia) && float.TryParse(txtSoLuong.Text, out float soLuong))
                {
                    float tongtien = donGia * soLuong;
                    string[] sanpham = new string[] 
                    { 
                        txtMaSP.Text, 
                        txtTenSP.Text, 
                        txtBoNho.Text, 
                        txtRam.Text, 
                        donGia.ToString("C0"),
                        txtSoLuong.Text, 
                        tongtien.ToString("C0")
                    };
                    
                    ListViewItem lvsp = new ListViewItem(sanpham);
                    listView1.Items.Add(lvsp);
                    thanhtien += tongtien;
                    txtThanhTien.Text = thanhtien.ToString("C0");

                    foreach (Control control in groupBox2.Controls)
                    {
                        if (control is TextBox)
                        {
                            control.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đơn giá và số lượng hợp lệ!");
                }
            }
        }
        static float thanhtien = 0;
        static int soluong = 0;
        private void btnChonSP_Click(object sender, EventArgs e)
        {
            try
            {
                FrmChonSP frmChonSP = new FrmChonSP();
                frmChonSP.ShowDialog();
                
                // Kiểm tra xem có dữ liệu được chọn không
                if (string.IsNullOrEmpty(FrmChonSP.str[0]))
                {
                    return;
                }

                string[] str = FrmChonSP.str;

                // Gán giá trị cho các TextBox
                txtMaSP.Text = str[0];
                txtTenSP.Text = str[1];
                txtBoNho.Text = str[2];
                txtRam.Text = str[3];
                txtDonGia.Text = str[4];

                // Xử lý số lượng
                if (int.TryParse(str[5], out int soLuongMoi))
                {
                    soluong = soLuongMoi;
                }
                else
                {
                    MessageBox.Show("Số lượng sản phẩm không hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void InsertHd()
        {
            Login frmDangnhap = new Login();
            int tongtien;
            if (!int.TryParse(txtThanhTien.Text, out tongtien))
            {
                MessageBox.Show("Invalid input for total amount. Please enter a valid number.");
                return;
            }

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@mahd", txtMaHD.Text },
                { "@makh", txtMaKH.Text },
                { "@manv", Login.manv},
                { "@ngaytao", (dtpNgayMua.Value.Date) },
                { "@tongtien", tongtien }
            };

            // Gọi phương thức Insert với tên Stored Procedure và tham số
            data.Insert_Update("sp_addhd", parameters);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            AddInvoice();
            if (!string.IsNullOrEmpty(txtMaHD.Text))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (int.TryParse(item.SubItems[5].Text, out int soluong) &&
                        float.TryParse(item.SubItems[4].Text, out float dongia))
                    {
                        Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@mahd", txtMaHD.Text },
                            { "@masp", item.SubItems[0].Text },
                            { "@soluong", soluong },
                            { "@dongia", dongia }
                        };
                        data.Insert_Update("sp_addct", parameters);
                    }
                    else
                    {
                        //MessageBox.Show("Invalid input in list view items.");
                    }
                }
                MessageBox.Show("Thêm hóa đơn thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được để trống");
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            FrmAddBill frmAddBill = new FrmAddBill();
            UserName us = new UserName();

            frmAddBill.Close();
            us.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInvoice()
        {
            // Kiểm tra xem mã hóa đơn có hợp lệ không
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Mã hóa đơn không được để trống.");
                return;
            }

            // Kiểm tra xem mã khách hàng có hợp lệ không
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Mã khách hàng không được để trống.");
                return;
            }

            // Kiểm tra xem tổng tiền có hợp lệ không
            if (!float.TryParse(txtThanhTien.Text, out float totalAmount))
            {
                //MessageBox.Show("Tổng tiền không hợp lệ.");
                return;
            }

            // Tạo dictionary để chứa các tham số
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@mahd", txtMaHD.Text },
                { "@makh", txtMaKH.Text },
                { "@manv", Login.manv }, // Giả sử bạn đã có mã nhân viên
                { "@ngaytao", dtpNgayMua.Value.Date }, // Ngày tạo hóa đơn
                { "@tongtien", totalAmount }
            };

            // Gọi phương thức Insert với tên Stored Procedure và tham số
            data.Insert_Update("sp_addhd", parameters);
            MessageBox.Show("Hóa đơn đã được thêm thành công.");
        }
    }
}
