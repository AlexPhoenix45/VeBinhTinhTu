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

        public Models.RoleAction getById(int Id)
        {
            try
            {
                var Act = new RoleAction().getAll().Where(x => x.Id == Id).FirstOrDefault();

                if (Act != null)
                {
                    return Act;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return null;
        }

        public Models.RoleAction getByIdRoleAndAction(int IdRole, int IdAction)
        {
            try
            {
                var Act = new RoleAction().getAll().Where(x => x.IdRole == IdRole && x.IdAction == IdAction && x.Status == 1).FirstOrDefault();

                if(Act != null) 
                {
                    return Act;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return null;
        }


        public int checkExist(int IdRole, int IdAction)
        {
            try
            {
                var Act = new RoleAction().getAll().Where(x => x.IdRole == IdRole && x.IdAction == IdAction).FirstOrDefault();

                if (Act != null)
                {
                    return Act.Id;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return -1;
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


        public bool Insert(Models.RoleAction roleAction)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = @"INSERT INTO [RoleAction] (IdRole, IdAction, CreateAt, UpdateAt, Status) 
                           VALUES (@IdRole, @IdAction, @CreateAt, @UpdateAt, @Status)";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@IdRole", roleAction.IdRole);
                    command.Parameters.AddWithValue("@IdAction", roleAction.IdAction);
                    command.Parameters.AddWithValue("@CreateAt", roleAction.CreateAt);
                    command.Parameters.AddWithValue("@UpdateAt", roleAction.UpdateAt);
                    command.Parameters.AddWithValue("@Status", roleAction.Status);

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

        public bool Update(Models.RoleAction roleAction)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = @"UPDATE [RoleAction] 
                           SET IdRole = @IdRole, IdAction = @IdAction, 
                               CreateAt = @CreateAt, UpdateAt = @UpdateAt, 
                               Status = @Status
                           WHERE Id = @Id";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@IdRole", roleAction.IdRole);
                    command.Parameters.AddWithValue("@IdAction", roleAction.IdAction);
                    command.Parameters.AddWithValue("@CreateAt", roleAction.CreateAt);
                    command.Parameters.AddWithValue("@UpdateAt", roleAction.UpdateAt);
                    command.Parameters.AddWithValue("@Status", roleAction.Status);
                    command.Parameters.AddWithValue("@Id", roleAction.Id);

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
