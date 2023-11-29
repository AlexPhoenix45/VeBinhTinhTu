using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DAO.Connection
{
    public class SqlConn
    {
        public SqlConnection Conn()
        {
            string StrConn = @"Data Source=DESKTOP-7S67ETB\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            try
            {
                SqlConnection Conn = null;
                Conn = new SqlConnection(StrConn);

                return Conn;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
            }
            return null;
        }
    }
}
