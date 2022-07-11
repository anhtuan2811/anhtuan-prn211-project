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
    public partial class ChangePasswordGUI : Form
    {
        public ChangePasswordGUI()
        {
            InitializeComponent();
        }

        private void ChangePasswordGUI_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Welcome " + Account.UserName;
            txtUserName.Text = Account.UserName;
        }
    }
}
