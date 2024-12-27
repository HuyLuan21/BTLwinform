using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            if (checkuser(user))
            {
                MessageBox.Show("This account already exists",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "INSERT INTO taikhoan (tendangnhap, matkhau, quyenhan) VALUES (@user, @pass, @role)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@role", role);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!",
                                      "Success",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message,
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message,
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

    }
}
