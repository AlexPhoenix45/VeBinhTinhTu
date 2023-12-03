using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NhaXuatBan
    {
        public int Id { get; set; }
        public string TenNhaXuatBan { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayThanhLap { get; set; }
        public int Status { get; set; }

    }
}
