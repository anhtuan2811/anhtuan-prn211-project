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
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            if (Account.isAdmin != true)
            {
                markToolStripMenuItem.Visible = false;
                categoriesToolStripMenuItem.Visible = false;
                accountManagementToolStripMenuItem.Visible = false;
            }
        }
        private void embed(Panel panel, Form f)
        {
            panel.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Show();

            panel.Controls.Add(f);

        }
        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.LoginGUI lg = new LoginGUI();
            lg.Visible = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.ChangePasswordGUI cpg = new ChangePasswordGUI();
            embed(panel1, cpg);
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.AccountGUI acg = new AccountGUI();
            embed(panel1, acg);
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.SearchStudentGUI ssg = new SearchStudentGUI();
            embed(panel1, ssg);
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.StudentGUI stg = new StudentGUI();
            embed(panel1, stg);
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.TeacherGUI tg = new GUI.TeacherGUI();
            embed(panel1, tg);
        }

        private void majorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Majors_ClassGUI mc = new Majors_ClassGUI();
            embed(panel1, mc);
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.SubjectGUI sg = new SubjectGUI();
            embed(panel1, sg);
        }

        private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.ExerciseGUI exg = new ExerciseGUI();
            embed(panel1, exg);
        }

        private void studentMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.MarksGUI mg = new MarksGUI();
            embed(panel1, mg);
        }
    }
}
