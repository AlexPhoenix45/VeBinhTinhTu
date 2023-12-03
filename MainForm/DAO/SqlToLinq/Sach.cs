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
    public class Sach
    {
        public List<Models.Sach> GetAll()
        {
            List<Models.Sach> sachList = new List<Models.Sach>();
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

                        string sql = "SELECT * FROM [Sach]"; // Thay [TenBangModels.Sach] bằng tên bảng thực tế trong cơ sở dữ liệu của bạn

                        var command = new SqlCommand(sql, conn);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Models.Sach sach = new Models.Sach
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                                TenSach = reader.IsDBNull(reader.GetOrdinal("TenSach")) ? string.Empty : reader["TenSach"].ToString(),
                                MoTa = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? string.Empty : reader["MoTa"].ToString(),
                                ListIdTacGia = reader.IsDBNull(reader.GetOrdinal("ListIdTacGia")) ? string.Empty : reader["ListIdTacGia"].ToString(), // Giả sử đây là một danh sách ID, bạn có thể điều chỉnh kiểu dữ liệu nếu cần thiết
                                IdTheLoai = reader.IsDBNull(reader.GetOrdinal("IdTheLoai")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdTheLoai")),
                                IdNhaXuatBan = reader.IsDBNull(reader.GetOrdinal("IdNhaXuatBan")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdNhaXuatBan")),
                                NamXuatBan = reader.IsDBNull(reader.GetOrdinal("NamXuatBan")) ? 0 : reader.GetInt32(reader.GetOrdinal("NamXuatBan")),
                                TaiBan = reader.IsDBNull(reader.GetOrdinal("TaiBan")) ? string.Empty : reader["TaiBan"].ToString(),
                                SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? 0 : reader.GetInt32(reader.GetOrdinal("SoLuong")),
                                NhanVienThem = reader.IsDBNull(reader.GetOrdinal("NhanVienThem")) ? string.Empty : reader["NhanVienThem"].ToString(),
                                AnhDaiDien = reader.IsDBNull(reader.GetOrdinal("AnhDaiDien")) ? string.Empty : reader["AnhDaiDien"].ToString(),
                                GiaSach = reader.IsDBNull(reader.GetOrdinal("GiaSach")) ? 0 : reader.GetDouble(reader.GetOrdinal("GiaSach")),
                                Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? 0 : reader.GetInt32(reader.GetOrdinal("Status"))
                            };

                            sachList.Add(sach);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return sachList;
        }


        public List<Models.Sach> TimKiem(string Ten, string moTa, string listIdTG, int? IdTL, int? IdNXB, int? NamXBTu, int? NamXBDen, int? giaTu, int? GiaDen)
        {
            var list = new List<Models.Sach>();

            try
            {
                list = new Sach().GetAll().Where(x => x.Status == 1).ToList();

                if (!string.IsNullOrEmpty(Ten))
                {
                    list = list.Where(x => x.TenSach.Contains(Ten)).ToList();
                }
                if (!string.IsNullOrEmpty(moTa))
                {
                    list = list.Where(x => x.MoTa.Contains(moTa)).ToList();
                }
                if (!string.IsNullOrEmpty(listIdTG))
                {
                    list = list.Where(x => x.ListIdTacGia.Contains(listIdTG)).ToList();
                }
                if (IdTL.HasValue && IdTL.Value != 0)
                {
                    list = list.Where(x => x.IdTheLoai == IdTL.Value).ToList();
                }
                if (IdNXB.HasValue && IdNXB.Value != 0)
                {
                    list = list.Where(x => x.IdNhaXuatBan == IdNXB.Value).ToList();
                }
                if (NamXBTu.HasValue && NamXBTu.Value != 0)
                {
                    list = list.Where(x => x.NamXuatBan >= NamXBTu.Value).ToList();
                }
                if (NamXBDen.HasValue && NamXBDen.Value != 0)
                {
                    list = list.Where(x => x.NamXuatBan <= NamXBDen.Value).ToList();
                }
                if (giaTu.HasValue && giaTu.Value != 0)
                {
                    list = list.Where(x => x.GiaSach >= giaTu.Value).ToList();
                }
                if (GiaDen.HasValue && GiaDen.Value != 0)
                {
                    list = list.Where(x => x.GiaSach <= GiaDen.Value).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return list;
        }

    }
}
