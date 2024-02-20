using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SqlToLinq
{
    public class Admin
    {
        public List<Models.Admin> getAll()
        {
            List<Models.Admin> userList = new List<Models.Admin>();
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

                        string sql = "SELECT * FROM [Admin]" +
                                     " JOIN Users ON Admin.IdUser = Users.Id" +
                                     " WHERE Users.Status = 1";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.Admin user = new Models.Admin
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                IdUser = reader.IsDBNull(reader.GetOrdinal("IdUser")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdUser")),
                                MaAdmin = reader.IsDBNull(reader.GetOrdinal("MaAdmin")) ? string.Empty : reader["MaAdmin"].ToString(),
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
        public Models.Admin getByIdUser(int id)
        {
            var dg = new Admin().getAll().Where(x => x.IdUser == id).FirstOrDefault();

            if (dg != null)
            {
                return dg;
            }

            return null;
        }

        public bool Insert(Models.Admin admin)
        {
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

                        string sql = "INSERT INTO [Admin] (IdUser, MaAdmin, Status) VALUES (@IdUser, @MaAdmin, @Status)";

                        var command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@IdUser", admin.IdUser);
                        command.Parameters.AddWithValue("@MaAdmin", admin.MaAdmin);
                        command.Parameters.AddWithValue("@Status", admin.Status);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Nếu có ít nhất một dòng bị ảnh hưởng (nghĩa là có dòng được chèn thành công), trả về true
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }

            // Trả về false nếu có lỗi xảy ra hoặc không có dòng nào được chèn
            return false;
        }

    }

}
