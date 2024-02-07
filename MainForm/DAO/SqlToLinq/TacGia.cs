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
    public class TacGia
    {
        public List<Models.TacGia> getAll()
        {
            List<Models.TacGia> userList = new List<Models.TacGia>();
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

                        string sql = "SELECT * FROM [TacGia]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.TacGia user = new Models.TacGia
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                TenTacGia = reader.IsDBNull(reader.GetOrdinal("TenTacGia")) ? string.Empty : reader["TenTacGia"].ToString(),
                                DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? string.Empty : reader["DiaChi"].ToString(),
                                ChucDanh = reader.IsDBNull(reader.GetOrdinal("ChucDanh")) ? string.Empty : reader["ChucDanh"].ToString(),
                                Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? 0 : reader.GetInt32(reader.GetOrdinal("Status"))

                            };

                            userList.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString() + "cho Hien");
            }
            return userList;
        }

        public Models.TacGia getById(int id)
        {
            var s = new Models.TacGia();
            try
            {
                s = new TacGia().getAll().Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return s;
        }
        public bool Insert(Models.TacGia tacGia)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "INSERT INTO TacGia (TenTacGia, DiaChi, ChucDanh, Status) VALUES (@TenTacGia, @DiaChi, @ChucDanh, @Status)";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@TenTacGia", tacGia.TenTacGia);
                    command.Parameters.AddWithValue("@DiaChi", tacGia.DiaChi);
                    command.Parameters.AddWithValue("@ChucDanh", tacGia.ChucDanh);
                    command.Parameters.AddWithValue("@Status", tacGia.Status);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString() + "cho Hien");
                return false;
            }
        }

        public bool Update(Models.TacGia tacGia)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "UPDATE TacGia SET TenTacGia = @TenTacGia, DiaChi = @DiaChi, ChucDanh = @ChucDanh, Status = @Status WHERE Id = @Id";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@TenTacGia", tacGia.TenTacGia);
                    command.Parameters.AddWithValue("@DiaChi", tacGia.DiaChi);
                    command.Parameters.AddWithValue("@ChucDanh", tacGia.ChucDanh);
                    command.Parameters.AddWithValue("@Status", tacGia.Status);
                    command.Parameters.AddWithValue("@Id", tacGia.Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    Debug.WriteLine(rowsAffected);

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + "cho Hien");
                return false;
            }
        }
    }
}
