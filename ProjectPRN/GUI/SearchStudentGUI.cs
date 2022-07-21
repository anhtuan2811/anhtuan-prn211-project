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
    public partial class SearchStudentGUI : Form
    {
        public DataTable dt;
        public SearchStudentGUI()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            //Load data into combobox majors
            DataTable dt1 = DAO.GetDataBySql(@"SELECT * FROM [Majors]",null);
            DataRow dr = dt1.NewRow();
            dr[1] = "________All________";
            dt1.Rows.Add(dr);
            DataView dv = new DataView(dt1);
            dv.Sort = "MajorsID";
            cboMajors.DataSource = dv;
            cboMajors.DisplayMember = "MajorsName";
            cboMajors.ValueMember = "MajorsID";

            //Load data into combox class
            DataTable dt2 = DAO.GetDataBySql(@"SELECT * FROM [Class] ", null);
            DataRow dr1 = dt2.NewRow();
            dr1[2] = "________All________";
            dt2.Rows.Add(dr1);
            DataView dv1 = new DataView(dt2);
            dv1.Sort = "ClassName";
            cboClass.DataSource = dv1;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassName";
            bindData();
        }
        private void bindData()
        {
            dt = StudentDAO.GetStudentInfo();
            dataGridView1.DataSource = dt;
        }
        private void Search()
        {
            string sql = @"SELECT s.StudentID, s.StudentName, c.ClassID, c.ClassName, m.MajorsName, m.MajorsID                        
                         FROM Class c INNER JOIN Majors m ON c.MajorsID = m.MajorsID INNER JOIN Student s ON c.ClassID = s.ClassID where s.StudentName
                         LIKE N'%" + txtStudentName.Text + "%'";
            if (cboClass.SelectedIndex != 0)
            {
                sql += " and c.ClassName = '" + cboClass.SelectedValue + "'";
            }
            if (cboMajors.SelectedIndex != 0)
            {
                sql += " and m.MajorsID = '" + cboMajors.SelectedValue + "'";
            }
            dataGridView1.DataSource = DAO.GetDataBySql(sql,null);
        }

        private void cboMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = DAO.GetDataBySql(@"SELECT c.ClassID, c.ClassName, m.MajorsID FROM Class c INNER JOIN Majors m ON c.MajorsID = m.MajorsID
						 where m.MajorsID=N'" + cboMajors.SelectedValue + "'",null);
            DataRow dr1 = dt2.NewRow();
            dr1[1] = "________All__________";
            dt2.Rows.Add(dr1);
            DataView dv1 = new DataView(dt2);
            dv1.Sort = "ClassName";
            cboClass.DataSource = dv1;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassName";
            Search();
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
