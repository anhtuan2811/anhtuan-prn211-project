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
    public partial class ChangePasswordGUI : Form
    {
        public ChangePasswordGUI()
        {
            InitializeComponent();
        }

        private void ChangePasswordGUI_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Welcome " + Account.UserName;
            txtUserName.Text = Account.UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Please fill on Password", "ChangePassword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtRepassword.Text.Trim().CompareTo(txtNewPassword.Text.Trim()) != 0)
            {
                MessageBox.Show("Re-password not match password", "ChangePassword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Login] SET [Password] = @a WHERE UserName = @b");
            cmd.Parameters.AddWithValue("@a", txtNewPassword.Text);
            cmd.Parameters.AddWithValue("@b", txtUserName.Text);
            if (DAO.Update(cmd))
                MessageBox.Show("Password change successfully!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Password change failed!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
