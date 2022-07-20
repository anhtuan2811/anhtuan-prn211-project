using ProjectPRN.DataAccess;
using ProjectPRN.DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN.GUI
{
    public partial class AccountGUI : Form
    {
        public int index;
        public AccountGUI()
        {
            InitializeComponent();
            dataGridView1.DataSource = AccountDAO.GetAllAccount();
            hide();
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void hide()
        {
            txtName.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            cboRole.Enabled = false;
            cboGender.Enabled = false;
        }
        private void show()
        {
            txtName.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            cboRole.Enabled = true;
            cboGender.Enabled = true;
        }

        private void AccountGUI_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
            index = e.RowIndex;
            dataGridView1.Rows[e.RowIndex].Selected = true;
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();            
            txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboGender.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboRole.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text))
            {
                string userName = txtUserName.Text;
                Login account = AccountDAO.GetAccountByUsername(userName);
                DialogResult dr = MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
                else
                {
                    AccountDAO.Delete(account);
                    DataTable dt = AccountDAO.GetAllAccount();
                    dataGridView1.DataSource = dt;
                }
                btnRemove.Enabled = false;
            }
            else
            {
                MessageBox.Show("Can not delete, pls try again");
                return;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "Add")
                {
                    btnAdd.Text = "Save";
                    show();
                    cboGender.SelectedItem = "Nam";
                    cboRole.SelectedItem = "Member";
                }
                else
                {
                    if (txtUserName.Text.Length == 0 || txtPassword.Text.Length == 0)
                    {
                        MessageBox.Show("Tài khoản và mật khẩu là bắt buộc", "Lỗi");
                        return;
                    }
                    else
                    {
                        Login account = new Login
                        {
                            Username = txtUserName.Text,
                            Password = txtPassword.Text,
                            Name = txtName.Text,
                            Gender = cboGender.SelectedValue.ToString(),
                            Role = cboRole.SelectedValue.ToString()
                        };
                        AccountDAO.Insert(account);
                        btnAdd.Text = "Add";
                        hide();
                        dataGridView1.DataSource = AccountDAO.GetAllAccount();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "Edit")
                {
                    show();
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    btnEdit.Text = "Save";
                    btnAdd.Enabled = false;
                    btnRemove.Enabled = false;
                }
                else
                {
                    Login account = new Login
                    {
                        Username = txtUserName.Text,
                        Password = txtPassword.Text,
                        Name = txtName.Text,
                        Gender = cboGender.SelectedValue.ToString(),
                        Role = cboRole.SelectedValue.ToString()
                    };
                    AccountDAO.Update(account);
                    dataGridView1.DataSource = AccountDAO.GetAllAccount();
                    dataGridView1.Rows[index].Selected = true;
                    btnAdd.Enabled = true;
                    btnRemove.Enabled = true;
                    btnEdit.Text = "Edit";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    
