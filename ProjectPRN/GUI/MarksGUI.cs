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
    public partial class MarksGUI : Form
    {
        DataTable dt;
        int index;
        public MarksGUI()
        {
            InitializeComponent();
            bindData();
            loadData();
        }
        private void bindData()
        {
            //combobox major
            DataTable dt3 = MajorDAO.GetAllMajors();
            DataRow dr = dt3.NewRow();
            dr[1] = "________All__________";
            dt3.Rows.Add(dr);
            DataView dv = new DataView(dt3);
            dv.Sort = "MajorsID";
            cboMajorsName.DataSource = dv;
            cboMajorsName.DisplayMember = "MajorsName";
            cboMajorsName.ValueMember = "MajorsID";
            //combox class
            DataTable dt2 = ClassDAO.GetAllClass();
            DataRow dr1 = dt2.NewRow();
            dr1[2] = "________All__________";
            dt2.Rows.Add(dr1);
            DataView dv1 = new DataView(dt2);
            dv1.Sort = "ClassName";
            cboClassName.DataSource = dv1;
            cboClassName.DisplayMember = "ClassName";
            cboClassName.ValueMember = "ClassName";
            //combox Subject
            DataTable dt4 = DAO.GetDataBySql(@"SELECT TOP (100) [SubjectID],[SubjectName] FROM [dbo].[Subject]",null);
            DataRow dr4 = dt4.NewRow();
            dr4[1] = "________All__________";
            dt4.Rows.Add(dr4);
            DataView dv4 = new DataView(dt4);
            dv4.Sort = "SubjectName";
            cboSubject.DataSource = dv4;
            cboSubject.DisplayMember = "SubjectName";
            cboSubject.ValueMember = "SubjectID";
        }
        private void loadData()
        {
            dt = DAO.GetDataBySql(@" SELECT s.StudentID, s.StudentName, c.ClassID, c.ClassName, c.MajorsID,e.ExerciseName,e.SubjectID, ex.Marks
                                      FROM Class c INNER JOIN Student s ON c.ClassID = s.ClassID inner join Student_Exercise ex on s.StudentID = ex.StudentID inner join Exercise e on e.ExerciseName = ex.ExerciseName order by StudentID asc, ExerciseName desc",null);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MajorsID"].Visible = false;
            dataGridView1.Columns["ClassID"].Visible = false;
        }
        private void search()
        {
            string sql = @"SELECT s.StudentID, s.StudentName, c.ClassID, c.ClassName, c.MajorsID,e.ExerciseName,e.SubjectID, ex.Marks FROM Class c INNER JOIN Student s ON c.ClassID = s.ClassID inner join Student_Exercise ex on s.StudentID = ex.StudentID inner join Exercise e on e.ExerciseName = ex.ExerciseName where s.StudentName like  '%%' ";

            if (cboClassName.SelectedIndex != 0)
            {
                sql += " and c.ClassName = '" + cboClassName.SelectedValue + "'";
            }
            if (cboMajorsName.SelectedIndex != 0)
            {
                sql += " and  c.MajorsID = '" + cboMajorsName.SelectedValue + "'";
            }

            if (cboSubject.SelectedIndex != 0)
            {
                sql += " and  e.SubjectID = '" + cboSubject.SelectedValue + "'";
            }
            sql += "order by StudentID asc, ExerciseName desc";
            dataGridView1.DataSource = DAO.GetDataBySql(sql,null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (e.RowIndex < 0) return;
            txtStudentName.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
            txtStudentID.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
            txtExerciseName.Text = dataGridView1.Rows[e.RowIndex].Cells["ExerciseName"].Value.ToString();
            txtMarks.Text = dataGridView1.Rows[e.RowIndex].Cells["Marks"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Save";
                txtMarks.Enabled = true;
            }
            else
            {
                if (!String.IsNullOrEmpty(txtStudentID.Text))
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Student_Exercise]
                                                SET [Marks] = @marks
                                                WHERE [StudentID]= @ID and [ExerciseName] = @exname");
                    cmd.Parameters.AddWithValue("@marks", double.Parse(txtMarks.Text));
                    cmd.Parameters.AddWithValue("@ID", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@exname", txtExerciseName.Text);
                    if (DAO.Update(cmd) && !String.IsNullOrEmpty(txtStudentID.Text))
                        MessageBox.Show("edit success!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("edit fail!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = DAO.GetDataBySql(@"SELECT s.StudentID, s.StudentName, c.ClassID, c.ClassName, c.MajorsID,e.ExerciseName,e.SubjectID, ex.Marks
                                      FROM Class c INNER JOIN Student s ON c.ClassID = s.ClassID inner join Student_Exercise ex on s.StudentID = ex.StudentID inner join Exercise e on e.ExerciseName = ex.ExerciseName order by StudentID asc, ExerciseName desc ", null);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Rows[index].Selected = true;
                    dataGridView1.Columns["MajorsID"].Visible = false;
                    dataGridView1.Columns["ClassID"].Visible = false;

                    btnEdit.Text = "Edit";
                    txtExerciseName.Enabled = false;
                    txtMarks.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Select a student to update marks");
                }
            }
                
        }

        private void cboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cboMajorsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = DAO.GetDataBySql(@"SELECT  c.ClassID, c.ClassName, m.MajorsID
                                             FROM Class c INNER JOIN
                                             Majors m ON c.MajorsID = m.MajorsID
						                     where m.MajorsID='" + cboMajorsName.SelectedValue + "'",null);
            DataRow dr1 = dt2.NewRow();
            dr1[1] = "________All__________";
            dt2.Rows.Add(dr1);
            DataView dv1 = new DataView(dt2);
            dv1.Sort = "ClassName";
            cboClassName.DataSource = dv1;
            cboClassName.DisplayMember = "ClassName";
            cboClassName.ValueMember = "ClassName";
            search();
        }
    }
}
