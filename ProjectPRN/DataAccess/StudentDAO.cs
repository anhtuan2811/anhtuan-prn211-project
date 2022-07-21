using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataAccess
{
    public class StudentDAO
    {
        public static DataTable GetStudentInfo()
        {
            string sql = "SELECT Student.StudentID, Student.StudentName, Class.ClassID, Class.ClassName, Majors.MajorsName, Majors.MajorsID FROM Class INNER JOIN Majors ON Class.MajorsID = Majors.MajorsID INNER JOIN Student ON Class.ClassID = Student.ClassID";
            return DAO.GetDataBySql(sql,null);
        }

        public static DataTable GetStudentByClassID(string classID)
        {
            string sql = "SELECT * FROM Student WHERE ClassID LIKE @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = classID;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            if (dt.Rows.Count == 0) return null;
            return dt;
        }
        public static DataTable GetGender()
        {
            string sql = "SELECT DISTINCT [Gender] FROM [Student]";
            return DAO.GetDataBySql(sql, null);
        }
    }
}
