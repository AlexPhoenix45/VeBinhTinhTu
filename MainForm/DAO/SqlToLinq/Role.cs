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
                                RoleName = reader.IsDBNull(reader.GetOrdinal("Role")) ? string.Empty : reader["Role"].ToString(),
                                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? string.Empty : reader["Name"].ToString(),
                                CreateAt = reader.IsDBNull(reader.GetOrdinal("CreateAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("CreateAt")),
                                UpdateAt = reader.IsDBNull(reader.GetOrdinal("UpdateAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("UpdateAt")),
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
