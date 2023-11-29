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

                        string sql = "SELECT * FROM [Users] WHERE [Status] = 1";

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
    }

}
