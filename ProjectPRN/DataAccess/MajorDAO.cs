using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataAccess
{
     class MajorDAO : DAO
    {
        public static DataTable GetAllMajors()
        {
            string sql = "SELECT * FROM Majors";
            return GetDataBySql(sql, null);
        }
    }
}
