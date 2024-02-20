using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAO.SqlToLinq
{
    public class TheLoai
    {
        public List<Models.TheLoai> getAll()
        {
            List<Models.TheLoai> userList = new List<Models.TheLoai>();
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

                        string sql = "SELECT * FROM [TheLoai]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.TheLoai user = new Models.TheLoai
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                TenTheLoai = reader.IsDBNull(reader.GetOrdinal("TenTheLoai")) ? string.Empty : reader["TenTheLoai"].ToString(),
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

        public Models.TheLoai getById(int id)
        {
            var s = new Models.TheLoai();
            try
            {
                s = new TheLoai().getAll().Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return s;
        }
        public bool Insert(Models.TheLoai theLoai)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "INSERT INTO [TheLoai] (TenTheLoai, Status) VALUES (@TenTheLoai, @Status)";

                        var command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@TenTheLoai", theLoai.TenTheLoai);
                        command.Parameters.AddWithValue("@Status", theLoai.Status);
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
        public bool Update (Models.TheLoai theLoai)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if(conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    string sql = "UPDATE [TheLoai] SET TenTheLoai = @TenTheLoai, Status = @Status WHERE Id = @Id";

                    using (var command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@TenTheLoai", theLoai.TenTheLoai);
                        command.Parameters.AddWithValue("@Status", theLoai.Status);
                        command.Parameters.AddWithValue("@Id", theLoai.Id);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }catch (Exception ex)
            {
                Debug.WriteLine(ex.Message );
                return false;
            }
        }
    }  

}
