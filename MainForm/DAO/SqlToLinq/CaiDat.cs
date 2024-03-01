using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SqlToLinq
{
    public class CaiDat
    {
        // Phương thức để lấy tất cả CaiDat từ cơ sở dữ liệu
        public List<Models.CaiDat> GetAll()
        {
            List<Models.CaiDat> caiDats = new List<Models.CaiDat>();

            using (SqlConnection connection = new DAO.Connection.SqlConn().Conn())
            {
                string query = "SELECT Id, IdUser, CheDoToi, DSList FROM CaiDat";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Models.CaiDat caiDat = new Models.CaiDat
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        IdUser = Convert.ToInt32(reader["IdUser"]),
                        CheDoToi = Convert.ToInt32(reader["CheDoToi"]),
                        DSList = Convert.ToInt32(reader["DSList"])
                    };
                    caiDats.Add(caiDat);
                }
            }

            return caiDats;
        }


        public Models.CaiDat getByIdUser(int id)
        {
            var x = getCheckByIdUser(id);
            if (x == null)
            {
                var cd = new Models.CaiDat();
                cd.IdUser = Models.Session.Users.Id;
                cd.DSList = 1;
                cd.CheDoToi = 0;
                if (Session.Role.Id == 1)
                {
                    cd.DSList = 0;
                }

                if (Insert(cd))
                {
                    return cd;
                }
                else
                {
                    Debug.WriteLine("Thêm cài đặt lỗi");
                    return cd;
                }
            }
            return x;
        }

        public Models.CaiDat getCheckByIdUser(int id)
        {
            var x = GetAll().Where(x => x.IdUser == id).FirstOrDefault();
            if (x == null)
            {
                return null;
            }
            return x;
        }


        // Phương thức để chèn một bản ghi CaiDat vào cơ sở dữ liệu
        public bool Insert(Models.CaiDat caiDat)
        {
            using (SqlConnection connection = new DAO.Connection.SqlConn().Conn())
            {
                string query = "INSERT INTO CaiDat (IdUser, CheDoToi, DSList) VALUES (@IdUser, @CheDoToi, @DSList)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUser", caiDat.IdUser);
                command.Parameters.AddWithValue("@CheDoToi", caiDat.CheDoToi);
                command.Parameters.AddWithValue("@DSList", caiDat.DSList);

                connection.Open();
                var x = command.ExecuteNonQuery();
                if (x > 1)
                {
                    return true;
                }
            }
            return false;
        }

        // Phương thức để cập nhật một bản ghi CaiDat trong cơ sở dữ liệu
        public bool Update(Models.CaiDat caiDat)
        {
            try
            {
                using (SqlConnection connection = new DAO.Connection.SqlConn().Conn())
                {
                    string query = "UPDATE CaiDat SET IdUser = @IdUser, CheDoToi = @CheDoToi, DSList = @DSList WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdUser", caiDat.IdUser);
                    command.Parameters.AddWithValue("@CheDoToi", caiDat.CheDoToi);
                    command.Parameters.AddWithValue("@DSList", caiDat.DSList);
                    command.Parameters.AddWithValue("@Id", caiDat.Id);

                    connection.Open();
                    var x = command.ExecuteNonQuery();
                    if (x > 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return false;
        }
    }
}
