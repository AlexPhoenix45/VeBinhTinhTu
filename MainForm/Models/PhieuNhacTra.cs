using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhieuNhacTra
    {
        public int Id { get; set; }
        public int IdPhieuMuon { get; set; }
        public int SoNgayMuon { get; set; }
        public int SoNgayPhat { get; set; }
        public double PhiMuon { get; set; }
        public double PhiPhat { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
