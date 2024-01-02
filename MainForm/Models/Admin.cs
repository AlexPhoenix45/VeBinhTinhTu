using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Admin
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string MaAdmin { get; set; }
        public int Status { get; set; }
    }
}
