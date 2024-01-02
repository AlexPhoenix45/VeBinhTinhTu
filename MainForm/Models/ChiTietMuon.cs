using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ChiTietMuon
    {
        public int Id { get; set; }
        public int IdPhieuMuon { get; set; }
        public int IdSach { get; set; }
        public double? TiLeHong { get; set; }
    }
}
