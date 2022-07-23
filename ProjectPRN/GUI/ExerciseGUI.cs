using ProjectPRN.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN.GUI
{
    public partial class ExerciseGUI : Form
    {
        int index;
        int index1;
        public ExerciseGUI()
        {
            InitializeComponent();
            txtSubjectID.Enabled = false;
            txtSubjectName.Enabled = false;
            txtExerciseName.Enabled = false;
            txtPercentage.Enabled = false;
            DataTable dt = DAO.GetDataBySql("select * from Subject",null);
            dataGridView1.DataSource = dt;

            dataGridView1.Rows[0].Selected = true;

            string subjectid = dataGridView1.Rows[0].Cells[0].Value.ToString();
            DataTable dt2 = DAO.GetDataBySql("select ExerciseName, Percentage from Exercise where SubjectID = '" + subjectid + "'",null);
            dataGridView2.DataSource = dt2;
            txtSubjectID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtSubjectName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            if (dataGridView2.Rows.Count > 0)
            {
                txtExerciseName.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                txtPercentage.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            }
            else
            {
                txtExerciseName.Text = "";
                txtPercentage.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            index = e.RowIndex;
            dataGridView1.Rows[e.RowIndex].Selected = true;
            string subjectid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            DataTable dt2 = DAO.GetDataBySql("select ExerciseName, Percentage from Exercise where SubjectID = '" + subjectid + "'",null);
            dataGridView2.DataSource = dt2;

            txtSubjectID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSubjectName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView2.Rows.Count > 0)
            {
                txtExerciseName.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                txtPercentage.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            }
            else
            {
                txtExerciseName.Text = "";
                txtPercentage.Text = "";
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            index1 = e.RowIndex;
            dataGridView2.Rows[e.RowIndex].Selected = true;
            txtExerciseName.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPercentage.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Exercise]
                                            WHERE ExerciseName = @a");
                cmd.Parameters.AddWithValue("@a", txtExerciseName.Text);
                if (DAO.Update(cmd))
                {
                    MessageBox.Show("Delete exercise success!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string subjectid = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    DataTable dt2 = DAO.GetDataBySql("select ExerciseName, Percentage from Exercise where SubjectID = '" + subjectid + "'", null);
                    dataGridView2.DataSource = dt2;

                    if (dataGridView2.Rows.Count > 0)
                    {
                        txtExerciseName.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        txtPercentage.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                    }
                    else
                    {
                        txtExerciseName.Text = "";
                        txtPercentage.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Delete Exercise fail!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }

        private void btnEditExercise_Click(object sender, EventArgs e)
        {
            if (btnEditExercise.Text == "Edit")
            {
                txtPercentage.Enabled = true;
                btnEditExercise.Text = "Save";
                btnDeleteExercise.Enabled = false;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Exercise]
                                                 SET [Percentage] = @a
                                                 WHERE ExerciseName = @b");
                cmd.Parameters.AddWithValue("@a", txtPercentage.Text);
                cmd.Parameters.AddWithValue("@b", txtExerciseName.Text);
                if (DAO.Update(cmd))
                    MessageBox.Show("Update excercise success!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Update excercise fail!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtPercentage.Enabled = false;
                btnEditExercise.Text = "Edit";
                btnDeleteExercise.Enabled = true;

                dataGridView1.Rows[index].Selected = true;
                string subjectid = dataGridView1.Rows[index].Cells[0].Value.ToString();
                DataTable dt2 = DAO.GetDataBySql("select ExerciseName, Percentage from Exercise where SubjectID = '" + subjectid + "'",null);
                dataGridView2.DataSource = dt2;
                dataGridView2.Rows[index1].Selected = true;
                txtSubjectID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtSubjectName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                if (dataGridView2.Rows.Count > 0)
                {
                    txtExerciseName.Text = dataGridView2.Rows[index1].Cells[0].Value.ToString();
                    txtPercentage.Text = dataGridView2.Rows[index1].Cells[1].Value.ToString();
                }
                else
                {
                    txtExerciseName.Text = "";
                    txtPercentage.Text = "";
                }
            }
        }
    }
}
