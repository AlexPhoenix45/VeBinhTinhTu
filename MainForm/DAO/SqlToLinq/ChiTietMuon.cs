using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DAO.SqlToLinq
{
    public class ChiTietMuon
    {
        public List<Models.ChiTietMuon> getAll()
        {
            List<Models.ChiTietMuon> PhieuMuonList = new List<Models.ChiTietMuon>();
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "SELECT * FROM [ChiTietMuon]";

                    var command = new SqlCommand(sql, conn);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Models.ChiTietMuon PhieuMuon = new Models.ChiTietMuon
                        {
                            Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                            IdPhieuMuon = reader.IsDBNull(reader.GetOrdinal("IdPhieuMuon")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdPhieuMuon")),
                            IdSach = reader.IsDBNull(reader.GetOrdinal("IdSach")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdSach")),
                            TiLeHong = reader.IsDBNull(reader.GetOrdinal("TiLeHong")) ? 0 : reader.GetDouble(reader.GetOrdinal("TiLeHong"))
                        };

                        PhieuMuonList.Add(PhieuMuon);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return PhieuMuonList;
        }


        public bool UpdateAll(List<int> Id, List<double> TiLe)
        {
            try
            {
                int dem = 0;
                for (int i = 0; i < Id.Count; i++)
                {
                    if (Update(Id[i], TiLe[i]))
                    {
                        dem++;
                    }
                }
                if(dem == Id.Count)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool Update(int Id, double TiLe)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = @"
                UPDATE [ChiTietMuon] 
                SET 
                    TiLeHong = @TiLeHong
                WHERE Id = @Id";

                    var command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@TiLeHong", TiLe);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }



        public List<Models.ChiTietMuon> getByIdPhieu(int id)
        {
            var list = new List<Models.ChiTietMuon>();
            try
            {
                list = new ChiTietMuon().getAll().Where(x => x.IdPhieuMuon == id).ToList();
            }
            catch 
            {
            }
            return list;
        }

        public bool Insert(int IdP, int IdS)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = @"INSERT INTO ChiTietMuon (IdPhieuMuon, IdSach)
                                   VALUES (@IdP, @IdS)";

                    using (var command = new SqlCommand(sql, conn))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@IdP", IdP);
                        command.Parameters.AddWithValue("@IdS", IdS);
                        // ... set other parameters ...

                        // Execute the query
                        var ef = command.ExecuteNonQuery();
                        if (ef > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception as needed
                Console.WriteLine("Error inserting PhieuMuon: " + ex.Message);
            }
            return false;
        }
    }
}
