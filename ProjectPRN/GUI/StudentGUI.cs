using ProjectPRN.DataAccess;
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
    }
}
