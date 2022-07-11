using ProjectPRN.DataTransfer;
using ProjectPRN.Models;
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
            cpg.Show();
        }
    }
}
