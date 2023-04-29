using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.DTO;
using QL_CaPhe.DAL.QL_CaPheTableAdapters;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_CaPhe.DAL
{
    public class ChucVuDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KTO7CR4\MAYA0;Initial Catalog=QL_CaPhe;Integrated Security=True");
        public string Insert(string macv, string tencv)
        {

            conn.Open();
            string sql = "";
            SqlCommand cmd;
            sql = "insert into chucvu values('" + macv + "', '" + tencv + "')";
            cmd = new SqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            try
            {

                if (i >= 1)
                    return "thêm thành công";
                return "không thành công";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
           
            
        }
    }
}
