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
    public class Action
    {
        public List<Models.Action> getAll()
        {
            List<Models.Action> userList = new List<Models.Action>();
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

                        string sql = "SELECT * FROM [Action]";

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.Action user = new Models.Action
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                IdParent = reader.IsDBNull(reader.GetOrdinal("IdParent")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdParent")),
                                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? string.Empty : reader["Name"].ToString(),
                                Controller = reader.IsDBNull(reader.GetOrdinal("Controller")) ? string.Empty : reader["Controller"].ToString(),
                                ActionName = reader.IsDBNull(reader.GetOrdinal("Action")) ? string.Empty : reader["Action"].ToString(),
                                IsChucNangHien = reader.IsDBNull(reader.GetOrdinal("IsChucNangHien")) ? 0 : reader.GetInt32(reader.GetOrdinal("IsChucNangHien")),
                                CreateAt = reader.IsDBNull(reader.GetOrdinal("CreateAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("CreateAt")),
                                UpdateAt = reader.IsDBNull(reader.GetOrdinal("UpdateAt")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("UpdateAt")),
                                ViTri = reader.IsDBNull(reader.GetOrdinal("ViTri")) ? 0 : reader.GetInt32(reader.GetOrdinal("ViTri")),
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


        public List<Models.Action> getAllByIdUser()
        {
            var Acts = new DAO.SqlToLinq.Action().getByIdRole(Models.Session.Role.Id);

            // Lấy danh sách các UserRole của người dùng hiện tại
            var NhiemVu = new DAO.SqlToLinq.UserRole().GetAll().Where(x => x.IdUser == Models.Session.Users.Id && x.Status == 1).ToList();

            // Tạo danh sách tạm thời để lưu các phần tử mới
            var newActs = new List<Models.Action>();

            // Lặp qua danh sách NhiemVu để lấy ra các Action tương ứng
            foreach (var n in NhiemVu)
            {
                // Lấy Role tương ứng với UserRole
                var role = new DAO.SqlToLinq.Role().getAll().FirstOrDefault(x => x.IsNhiemVu == 1 && x.Status == 1 && (x.ThoiHan.HasValue ? x.ThoiHan.Value > DateTime.Now : true) && x.Id == n.IdRole);
                if (role != null)
                {
                    // Lấy danh sách các Action của Role và thêm vào danh sách tạm thời
                    var actions = new DAO.SqlToLinq.Action().getByIdRole(n.IdRole);
                    newActs.AddRange(actions);
                }
            }

            // Loại bỏ các phần tử trùng lặp từ danh sách Acts và danh sách mới
            var uniqueActs = Acts.Union(newActs).ToList();
            uniqueActs = uniqueActs.GroupBy(a => a.Id).Select(g => g.First()).ToList();
            uniqueActs = uniqueActs.OrderBy(x => x.ViTri).ThenBy(x => x.Id).ToList();

            return uniqueActs;
        }

        public Models.Action getById(int IdAct)
        {
            var act = new Models.Action();
            try
            {
                act = new Action().getAll().Where(x => x.Id == IdAct && x.Status == 1).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return act;
        }

        public List<Models.Action> getByIdRole(int Id)
        {
            var list = new List<Models.Action>();
            try
            {
                var listAR = new DAO.SqlToLinq.RoleAction().getAllByIdRole(Id);


                if (listAR.Count > 0)
                {
                    foreach (var x in listAR)
                    {
                        var y = new Action().getById(x.IdAction);

                        if (y != null)
                        {
                            list.Add(y);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return list;
        }

        public List<Models.Action> getSubMenuByIdAct(int IdAct, List<Models.Action> Acts)
        {
            var acts = new List<Models.Action>();
            try
            {
                acts = Acts.Where(x => x.IdParent == IdAct&& x.IsChucNangHien == 1 && x.Status == 1).ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return acts;
        }

        public bool Insert(Models.Action action)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = @"INSERT INTO [Action] (IdParent, Name, Controller, Action, IsChucNangHien, CreateAt, UpdateAt, Status) 
                           VALUES (@IdParent, @Name, @Controller, @Action, @IsChucNangHien, @CreateAt, @UpdateAt, @Status)";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@IdParent", action.IdParent);
                    command.Parameters.AddWithValue("@Name", action.Name);
                    command.Parameters.AddWithValue("@Controller", action.Controller);
                    command.Parameters.AddWithValue("@Action", action.ActionName);
                    command.Parameters.AddWithValue("@IsChucNangHien", action.IsChucNangHien);
                    command.Parameters.AddWithValue("@CreateAt", action.CreateAt);
                    command.Parameters.AddWithValue("@UpdateAt", action.UpdateAt);
                    command.Parameters.AddWithValue("@Status", action.Status);

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


        public bool Update(Models.Action action)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = @"UPDATE [Action] 
                           SET IdParent = @IdParent, Name = @Name, Controller = @Controller, 
                               Action = @Action, IsChucNangHien = @IsChucNangHien, 
                               CreateAt = @CreateAt, UpdateAt = @UpdateAt, Status = @Status
                           WHERE Id = @Id";

                    var command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@IdParent", action.IdParent);
                    command.Parameters.AddWithValue("@Name", action.Name);
                    command.Parameters.AddWithValue("@Controller", action.Controller);
                    command.Parameters.AddWithValue("@Action", action.ActionName);
                    command.Parameters.AddWithValue("@IsChucNangHien", action.IsChucNangHien);
                    command.Parameters.AddWithValue("@CreateAt", action.CreateAt);
                    command.Parameters.AddWithValue("@UpdateAt", action.UpdateAt);
                    command.Parameters.AddWithValue("@Status", action.Status);
                    command.Parameters.AddWithValue("@Id", action.Id);

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
