using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhieuMuon
    {
        public int Id { get; set; }
        public int IdDocGia { get; set; }
        public int IdNVTaoPhieu { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenTra { get; set; }
        public DateTime? NgayHoanTatTra { get; set; }
        public float? PhiMuon { get; set; }
        public float? PhiPhatTraMuon { get; set; }
        public float? PhiPhatHongSach { get; set; }
        public string GhiChuMuon { get; set; }
        public string GhiChuTra { get; set; }
        public int? IdNVThanhToan { get; set; }
        public int? Status { get; set; }
    }

}
