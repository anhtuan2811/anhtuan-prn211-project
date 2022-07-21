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
    class AccountDAO : DAO
    {
        public static DataTable GetAllAccount()
        {
            string sql = "Select * from Login";
            return GetDataBySql(sql,null);
        }
        public static Login GetAccountByUsername(string userName)
        {
            string sql = "select * from Login where Username = @username";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@username", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = userName;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            Login ac = new Login
            {
                Username = (string)row["Username"],
                Password = (string)row["Password"],
                Name = (string)row["Name"],
                Gender = (string)row["Gender"],
                Role = (string)row["Role"]
            };
            return ac;
        }
        public static void Insert(Login account)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Login] ([UserName],[Password],[Name],[Gender],[Role])" + "VALUES(@Username,@Password,@Name,@Gender,@Role)");
            cmd.Parameters.AddWithValue("@Username", account.Username);
            cmd.Parameters.AddWithValue("@Password", account.Password);
            cmd.Parameters.AddWithValue("@Name", account.Name);
            cmd.Parameters.AddWithValue("@Gender", account.Gender);
            cmd.Parameters.AddWithValue("@Role", account.Role);
            if (Update(cmd))
                MessageBox.Show("Add new account successful!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Add new account failed!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Delete(Login account)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Login] WHERE [UserName] = @Username");
            cmd.Parameters.AddWithValue("@Username", account.Username);
            if (Update(cmd))
                MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Delete fail!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Update(Login account)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Login] SET [Name] = @Name,[Gender] = @Gender,[Role] = @Role WHERE [UserName] = @Username");
            cmd.Parameters.AddWithValue("@Name", account.Name);
            cmd.Parameters.AddWithValue("@Gender", account.Gender);
            cmd.Parameters.AddWithValue("@Role", account.Role);
            cmd.Parameters.AddWithValue("@Username", account.Username);
            if (Update(cmd))
                MessageBox.Show("Account update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Account update failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }


