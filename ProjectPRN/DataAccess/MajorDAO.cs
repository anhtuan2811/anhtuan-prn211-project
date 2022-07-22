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
     class MajorDAO : DAO
    {
        public static DataTable GetAllMajors()
        {
            string sql = "SELECT * FROM Majors";
            return GetDataBySql(sql, null);
        }
        public static Majors GetMajorsByID(string majorsID)
        {
            string sql = "SELECT * FROM Majors WHERE MajorsID LIKE @id";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@id", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = majorsID;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            Majors m = new Majors
            {
                MajorsID = (string)row["MajorsID"],
                MajorsName = (string)row["MajorsName"]
            };
            return m;
        }
        public static void Insert(Majors m)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Majors]([MajorsID],[MajorsName])VALUES(@a,@b)");
            cmd.Parameters.AddWithValue("@a", m.MajorsID);
            cmd.Parameters.AddWithValue("@b", m.MajorsName);
            if (Update(cmd))
                MessageBox.Show("Add new majors successful!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Add new majors failed!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(Majors m)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Majors]
                                             SET [MajorsName] = @a
                                             WHERE MajorsID = @b");
            cmd.Parameters.AddWithValue("@b", m.MajorsID);
            cmd.Parameters.AddWithValue("@a", m.MajorsName);
            if (Update(cmd))
                MessageBox.Show("majors update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("majors update failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Delete(Majors m)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Majors]
            WHERE MajorsID = @m");
            cmd.Parameters.AddWithValue("@m", m.MajorsID);
            if (Update(cmd))
                MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Delete fail!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
