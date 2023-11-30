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
    public class RoleAction
    {
        public List<Models.RoleAction> getAll()
        {
            List<Models.RoleAction> userList = new List<Models.RoleAction>();
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

                        string sql = "SELECT * FROM [RoleAction]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.RoleAction user = new Models.RoleAction
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                IdRole = reader.IsDBNull(reader.GetOrdinal("IdRole")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdRole")),
                                IdAction = reader.IsDBNull(reader.GetOrdinal("IdAction")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdAction")),
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

        public List<Models.RoleAction> getAllByIdRole(int IdRole)
        {
            var listAct = new List<Models.RoleAction>();
            try
            {
                listAct = new RoleAction().getAll().Where(x => x.IdRole == IdRole && x.Status == 1).ToList();

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
                return listAct;
        }
    }
}
