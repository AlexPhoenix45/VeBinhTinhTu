using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RoleAction
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public int IdAction { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }
    }
}
