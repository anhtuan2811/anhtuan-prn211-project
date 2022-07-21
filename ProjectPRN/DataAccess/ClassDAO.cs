using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataAccess
{
    class ClassDAO:DAO
    {
        public static DataTable GetClassByMajorsID(string id)
        {
            string sql = "SELECT * FROM Class WHERE MajorsID LIKE @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = id;
            DataTable dt = GetDataBySql(sql, parameter);
            if (dt.Rows.Count == 0) return null;
            return dt;
        }
        public static DataTable GetAllClass()
        {
            string sql = "SELECT * FROM Class";
            return GetDataBySql(sql, null);
        }
    }
}
