using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO.SqlToLinq
{
    public class Users
    {
        public List<Models.Users> getAll()
        {
            List<Models.Users> userList = new List<Models.Users>();
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn != null)
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string sql = "SELECT * FROM [Users]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.Users user = new Models.Users
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                TaiKhoan = reader.IsDBNull(reader.GetOrdinal("TaiKhoan")) ? string.Empty : reader["TaiKhoan"].ToString(),
                                MatKhau = reader.IsDBNull(reader.GetOrdinal("MatKhau")) ? string.Empty : reader["MatKhau"].ToString(),
                                Role = reader.IsDBNull(reader.GetOrdinal("Role")) ? string.Empty : reader["Role"].ToString(),
                                DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? string.Empty : reader["DiaChi"].ToString(),
                                CanCuoc = reader.IsDBNull(reader.GetOrdinal("CanCuoc")) ? string.Empty : reader["CanCuoc"].ToString(),
                                NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("NgaySinh")),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader["Email"].ToString(),
                                SoDienThoai = reader.IsDBNull(reader.GetOrdinal("SoDienThoai")) ? string.Empty : reader["SoDienThoai"].ToString(),
                                AnhDaiDien = reader.IsDBNull(reader.GetOrdinal("AnhDaiDien")) ? string.Empty : reader["AnhDaiDien"].ToString(),
                                Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? 0 : reader.GetInt32(reader.GetOrdinal("Status"))

                            };

                            userList.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return userList;
        }
        public List<Models.Users> timKiem()
        {
            var data = new DAO.SqlToLinq.Users().getAll();

            var list = data.Where(x => x.TaiKhoan.Contains("Minh")).ToList();

            return list;
        }

        public Models.Users getById(int Id)
        {
            var us = new Models.Users();
            try
            {
                us = new Users().getAll().Where(x => x.Id == Id && x.Status == 1).FirstOrDefault();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return us;
        }

        public int Insert(Models.Users newUser)
        {
            int newUserId = 0; // Biến để lưu trữ Id mới thêm vào

            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn != null)
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string sql = @"INSERT INTO [Users] (TaiKhoan, MatKhau, Role, Email, SoDienThoai, Status) 
                                VALUES (@TaiKhoan, @MatKhau, @Role, @Email, @SoDienThoai, @Status);
                                SELECT SCOPE_IDENTITY();"; // Sử dụng SCOPE_IDENTITY() để lấy Id của bản ghi vừa được thêm vào

                        var command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@TaiKhoan", newUser.TaiKhoan);
                        command.Parameters.AddWithValue("@MatKhau", newUser.MatKhau);
                        command.Parameters.AddWithValue("@Role", newUser.Role);
                        command.Parameters.AddWithValue("@Email", newUser.Email);
                        command.Parameters.AddWithValue("@SoDienThoai", newUser.SoDienThoai);
                        command.Parameters.AddWithValue("@Status", newUser.Status);

                        newUserId = Convert.ToInt32(command.ExecuteScalar()); // Lấy Id của bản ghi mới thêm vào
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }

            return newUserId;
        }

    }

}
