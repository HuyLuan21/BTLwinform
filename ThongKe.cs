using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace Phone_Store
{
    public partial class ThongKe : Form
    {
        Data data = new Data();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void DoanhThuNgay()
        {
            string query = "SELECT ngay, doanhThu FROM v_DoanhThuNgay ORDER BY ngay";

            int thanghientai = DateTime.Now.Month;
            int Ngay = DateTime.DaysInMonth(DateTime.Now.Year, thanghientai);

            Dictionary<int, float> doanhThuData = data.GetData(query, "ngay");

            // Tạo một dataset cho biểu đồ
            var dataset = new GunaBarDataset();
            dataset.Label = "Doanh thu theo ngày";

            for (int ngay = 1; ngay <= Ngay; ngay++)
            {
                float doanhThu = doanhThuData.ContainsKey(ngay) ? doanhThuData[ngay] : 0;
                dataset.DataPoints.Add(ngay.ToString(), doanhThu);
            }

            // Xóa dataset cũ và thêm dataset mới vào biểu đồ
            gunaChart1.Datasets.Clear();
            gunaChart1.Datasets.Add(dataset);

            // Tùy chỉnh tiêu đề biểu đồ và trục
            gunaChart1.Title.Text = "Biểu đồ Doanh thu tháng này";
            gunaChart1.Update();
        }
        private void DoanhThuThang()
        {
            string query = "SELECT thang, doanhThu FROM v_DoanhThuThang ORDER BY thang";
            Dictionary<int, float> doanhThuData = data.GetData(query, "thang");

            var dataset = new GunaBarDataset();
            dataset.Label = "Doanh thu theo tháng";

            for (int thang = 1; thang <= 12; thang++)
            {
                float doanhThu = doanhThuData.ContainsKey(thang) ? doanhThuData[thang] : 0;
                dataset.DataPoints.Add(thang.ToString(), doanhThu);
            }

            gunaChart1.Datasets.Clear();
            gunaChart1.Datasets.Add(dataset);

            gunaChart1.Title.Text = "Biểu đồ Doanh thu trong năm nay";
            gunaChart1.Update();
        }

        private void SanPhamBanChay_Thang()
        {
            string query = "select tensp from v_spbanchay_thang";
            DataTable dt = data.GetDataTable(query);
            int row = dt.Rows.Count;
            if (row > 0) txtSP1.Text = dt.Rows[0]["tensp"].ToString();
            if (row > 1) txtSP2.Text = dt.Rows[1]["tensp"].ToString();
            if (row > 2) txtSP3.Text = dt.Rows[2]["tensp"].ToString();
        }

        private void SanPhamBanChay_Nam()
        {
            string query = "select tensp from v_spbanchay_nam";
            DataTable dt = data.GetDataTable(query);
            int row = dt.Rows.Count;
            if (row > 0) txtSP1.Text = dt.Rows[0]["tensp"].ToString();
            if (row > 1) txtSP2.Text = dt.Rows[1]["tensp"].ToString();
            if (row > 2) txtSP3.Text = dt.Rows[2]["tensp"].ToString();
        }

        private void KhachHang_Thang()
        {
            string query = "select tenkh from v_khachhang_thang";
            DataTable dt = data.GetDataTable(query);
            int row = dt.Rows.Count;
            if (row > 0) txtKH1.Text = dt.Rows[0]["tenkh"].ToString();
            if (row > 1) txtKH2.Text = dt.Rows[1]["tenkh"].ToString();
            if (row > 2) txtKH3.Text = dt.Rows[2]["tenkh"].ToString();
        }

        private void KhachHang_Nam()
        {
            string query = "select tenkh from v_khachhang_nam";
            DataTable dt = data.GetDataTable(query);
            int row = dt.Rows.Count;
            if (row > 0) txtKH1.Text = dt.Rows[0]["tenkh"].ToString();
            if (row > 1) txtKH2.Text = dt.Rows[1]["tenkh"].ToString();
            if (row > 2) txtKH3.Text = dt.Rows[2]["tenkh"].ToString();
        }

        private void NhanVien_Thang()
        {
            string query = "select hoten from v_nv_thang";
            DataTable dt = data.GetDataTable(query);
            int row = dt.Rows.Count;
            if (row > 0) txtNV1.Text = dt.Rows[0]["hoten"].ToString();
            if (row > 1) txtNV2.Text = dt.Rows[1]["hoten"].ToString();
            if (row > 2) txtNV3.Text = dt.Rows[2]["hoten"].ToString();
        }
        private void NhanVien_Nam()
        {
            string query = "select hoten from v_nv_nam";
            DataTable dt = data.GetDataTable(query);
            int row = dt.Rows.Count;
            if (row > 0) txtNV1.Text = dt.Rows[0]["hoten"].ToString();
            if (row > 1) txtNV2.Text = dt.Rows[1]["hoten"].ToString();
            if (row > 2) txtNV3.Text = dt.Rows[2]["hoten"].ToString();
        }

        private void TongSP_DoanhThu_Thang()
        {
            string Query_TongSp = "select dbo.fn_tongsp_thang() AS TongSanPhamThang";
            string Query_Doanhthu = "select dbo.fn_doanhthu_thang() AS DoanhThuThang";
            txtSoLuongBan.Text = data.GetData(Query_TongSp).ToString();
            txtTongDoanhThu.Text = data.GetData(Query_Doanhthu).ToString();
        }

        private void TongSP_DoanhThu_Nam()
        {
            string Query_TongSp = "select dbo.fn_tongsp_nam() AS TongSanPhamNam";
            string Query_Doanhthu = "select dbo.fn_doanhthu_nam() AS DoanhThuNam";
            txtSoLuongBan.Text = data.GetData(Query_TongSp).ToString();
            txtTongDoanhThu.Text = data.GetData(Query_Doanhthu).ToString();
        }



        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        private void btnThang_Click(object sender, EventArgs e)
        {
            Reset();
            DoanhThuNgay();
            SanPhamBanChay_Thang();
            KhachHang_Thang();
            NhanVien_Thang();
            TongSP_DoanhThu_Thang();
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            Reset();
            DoanhThuThang();
            SanPhamBanChay_Nam();
            KhachHang_Nam();
            NhanVien_Nam();
            TongSP_DoanhThu_Nam();
        }
    }
}
