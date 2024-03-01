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
    public class Role
    {
        public List<Models.Role> getAll()
        {
            List<Models.Role> userList = new List<Models.Role>();
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

                        string sql = "SELECT * FROM [Role]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.Role user = new Models.Role
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                IsNhiemVu = reader.IsDBNull(reader.GetOrdinal("IsNhiemVu")) ? 0 : reader.GetInt32(reader.GetOrdinal("IsNhiemVu")),
                                RoleName = reader.IsDBNull(reader.GetOrdinal("Role")) ? string.Empty : reader["Role"].ToString(),
                                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? string.Empty : reader["Name"].ToString(),
                                ThoiHan = reader.IsDBNull(reader.GetOrdinal("ThoiHan")) ? null : reader.GetDateTime(reader.GetOrdinal("ThoiHan")),
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


        public bool UpdateRole(Models.Role role)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "UPDATE [Role] SET Role = @Role, Name = @Name, ThoiHan = @ThoiHan, Status = @Status WHERE Id = @Id";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Role", role.RoleName);
                    command.Parameters.AddWithValue("@Name", role.Name);
                    command.Parameters.AddWithValue("@ThoiHan", (object)role.ThoiHan ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Status", role.Status);
                    command.Parameters.AddWithValue("@Id", role.Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
                return false;
            }
        }

        public bool InsertRole(Models.Role role)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "INSERT INTO [Role] (Role, Name, ThoiHan, IsNhiemVu, Status) VALUES (@Role, @Name, @ThoiHan, @IsNhiemVu, @Status)";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Role", role.RoleName);
                    command.Parameters.AddWithValue("@IsNhiemVu", role.IsNhiemVu);
                    command.Parameters.AddWithValue("@Name", role.Name);
                    command.Parameters.AddWithValue("@ThoiHan", (object)role.ThoiHan ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Status", role.Status);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
                return false;
            }
        }



        public Models.Role getAllByName(string name)
        {
            var listAct = new Models.Role();
            try
            {
                listAct = new Role().getAll().Where(x => x.Name.Equals(name) && x.Status == 1).FirstOrDefault();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return listAct;
        }
    }
}
