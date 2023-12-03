using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sach
    {
        public int Id { get; set; }
        public string TenSach { get; set; }
        public string MoTa { get; set; }
        public string ListIdTacGia { get; set; }
        public int IdTheLoai { get; set; }
        public int IdNhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string TaiBan { get; set; }
        public int SoLuong { get; set; }
        public string NhanVienThem { get; set; }
        public string AnhDaiDien { get; set; }
        public double GiaSach { get; set; }
        public int Status { get; set; }
    }
}
