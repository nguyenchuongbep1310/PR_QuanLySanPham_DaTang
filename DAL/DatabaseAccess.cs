using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class DatabaseAccess
    {
        string strConn = "Server=CHUONGNTD;Database=CSDL_QLSP;User Id=sa;pwd=123456";
        protected SqlConnection conn = null;
        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
