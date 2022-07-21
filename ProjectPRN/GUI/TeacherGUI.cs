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
    public partial class TeacherGUI : Form
    {
        public TeacherGUI()
        {
            InitializeComponent();
            
        }
        private void TeacherGUI_Load(object sender, EventArgs e)
        {
            bindData();
        }
        private void bindData()
        {
            DataTable dt = TeacherDAO.GetAllTeacher();
            dataGridView1.DataSource = dt;
            dt.Columns[0].ColumnName = "TeacherID";
            dt.Columns[1].ColumnName = "TeacherName";
            dt.Columns[2].ColumnName = "Gender";
            cboGender.DisplayMember = "Gender";
            cboGender.ValueMember = "Gender";
            dt.Columns[3].ColumnName = "PhoneNumber";
            dt.Columns[4].ColumnName = "Email";
            cboGender.SelectedIndex = 0;

            txtTeacherID.Enabled = false;
            txtTeacherName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            cboGender.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                txtTeacherID.Text = dataGridView1.Rows[e.RowIndex].Cells["TeacherID"].Value.ToString();
                txtTeacherName.Text = dataGridView1.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                cboGender.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboGender_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = cboGender.SelectedItem.ToString();
                if (btnAdd.Text == "Add")
                {
                    txtTeacherID.Text = "";
                    txtTeacherName.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    btnAdd.Text = "Save";
                    txtTeacherID.Enabled = true;
                    txtTeacherName.Enabled = true;
                    txtPhone.Enabled = true;
                    txtEmail.Enabled = true;
                    cboGender.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    if (txtTeacherID.Text == "")
                    {
                        MessageBox.Show("Please enter TeacherID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtTeacherName.Text == "")
                    {
                        MessageBox.Show("Please enter TeacherName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtPhone.Text == "")
                    {
                        MessageBox.Show("Please enter phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtEmail.Text == "")
                    {
                        MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (TeacherDAO.checkTeacherExist(txtTeacherID.Text))
                        {
                            MessageBox.Show("Teacher is Existed!");
                            return;
                        }
                        Teacher t = new Teacher
                        {
                            TeacherID = txtTeacherID.Text,
                            TeacherName = txtTeacherName.Text,
                            Gender = gender,
                            PhoneNumber = txtPhone.Text,
                            Email = txtEmail.Text
                        };
                        TeacherDAO.Insert(t);
                        DataTable dt = TeacherDAO.GetAllTeacher();
                        dataGridView1.DataSource = dt;
                        dt.Columns[0].ColumnName = "TeacherID";
                        dt.Columns[1].ColumnName = "TeacherName";
                        dt.Columns[2].ColumnName = "Gender";
                        cboGender.DisplayMember = "Gender";
                        cboGender.ValueMember = "Gender";
                        dt.Columns[3].ColumnName = "PhoneNumber";
                        dt.Columns[4].ColumnName = "Email";
                        btnAdd.Text = "Add";
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        txtTeacherID.Enabled = false;
                        txtTeacherName.Enabled = false;
                        txtPhone.Enabled = false;
                        txtEmail.Enabled = false;
                        cboGender.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = cboGender.SelectedItem.ToString();
                if (btnEdit.Text == "Edit")
                {
                    if (String.IsNullOrEmpty(txtTeacherID.Text))
                    {
                        MessageBox.Show("Pls select a teacher to update information");
                        return;
                    }
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    txtTeacherID.Enabled = false;
                    txtTeacherName.Enabled = true;
                    txtPhone.Enabled = true;
                    txtEmail.Enabled = true;
                    cboGender.Enabled = true;
                    btnEdit.Text = "Save";
                }
                else
                {
                    Teacher t = new Teacher
                    {
                        TeacherID = txtTeacherID.Text,
                        TeacherName = txtTeacherName.Text,
                        Gender = gender,
                        PhoneNumber = txtPhone.Text,
                        Email = txtEmail.Text
                    };
                    TeacherDAO.Update(t);
                    DataTable dt = TeacherDAO.GetAllTeacher();
                    dataGridView1.DataSource = dt;
                    dt.Columns[0].ColumnName = "TeacherID";
                    dt.Columns[1].ColumnName = "TeacherName";
                    dt.Columns[2].ColumnName = "Gender";
                    cboGender.DisplayMember = "Gender";
                    cboGender.ValueMember = "Gender";
                    dt.Columns[3].ColumnName = "PhoneNumber";
                    dt.Columns[4].ColumnName = "Email";
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Text = "Edit";
                    txtTeacherID.Enabled = false;
                    txtTeacherName.Enabled = false;
                    txtPhone.Enabled = false;
                    txtEmail.Enabled = false;
                    cboGender.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherID = txtTeacherID.Text;
                if (String.IsNullOrEmpty(teacherID))
                {
                    MessageBox.Show("Teacher id can not empty !");
                    return;
                }
                else
                {
                    Teacher t = TeacherDAO.GetTeacherByID(teacherID);
                    DialogResult dr = MessageBox.Show(String.Format("Do you want to delete : " + teacherID), "Confirm deteting", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No) return;
                    if (TeacherDAO.checkTeacher(teacherID))
                    {
                        MessageBox.Show("Teacher is teaching a subject, can't delete!");
                        return;
                    }
                    TeacherDAO.Delete(t);
                    DataTable dt = TeacherDAO.GetAllTeacher();
                    dataGridView1.DataSource = dt;
                    dt.Columns[0].ColumnName = "TeacherID";
                    dt.Columns[1].ColumnName = "TeacherName";
                    dt.Columns[2].ColumnName = "Gender";
                    cboGender.DisplayMember = "Gender";
                    cboGender.ValueMember = "Gender";
                    dt.Columns[3].ColumnName = "PhoneNumber";
                    dt.Columns[4].ColumnName = "Email";
                }                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
