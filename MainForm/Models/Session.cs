using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Session
    {
        public static Models.Users Users { get; set; }
        public static Models.Role Role { get; set; }
        public static string RoleCode { get; set; }
        public static int IdUserInRole { get; set; }
    }
}
