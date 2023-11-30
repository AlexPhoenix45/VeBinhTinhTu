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
    public class NhanVien
    {
        public List<Models.NhanVien> getAll()
        {
            List<Models.NhanVien> userList = new List<Models.NhanVien>();
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

                        string sql = "SELECT * FROM [NhanVien]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.NhanVien user = new Models.NhanVien
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                IdUser = reader.IsDBNull(reader.GetOrdinal("IdUser")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdUser")),
                                MaNhanVien = reader.IsDBNull(reader.GetOrdinal("MaNhanVien")) ? string.Empty : reader["MaNhanVien"].ToString(),
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
        public Models.NhanVien getByIdUser(int id)
        {
            var dg = new NhanVien().getAll().Where(x => x.IdUser == id).FirstOrDefault();

            if (dg != null)
            {
                return dg;
            }

            return null;
        }
    }

}
