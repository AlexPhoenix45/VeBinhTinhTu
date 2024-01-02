using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SqlToLinq
{
    public class PhieuNhacTra
    {
        public List<Models.PhieuNhacTra> getAll()
        {
            List<Models.PhieuNhacTra> phieuNhacTraList = new List<Models.PhieuNhacTra>();

            using (SqlConnection connection = new DAO.Connection.SqlConn().Conn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM PhieuNhacTra", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Models.PhieuNhacTra phieuNhacTra = new Models.PhieuNhacTra
                            {
                                Id = (int)reader["Id"],
                                IdPhieuMuon = (int)reader["IdPhieuMuon"],
                                SoNgayMuon = (int)reader["SoNgayMuon"],
                                SoNgayPhat = (int)reader["SoNgayPhat"],
                                PhiMuon = (double)reader["PhiMuon"],
                                PhiPhat = (double)reader["PhiPhat"],
                                NgayTao = (DateTime)reader["NgayTao"]
                            };

                            phieuNhacTraList.Add(phieuNhacTra);
                        }
                    }
                }
            }

            return phieuNhacTraList;
        }



        public Models.PhieuNhacTra getByIdPhieuMuon(int id)
        {
            var p = new Models.PhieuNhacTra();
            try
            {
                p = new PhieuNhacTra().getAll().Where(x => x.IdPhieuMuon == id).OrderByDescending(x => x.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return p;
        }


        public bool Insert(Models.PhieuNhacTra phieuNhacTra)
        {
            try
            {
                using (SqlConnection connection = new DAO.Connection.SqlConn().Conn())
                {
                    connection.Open();

                    // Sử dụng tham số để tránh tình trạng SQL injection
                    string query = "INSERT INTO PhieuNhacTra (IdPhieuMuon, SoNgayMuon, SoNgayPhat, PhiMuon, PhiPhat, NgayTao) " +
                                   "VALUES (@IdPhieuMuon, @SoNgayMuon, @SoNgayPhat, @PhiMuon, @PhiPhat, GETDATE())";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số và gán giá trị từ đối tượng PhieuNhacTra
                        command.Parameters.AddWithValue("@IdPhieuMuon", phieuNhacTra.IdPhieuMuon);
                        command.Parameters.AddWithValue("@SoNgayMuon", phieuNhacTra.SoNgayMuon);
                        command.Parameters.AddWithValue("@SoNgayPhat", phieuNhacTra.SoNgayPhat);
                        command.Parameters.AddWithValue("@PhiMuon", phieuNhacTra.PhiMuon);
                        command.Parameters.AddWithValue("@PhiPhat", phieuNhacTra.PhiPhat);

                        // Thực hiện câu lệnh SQL và trả về true nếu thành công
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần thiết
                Console.WriteLine(ex.Message);
                return false;
            }
        }


    }
}
