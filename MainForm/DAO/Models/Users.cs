using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Role { get; set; }
        public string DiaChi { get; set; }
        public string CanCuoc { get; set; }
        public DateTime NgaySinh { get; set;}
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string AnhDaiDien {  get; set; }
        public int Status { get; set; }

    }
}
