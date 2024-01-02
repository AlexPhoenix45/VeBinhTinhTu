using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SqlToLinq
{
    public class PhieuMuon
    {
        public List<Models.PhieuMuon> getAll()
        {
            List<Models.PhieuMuon> PhieuMuonList = new List<Models.PhieuMuon>();
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = "SELECT * FROM [PhieuMuon]";

                    var command = new SqlCommand(sql, conn);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Models.PhieuMuon PhieuMuon = new Models.PhieuMuon
                        {
                            Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                            IdDocGia = reader.IsDBNull(reader.GetOrdinal("IdDocGia")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdDocGia")),
                            IdNVTaoPhieu = reader.IsDBNull(reader.GetOrdinal("IdNVTaoPhieu")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdNVTaoPhieu")),
                            NgayMuon = reader.IsDBNull(reader.GetOrdinal("NgayMuon")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("NgayMuon")),
                            NgayHenTra = reader.IsDBNull(reader.GetOrdinal("NgayHenTra")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("NgayHenTra")),
                            NgayHoanTatTra = reader.IsDBNull(reader.GetOrdinal("NgayHoanTatTra")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("NgayHoanTatTra")),
                            PhiMuon = reader.IsDBNull(reader.GetOrdinal("PhiMuon")) ? (float?)null : (float?)reader.GetDouble(reader.GetOrdinal("PhiMuon")),
                            PhiPhatTraMuon = reader.IsDBNull(reader.GetOrdinal("PhiPhatTraMuon")) ? (float?)null : (float?)reader.GetDouble(reader.GetOrdinal("PhiPhatTraMuon")),
                            PhiPhatHongSach = reader.IsDBNull(reader.GetOrdinal("PhiPhatHongSach")) ? (float?)null : (float?)reader.GetDouble(reader.GetOrdinal("PhiPhatHongSach")),
                            GhiChuMuon = reader.IsDBNull(reader.GetOrdinal("GhiChuMuon")) ? string.Empty : reader.GetString(reader.GetOrdinal("GhiChuMuon")),
                            GhiChuTra = reader.IsDBNull(reader.GetOrdinal("GhiChuTra")) ? string.Empty : reader.GetString(reader.GetOrdinal("GhiChuTra")),
                            IdNVThanhToan = reader.IsDBNull(reader.GetOrdinal("IdNVThanhToan")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("IdNVThanhToan")),
                            Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Status")),
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


        public bool Update(Models.PhieuMuon updatedPhieuMuon)
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
                UPDATE [PhieuMuon] 
                SET 
                    IdDocGia = @IdDocGia,
                    IdNVTaoPhieu = @IdNVTaoPhieu,
                    NgayMuon = @NgayMuon,
                    NgayHenTra = @NgayHenTra,
                    NgayHoanTatTra = GETDATE(),
                    PhiMuon = @PhiMuon,
                    PhiPhatTraMuon = @PhiPhatTraMuon,
                    PhiPhatHongSach = @PhiPhatHongSach,
                    GhiChuMuon = @GhiChuMuon,
                    GhiChuTra = @GhiChuTra,
                    IdNVThanhToan = @IdNVThanhToan,
                    Status = @Status
                WHERE Id = @Id";

                    var command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@Id", updatedPhieuMuon.Id);
                    command.Parameters.AddWithValue("@IdDocGia", updatedPhieuMuon.IdDocGia);
                    command.Parameters.AddWithValue("@IdNVTaoPhieu", updatedPhieuMuon.IdNVTaoPhieu);
                    command.Parameters.AddWithValue("@NgayMuon", updatedPhieuMuon.NgayMuon);
                    command.Parameters.AddWithValue("@NgayHenTra", updatedPhieuMuon.NgayHenTra);
                    command.Parameters.AddWithValue("@PhiMuon", updatedPhieuMuon.PhiMuon);
                    command.Parameters.AddWithValue("@PhiPhatTraMuon", updatedPhieuMuon.PhiPhatTraMuon);
                    command.Parameters.AddWithValue("@PhiPhatHongSach", updatedPhieuMuon.PhiPhatHongSach);
                    command.Parameters.AddWithValue("@GhiChuMuon", updatedPhieuMuon.GhiChuMuon);
                    command.Parameters.AddWithValue("@GhiChuTra", updatedPhieuMuon.GhiChuTra);
                    command.Parameters.AddWithValue("@IdNVThanhToan", updatedPhieuMuon.IdNVThanhToan);
                    command.Parameters.AddWithValue("@Status", updatedPhieuMuon.Status);

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


        public Models.PhieuMuon getById(int id)
        {
            var p = new Models.PhieuMuon();
            try
            {
                p = new PhieuMuon().getAll().Where(x => x.Id == id && x.Status != -1).FirstOrDefault();
                return p;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return p;
        }
        
        public int getThongKeTaoByIdNVAndDay(int IdNV, DateTime start, DateTime end)
        {
            int tongTK = 0;

            try
            {
                var tk = new PhieuMuon().getAll().Where(x => x.IdNVTaoPhieu == IdNV 
                                                            && x.NgayMuon >= start
                                                            && x.NgayMuon <= end 
                                                            && x.Status >= 0).ToList().Count;

                tongTK = tk;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return tongTK;
        }
        public int getThongKeThanhToanByIdNVAndDay(int IdNV, DateTime start, DateTime end)
        {
            int tongTK = 0;

            try
            {
                var tk = new PhieuMuon().getAll().Where(x => x.IdNVTaoPhieu == IdNV
                                                            && x.NgayHoanTatTra >= start
                                                            && x.NgayHoanTatTra <= end
                                                            && x.Status >= 0).ToList().Count;

                tongTK = tk;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return tongTK;
        }


        public int getThongKeMuonByIdTLAndDay(int IdTL, DateTime start, DateTime end)
        {
            int tongTK = 0;

            try
            {
                var phieu = new PhieuMuon().getAll().Where(x => x.NgayMuon >= start
                                                            && x.NgayMuon <= end
                                                            && x.Status >= 0).ToList();
                var tk = 0;

                foreach (var p in phieu)
                {
                    var chiTiet = new DAO.SqlToLinq.ChiTietMuon().getByIdPhieu(p.Id).ToList();

                    foreach(var ct in chiTiet)
                    {

                        if(new DAO.SqlToLinq.Sach().getById(ct.IdSach).IdTheLoai == IdTL)
                        {
                            tk++;
                        }

                    }
                }

                tongTK = tk;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return tongTK;
        }

        public bool Insert(Models.PhieuMuon phieuMuon, List<string> lsach)
        {
            try
            {
                using (var conn = new DAO.Connection.SqlConn().Conn())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sql = @"INSERT INTO PhieuMuon (IdDocGia, IdNVTaoPhieu, NgayMuon, NgayHenTra, GhiChuMuon, Status)
                           VALUES (@IdDocGia, @IdNVTaoPhieu, GETDATE(), @NgayHenTra, @GhiChuMuon, @Status);
                           SELECT SCOPE_IDENTITY();"; // Thêm phần này để trả về Id mới

                    using (var command = new SqlCommand(sql, conn))
                    {
                        // Thiết lập tham số
                        command.Parameters.AddWithValue("@IdDocGia", phieuMuon.IdDocGia);
                        command.Parameters.AddWithValue("@IdNVTaoPhieu", phieuMuon.IdNVTaoPhieu);
                        command.Parameters.AddWithValue("@NgayHenTra", phieuMuon.NgayHenTra);
                        command.Parameters.AddWithValue("@GhiChuMuon", phieuMuon.GhiChuMuon);
                        command.Parameters.AddWithValue("@Status", phieuMuon.Status);

                        // Thực hiện câu lệnh SQL và lấy Id mới
                        int IdP = Convert.ToInt32(command.ExecuteScalar());

                        // Truy cập Id mới thêm vào
                        Debug.WriteLine("Id mới: " + IdP);

                        int dem = 0;
                        foreach (var s in lsach)
                        {
                            if (new DAO.SqlToLinq.ChiTietMuon().Insert(IdP, int.Parse(s)))
                            {
                                dem++;
                            }
                        }

                        if (dem == lsach.Count)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ theo nhu cầu
                Console.WriteLine("Lỗi khi thêm PhieuMuon: " + ex.Message);
            }
            return false;
        }

    }
}
