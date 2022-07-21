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
    public partial class StudentGUI : Form
    {
        public StudentGUI()
        {
            InitializeComponent();
            bindData();
        }
        private void bindData()
        {
            DataTable dt = MajorDAO.GetAllMajors();
            cboMajors.DataSource = dt;
            cboMajors.DisplayMember = "MajorsName";
            cboMajors.ValueMember = "MajorsID";

            DataTable dt1 = ClassDAO.GetClassByMajorsID(cboMajors.SelectedValue.ToString());
            cboClass.DataSource = dt1;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";
            cboClass.SelectedIndex = 0;

            DataTable dt2 = ClassDAO.GetAllClass();
            cboClassName.DataSource = dt2;
            cboClassName.DisplayMember = "ClassName";
            cboClassName.ValueMember = "ClassID";

            DataTable dt3 = StudentDAO.GetStudentByClassID(cboClass.SelectedValue.ToString());
            dataGridView1.DataSource = dt3;

            DataTable dt4 = StudentDAO.GetGender();
            cboGender.DataSource = dt4;
            cboGender.DisplayMember = "Gender";
            cboGender.ValueMember = "Gender";
        }

        private void cboMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = DAO.GetDataBySql("SELECT * FROM Class WHERE MajorsID LIKE N'" + cboMajors.SelectedValue + "'",null);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "________All__________";
            dt.Rows.Add(dr1);
            DataView dv1 = new DataView(dt);
            dv1.Sort = "ClassID";
            cboClass.DataSource = dt;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = StudentDAO.GetStudentByClassID(cboClass.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
            cboClassName.SelectedValue = cboClass.SelectedValue;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtStudentID.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                    txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                    dateTimePickerDOB.Value = DateTime.ParseExact(dataGridView1.Rows[e.RowIndex].Cells["DOB"].Value.ToString(), @"d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    cboGender.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                    txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                    cboClassName.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();
                    txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txtStudentID.Text;
                string studentName = txtName.Text;
                DateTime DOB = dateTimePickerDOB.Value;
                string gender = cboGender.SelectedValue.ToString();
                string address = txtAddress.Text;
                string classID = cboClassName.SelectedValue.ToString();
                string email = txtEmail.Text;
                if (String.IsNullOrEmpty(studentID) || String.IsNullOrEmpty(studentName))
                {
                    MessageBox.Show("id and name can not empty !");
                    return;
                }
                else if (DAO.GetDataBySql("SELECT StudentID FROM Student WHERE StudentID LIKE '" + studentID + "'",null).Rows.Count != 0)
                {
                    MessageBox.Show("Student already exist");
                    return;
                }
                else
                {
                    Student st = new Student
                    {
                        StudentID = studentID,
                        StudentName = studentName,
                        DOB = DOB,
                        Gender = gender,
                        Email = email,
                        Address = address,
                        ClassID = classID
                    };
                    StudentDAO.Insert(st);
                    DataTable dt = StudentDAO.GetStudentByClassID(classID);
                    dataGridView1.DataSource = dt;
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            Student s = StudentDAO.GetStudentByID(id);
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Student id can not empty !");
                return;
            }
            else if (DAO.GetDataBySql("SELECT StudentID FROM Student WHERE StudentID LIKE '" + id + "'",null).Rows.Count == 0)
            {
                MessageBox.Show("Student not found");
                return;
            }
            else
            {
                StudentDAO.Delete(s);
                DataTable dt = StudentDAO.GetStudentByClassID(cboClass.SelectedValue.ToString());
                dataGridView1.DataSource = dt;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string studentName = txtName.Text;
            DateTime DOB = dateTimePickerDOB.Value;
            string gender = cboGender.SelectedValue.ToString();
            string address = txtAddress.Text;
            string classID = cboClassName.SelectedValue.ToString();
            string email = txtEmail.Text;

            if (String.IsNullOrEmpty(studentID) || String.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Student id or name can not empty !");
                return;
            }
            else if (DAO.GetDataBySql("SELECT StudentID FROM Student WHERE StudentID LIKE '" + studentID + "'",null).Rows.Count == 0)
            {
                MessageBox.Show("Student not found");
                return;
            }
            else
            {
                Student st = new Student
                {
                    StudentID = studentID,
                    StudentName = studentName,
                    DOB = DOB,
                    Gender = gender,
                    Email = email,
                    Address = address,
                    ClassID = classID
                };
                StudentDAO.Update(st);
                DataTable dt = StudentDAO.GetStudentByClassID(classID);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
