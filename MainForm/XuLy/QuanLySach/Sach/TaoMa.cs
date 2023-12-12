using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLy.QuanLySach.Sach
{
    public class TaoMa
    {
        public static string MaNgauNhien(int dodai)
        {
            string kitu = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder kituma = new StringBuilder();

            for (int i = 0; i < dodai; i++)
            {
                int index = random.Next(kitu.Length);
                kituma.Append(kitu[index]);
            }

            return kituma.ToString();
        }
    }
}
