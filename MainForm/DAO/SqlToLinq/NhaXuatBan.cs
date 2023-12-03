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
    public class NhaXuatBan
    {
        public List<Models.NhaXuatBan> getAll()
        {
            List<Models.NhaXuatBan> userList = new List<Models.NhaXuatBan>();
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

                        string sql = "SELECT * FROM [NhaXuatBan]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.NhaXuatBan user = new Models.NhaXuatBan
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                TenNhaXuatBan = reader.IsDBNull(reader.GetOrdinal("TenNhaXuatBan")) ? string.Empty : reader["TenNhaXuatBan"].ToString(),
                                DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? string.Empty : reader["DiaChi"].ToString(),
                                NgayThanhLap = reader.IsDBNull(reader.GetOrdinal("NgayThanhLap")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("NgayThanhLap")),
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
    }
}
