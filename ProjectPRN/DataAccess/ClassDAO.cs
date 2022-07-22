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
        public static Class GetClasssByID(string classID)
        {
            string sql = "SELECT * FROM Class WHERE ClassID LIKE @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = classID;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            Class c = new Class
            {
                ClassID = (string)row["ClassID"],
                MajorsID = (string)row["MajorsID"],
                ClassName = (string)row["ClassName"]
            };
            return c;
        }
        public static void Insert(Class c)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Class]
           ([ClassID]
           ,[MajorsID]
           ,[ClassName])
            VALUES
           (@a
           ,@b
           ,@c)");
            cmd.Parameters.AddWithValue("@a", c.ClassID);
            cmd.Parameters.AddWithValue("@b", c.MajorsID);
            cmd.Parameters.AddWithValue("@c", c.ClassName);
            if (Update(cmd))
                MessageBox.Show("Add new class successful!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Add new class failed!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Update(Class c)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Class]
                SET [ClassName] = @a
                WHERE ClassID = @b");
            cmd.Parameters.AddWithValue("@b", c.ClassID);
            cmd.Parameters.AddWithValue("@a", c.ClassName);
            if (Update(cmd))
                MessageBox.Show("Class update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Class update failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Delete(Class c)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Class]
                                            WHERE ClassID = @c");
            cmd.Parameters.AddWithValue("@c", c.ClassID);
            if (Update(cmd))
                MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Delete fail!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
