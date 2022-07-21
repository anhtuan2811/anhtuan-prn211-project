using ProjectPRN.DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN.DataAccess
{
    class StudentDAO:DAO
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

        public static Student GetStudentByID(string studentID)
        {
            string sql = "SELECT * FROM Student WHERE StudentID LIKE @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = studentID;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            Student st = new Student
            {
                StudentID = (string)row["StudentID"],
                StudentName = (string)row["StudentName"],
                DOB = DateTime.ParseExact((string)row["DOB"],"dd/MM/yyyy",null),
                Gender = (string)row["Gender"],
                Email = (string)row["Email"],
                Address = (string)row["Address"],
                ClassID = (string)row["ClassID"]
            };
            return st;
        }
        public static DataTable GetGender()
        {
            string sql = "SELECT DISTINCT [Gender] FROM [Student]";
            return DAO.GetDataBySql(sql, null);
        }
        public static void Insert(Student st)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Student] ([StudentID],[StudentName],[DOB],[Gender],[Email],[Address],[ClassID])" +
                                                    "VALUES(@id,@name,@DOB,@gender,@email,@address,@classID)");
            cmd.Parameters.AddWithValue("@id", st.StudentID);
            cmd.Parameters.AddWithValue("@name", st.StudentName);
            cmd.Parameters.AddWithValue("@DOB", st.DOB.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@gender", st.Gender);
            cmd.Parameters.AddWithValue("@email", st.Email);
            cmd.Parameters.AddWithValue("@address", st.Address);
            cmd.Parameters.AddWithValue("@classID", st.ClassID);
            if (Update(cmd))
                MessageBox.Show("Add new student successful!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Add new student failed!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Update(Student st)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Student]
                                                   SET [StudentName] = @name
                                                      ,[DOB] = @DOB
                                                      ,[Gender] = @gender
                                                      ,[Email] = @email
                                                      ,[Address] = @address
                                                      ,[ClassID] = @classID
                                                 WHERE StudentID LIKE @id");
            cmd.Parameters.AddWithValue("@id", st.StudentID);
            cmd.Parameters.AddWithValue("@name", st.StudentName);
            cmd.Parameters.AddWithValue("@DOB", st.DOB.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@gender", st.Gender);
            cmd.Parameters.AddWithValue("@email", st.Email);
            cmd.Parameters.AddWithValue("@address", st.Address);
            cmd.Parameters.AddWithValue("@classID", st.ClassID);
            if (Update(cmd))
                MessageBox.Show("Student update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Student update failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void Delete(Student st)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [Student_Exercise]
                                                    WHERE StudentID LIKE @id;
                                                    DELETE FROM [Student]
                                                    WHERE StudentID LIKE @id");
            cmd.Parameters.AddWithValue("@id", st.StudentID);
            if (Update(cmd))
                MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Delete fail!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
