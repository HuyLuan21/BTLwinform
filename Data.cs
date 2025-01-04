using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Phone_Store
{
    internal class Data
    {
        static string conn = "Data Source=MSI\\MSI;Initial Catalog=Phonestore;Integrated Security=True";
        public void Loadrole(List<string> role)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "SELECT DISTINCT quyenhan FROM taikhoan";  // Thay đổi câu query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            role.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }
        public bool checkuser(string username)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "SELECT COUNT(1) FROM taikhoan WHERE tendangnhap = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Sử dụng tham số để tránh SQL Injection
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        // Sử dụng ExecuteScalar vì chỉ cần kiểm tra tồn tại
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi SQL
                        MessageBox.Show("Database error: " + ex.Message,
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Xử lý các lỗi khác
                        MessageBox.Show("An error occurred: " + ex.Message,
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public bool checklogin(string user, string pass, string role)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "SELECT * FROM taikhoan WHERE tendangnhap = @user AND matkhau = @pass AND quyenhan = @role";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@role", role);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool adduser(string user, string pass, string role)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (checkuser(user))
            {
                MessageBox.Show("Tai khoan nay da ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "INSERT INTO taikhoan (tendangnhap, matkhau, quyenhan) VALUES (@user, @pass, @role)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user", user.Trim());
                    command.Parameters.AddWithValue("@pass", pass.Trim());
                    command.Parameters.AddWithValue("@role", role.Trim());

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dang ky thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message,
                                        "Lỗi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message,
                                        "Lỗi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public void Select(string query, DataGridView dg)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dg.DataSource = dt;
            }
        }

        public void Insert_Update(string procName, Dictionary<string, object> parameters)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(procName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string query)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
