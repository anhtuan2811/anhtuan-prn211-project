using ProjectPRN.DataAccess;
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
    public partial class SubjectGUI : Form
    {
        public SubjectGUI()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            txtsubjectID.Enabled = false;
            txtsubjectName.Enabled = false;
            cboMajors.Enabled = false;
            cboTeacher.Enabled = false;
            txtsemester.Enabled = false;
            loadData();
            bindData();
        }
        private void bindData()
        {
            DataTable teacher, majors;
            teacher = TeacherDAO.GetAllTeacher();
            cboTeacher.DataSource = teacher;
            cboTeacher.DisplayMember = "TeacherName";
            cboTeacher.ValueMember = "TeacherID";
            cboTeacher.SelectedIndex = 0;

            majors = MajorDAO.GetAllMajors();
            cboMajors.DataSource = majors;
            cboMajors.DisplayMember = "MajorsName";
            cboMajors.ValueMember = "MajorsID";
            cboMajors.SelectedIndex = 0;
            dataGridView1.Columns["MajorsID"].Visible = false;
            dataGridView1.Columns["TeacherID"].Visible = false;
        }

        private void loadData()
        {
            DataTable data = DAO.GetDataBySql(@"SELECT s.SubjectID, s.SubjectName,s.Semester, t.TeacherID, t.TeacherName, m.MajorsID, m.MajorsName
                         FROM Subject s INNER JOIN Teacher_Subject ts ON s.SubjectID = ts.SubjectID INNER JOIN
                         Teacher t ON ts.TeacherID = t.TeacherID INNER JOIN
                         Majors m ON s.MajorsID = m.MajorsID",null);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsubjectID.Enabled = false;
            if (e.RowIndex < 0) return;
            txtsubjectID.Text = dataGridView1.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString();
            txtsubjectName.Text = dataGridView1.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
            cboTeacher.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["TeacherID"].Value.ToString();
            cboMajors.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["MajorsID"].Value.ToString();
            txtsemester.Text = dataGridView1.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                btnAdd.Text = "Save";
                txtsubjectID.Enabled = true;
                txtsubjectName.Enabled = true;
                txtsemester.Enabled = true;
                cboMajors.Enabled = true;
                cboTeacher.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Subject]
                                                ([SubjectID]
                                                ,[SubjectName]
                                                ,[Semester]
                                                ,[MajorsID])
                                                 VALUES
                                                 (@id
                                                , @subjectname
                                                , @semester
                                                , @majorsID)");
                cmd.Parameters.AddWithValue("@id", txtsubjectID.Text);
                cmd.Parameters.AddWithValue("@subjectname", txtsubjectName.Text);
                cmd.Parameters.AddWithValue("@semester", txtsemester.Text);
                cmd.Parameters.AddWithValue("@majorsID", cboMajors.SelectedValue);
                SqlCommand cmd1 = new SqlCommand(@"INSERT INTO Teacher_Subject
                                                 ([TeacherID]
                                                 ,[SubjectID])
                                                  VALUES
                                                  (@tid
                                                 , @sid)");
                cmd1.Parameters.AddWithValue("@tid", cboTeacher.SelectedValue);
                cmd1.Parameters.AddWithValue("@sid", txtsubjectID.Text);
                if (DAO.Update(cmd) && DAO.Update(cmd1))
                    MessageBox.Show("Add success!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Add fail!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadData();
                btnAdd.Text = "Add";
                txtsubjectID.Enabled = false;
                txtsubjectName.Enabled = false;
                cboMajors.Enabled = false;
                cboTeacher.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Save";
                txtsubjectID.Enabled = false;
                txtsubjectName.Enabled = true;
                cboTeacher.Enabled = true;
                cboMajors.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE[dbo].[Subject]
                                                SET
                                                [SubjectName] = @Sname
                                                ,[Semester] = @seme
                                                ,[MajorsID] = @mID
                                                WHERE SubjectID = @SID");
                cmd.Parameters.AddWithValue("@Sname", txtsubjectName.Text);
                cmd.Parameters.AddWithValue("@seme", txtsemester.Text);
                cmd.Parameters.AddWithValue("@mID", cboMajors.SelectedValue);
                cmd.Parameters.AddWithValue("@SID", txtsubjectID.Text);

                SqlCommand cmd1 = new SqlCommand(@"UPDATE Teacher_Subject 
                                                SET
                                                [TeacherID] = @tid
                                                WHERE SubjectID = @sid");
                cmd1.Parameters.AddWithValue("@tid", cboTeacher.SelectedValue);
                cmd1.Parameters.AddWithValue("@sid", txtsubjectID.Text);
                if (DAO.Update(cmd) && DAO.Update(cmd1))
                    MessageBox.Show("edit success!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("edit fail!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadData();
                btnEdit.Text = "Edit";
                txtsubjectID.Enabled = false;
                txtsubjectName.Enabled = false;
                cboMajors.Enabled = false;
                cboTeacher.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtsubjectID.Text))
            {
                SqlCommand cmd = new SqlCommand(@"DELETE FROM Teacher_Subject
                             WHERE TeacherID=@TID and SubjectID = @SID");
                cmd.Parameters.AddWithValue("@TID", cboTeacher.SelectedValue);
                cmd.Parameters.AddWithValue("@SID", txtsubjectID.Text);

                SqlCommand cmd1 = new SqlCommand(@"DELETE FROM [dbo].[Subject]
                             WHERE SubjectID = @SID");
                cmd1.Parameters.AddWithValue("@SID", txtsubjectID.Text);

                if (DAO.Update(cmd) && DAO.Update(cmd1))
                    MessageBox.Show("delete successfully!!");
                else
                    MessageBox.Show("delete failed!!");
                loadData();
            }
            else
            {
                MessageBox.Show("Pls select a subject to delete");
                return;
            }
        }
    }
}
