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
    public partial class Majors_ClassGUI : Form
    {
        int index;
        int index1;
        public Majors_ClassGUI()
        {
            InitializeComponent();
        }


        private void Majors_ClassGUI_Load(object sender, EventArgs e)
        {
            txtMajorsID.Enabled = false;
            txtMajorsName.Enabled = false;
            txtClassID.Enabled = false;
            txtClassName.Enabled = false;
            DataTable dt = MajorDAO.GetAllMajors();
            dataGridView1.DataSource = dt;

            dataGridView1.Rows[0].Selected = true;

            string majorsid = dataGridView1.Rows[0].Cells[0].Value.ToString();
            DataTable dt2 = DAO.GetDataBySql("select ClassID, ClassName from Class where MajorsID = '" + majorsid + "'", null);
            dataGridView2.DataSource = dt2;
            txtMajorsID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtMajorsName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            if (dataGridView2.Rows.Count > 0)
            {
                txtClassID.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                txtClassName.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            }
            else
            {
                txtClassID.Text = "";
                txtClassName.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            index = e.RowIndex;
            dataGridView1.Rows[e.RowIndex].Selected = true;
            string majorsid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            DataTable dt2 = DAO.GetDataBySql("select ClassID, ClassName from class where MajorsID = '" + majorsid + "'",null);
            dataGridView2.DataSource = dt2;

            txtMajorsID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMajorsName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView2.Rows.Count > 0)
            {
                txtClassID.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                txtClassName.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            }
            else
            {
                txtClassID.Text = "";
                txtClassName.Text = "";
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            index1 = e.RowIndex;
            dataGridView2.Rows[e.RowIndex].Selected = true;
            txtClassID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtClassName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMajors_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAddMajors.Text == "Add")
                {
                    txtMajorsID.Enabled = true;
                    txtMajorsName.Enabled = true;
                    btnAddMajors.Text = "Save";
                    btnEditMajors.Enabled = false;
                    btnDeleteMajors.Enabled = false;
                    txtMajorsID.Text = "";
                    txtMajorsName.Text = "";
                }
                else
                {
                    Majors m = new Majors
                    {
                        MajorsID = txtMajorsID.Text,
                        MajorsName = txtMajorsName.Text
                    };
                    MajorDAO.Insert(m);
                    txtMajorsID.Enabled = false;
                    txtMajorsName.Enabled = false;
                    btnAddMajors.Text = "Add";
                    btnEditMajors.Enabled = true;
                    btnDeleteMajors.Enabled = true;

                    DataTable dt = MajorDAO.GetAllMajors();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Rows[0].Selected = true;
                    string majorsid = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    DataTable dt2 = DAO.GetDataBySql("select ClassID, ClassName from class where MajorsID = '" + majorsid + "'", null);
                    dataGridView2.DataSource = dt2;
                    txtMajorsID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txtMajorsName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    if (dataGridView2.Rows.Count > 0)
                    {
                        txtClassID.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        txtClassName.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                    }
                    else
                    {
                        txtClassID.Text = "";
                        txtClassName.Text = "";
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditMajors_Click(object sender, EventArgs e)
        {
            if (btnEditMajors.Text == "Edit")
            {
                txtMajorsName.Enabled = true;
                btnEditMajors.Text = "Save";
                btnAddMajors.Enabled = false;
                btnDeleteMajors.Enabled = false;
            }
            else
            {
                Majors m = new Majors
                {
                    MajorsID = txtMajorsID.Text,
                    MajorsName = txtMajorsName.Text
                };
                MajorDAO.Update(m);
                txtMajorsName.Enabled = false;
                btnEditMajors.Text = "Edit";
                btnAddMajors.Enabled = true;
                btnDeleteMajors.Enabled = true;

                DataTable dt = MajorDAO.GetAllMajors();
                dataGridView1.DataSource = dt;

                dataGridView1.Rows[index].Selected = true;
                string majorsid = dataGridView1.Rows[index].Cells[0].Value.ToString();
                DataTable dt2 = DAO.GetDataBySql("select ClassID, ClassName from class where MajorsID = '" + majorsid + "'", null);
                dataGridView2.DataSource = dt2;
                txtMajorsID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtMajorsName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                if (dataGridView2.Rows.Count > 0)
                {
                    txtClassID.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                    txtClassName.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                }
                else
                {
                    txtClassID.Text = "";
                    txtClassName.Text = "";
                }
            }
        }

        private void btnDeleteMajors_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            else
            {
                string majorsID = txtMajorsID.Text;
                Majors m = MajorDAO.GetMajorsByID(majorsID);
                MajorDAO.Delete(m);
                DataTable dt = MajorDAO.GetAllMajors();
                dataGridView1.DataSource = dt;
                dataGridView1.Rows[0].Selected = true;
                string majorsid = dataGridView1.Rows[0].Cells[0].Value.ToString();
                DataTable dt2 = DAO.GetDataBySql("select ClassID, ClassName from class where MajorsID = '" + majorsid + "'", null);
                dataGridView2.DataSource = dt2;
                txtMajorsID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtMajorsName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                if (dataGridView2.Rows.Count > 0)
                {
                    txtClassID.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                    txtClassName.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                }
                else
                {
                    txtClassID.Text = "";
                    txtClassName.Text = "";
                }
            }
        }
    }
}

