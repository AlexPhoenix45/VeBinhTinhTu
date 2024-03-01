using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DAO.SqlToLinq
{
    public class UserRole
    {
        public List<Models.UserRole> GetAll()
        {
            List<Models.UserRole> userRoleList = new List<Models.UserRole>();

            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "SELECT * FROM UserRole";

                    var command = new SqlCommand(sql, conn);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Models.UserRole userRole = new Models.UserRole
                        {
                            Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                            IdUser = reader.IsDBNull(reader.GetOrdinal("IdUser")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdUser")),
                            IdRole = reader.IsDBNull(reader.GetOrdinal("IdRole")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdRole")),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? 0 : reader.GetInt32(reader.GetOrdinal("Status"))
                        };

                        userRoleList.Add(userRole);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }

            return userRoleList;
        }

        public bool Insert(Models.UserRole userRole)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "INSERT INTO UserRole (IdUser, IdRole, Status) VALUES (@IdUser, @IdRole, @Status)";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@IdUser", userRole.IdUser);
                    command.Parameters.AddWithValue("@IdRole", userRole.IdRole);
                    command.Parameters.AddWithValue("@Status", userRole.Status);

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

        public bool Update(Models.UserRole userRole)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "UPDATE UserRole SET IdUser = @IdUser, IdRole = @IdRole, Status = @Status WHERE Id = @Id";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@IdUser", userRole.IdUser);
                    command.Parameters.AddWithValue("@IdRole", userRole.IdRole);
                    command.Parameters.AddWithValue("@Status", userRole.Status);
                    command.Parameters.AddWithValue("@Id", userRole.Id);

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
    }
}
