using ProjectPRN.DataAccess;
using ProjectPRN.DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "Select * From Login where Username= @u and Password= @p and Role='Admin'";
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("@u", System.Data.SqlDbType.NVarChar);
            parameter[0].Value = txtUsername.Text;
            parameter[1] = new SqlParameter("@p", System.Data.SqlDbType.NVarChar);
            parameter[1].Value = txtPassword.Text;
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            if (dt.Rows.Count > 0)
            {
                Account.UserName = txtUsername.Text;
                Account.isAdmin = true;
                MainGUI mg = new MainGUI();
                mg.Visible = true;
                this.Visible = false;
            }
            else
            {
                sql = "Select * From Login where UserName=@u and Password=@p and Role='Member'";
                SqlParameter[] parameter1 = new SqlParameter[2];
                parameter1[0] = new SqlParameter("@u", System.Data.SqlDbType.NVarChar);
                parameter1[0].Value = txtUsername.Text;
                parameter1[1] = new SqlParameter("@p", System.Data.SqlDbType.NVarChar);
                parameter1[1].Value = txtPassword.Text;
                DataTable dt2 = DAO.GetDataBySql(sql, parameter1);
                if (dt2.Rows.Count > 0)
                {
                    Account.UserName = txtUsername.Text;
                    MainGUI mg = new MainGUI();
                    mg.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Username or password sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }
    }
}
