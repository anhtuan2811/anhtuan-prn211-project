using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
