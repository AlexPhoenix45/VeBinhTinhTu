using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Action
    {
        public int Id { get; set; }
        public int IdParent { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string ActionName { get; set; }
        public int IsChucNangHien { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }
    }
}
