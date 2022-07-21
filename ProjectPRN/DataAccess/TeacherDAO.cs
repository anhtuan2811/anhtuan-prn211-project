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
    class TeacherDAO:DAO
    {
        public static DataTable GetAllTeacher()
        {
            string sql = "Select * from Teacher";
            return GetDataBySql(sql, null);
        }

        public static void Insert(Teacher t)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Teacher]
                                                   ([TeacherID]
                                                   ,[TeacherName]
                                                   ,[Gender]
                                                   ,[PhoneNumber]
                                                   ,[Email])
                                             VALUES
                                                   (@id
                                                   ,@name
                                                   ,@gender
                                                   ,@phone
                                                   ,@email)");
            cmd.Parameters.AddWithValue("@id", t.TeacherID);
            cmd.Parameters.AddWithValue("@name", t.TeacherName);
            cmd.Parameters.AddWithValue("@gender", t.Gender);
            cmd.Parameters.AddWithValue("@phone", t.PhoneNumber);
            cmd.Parameters.AddWithValue("@email", t.Email);
            if (Update(cmd))
                MessageBox.Show("Add new teacher successful!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Add new teacher failed!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Update(Teacher t)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Teacher]
                                           SET[TeacherName] = @teacherName
                                              ,[Gender] = @gender
                                              ,[PhoneNumber] = @phone
                                              ,[Email] = @email
                                           WHERE[TeacherID] = @teacherId");
            cmd.Parameters.AddWithValue("@teacherName", t.TeacherName);
            cmd.Parameters.AddWithValue("@gender", t.Gender);
            cmd.Parameters.AddWithValue("@phone", t.PhoneNumber);
            cmd.Parameters.AddWithValue("@email", t.Email);
            cmd.Parameters.AddWithValue("@teacherID", t.TeacherID);
            if (Update(cmd))
                MessageBox.Show("Teacher update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Teacher update failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(Teacher t)
        {
            SqlCommand cmd = new SqlCommand("delete from Teacher where TeacherID = @teacherID");
            cmd.Parameters.AddWithValue("@teacherID", t.TeacherID);
            if (Update(cmd))
                MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Delete fail!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Teacher GetTeacherByID(string teacherID)
        {
            string sql = "SELECT * FROM Teacher WHERE TeacherID LIKE @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = teacherID;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            Teacher t = new Teacher
            {
                TeacherID = (string)row["TeacherID"],
                TeacherName = (string)row["TeacherName"],
                Gender = (string)row["Gender"],
                PhoneNumber = (string)row["PhoneNumber"],
                Email = (string)row["Email"]             
            };
            return t;
        }
        static public bool checkTeacherExist(string teacherID)
        {
            try
            {
                string sql = "select * from teacher where TeacherID = '" + teacherID + "'";
                using (SqlConnection con = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            return true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return false;
        }

        static public bool checkTeacher(string teacherID)
        {
            try
            {
                string sql = "select * from Teacher_Subject where TeacherID = '" + teacherID + "'";
                using (SqlConnection con = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            return true;
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            return false;
        }
    }
}

