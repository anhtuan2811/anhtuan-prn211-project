
namespace ProjectPRN.GUI
{
    partial class SubjectGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboTeacher = new System.Windows.Forms.ComboBox();
            this.cboMajors = new System.Windows.Forms.ComboBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtsubjectName = new System.Windows.Forms.TextBox();
            this.txtsubjectID = new System.Windows.Forms.TextBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblMajorsID = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboTeacher);
            this.groupBox1.Controls.Add(this.cboMajors);
            this.groupBox1.Controls.Add(this.txtsemester);
            this.groupBox1.Controls.Add(this.txtsubjectName);
            this.groupBox1.Controls.Add(this.txtsubjectID);
            this.groupBox1.Controls.Add(this.lblTeacherName);
            this.groupBox1.Controls.Add(this.lblMajorsID);
            this.groupBox1.Controls.Add(this.lblSemester);
            this.groupBox1.Controls.Add(this.lblSubjectName);
            this.groupBox1.Controls.Add(this.lblSubjectID);
            this.groupBox1.Location = new System.Drawing.Point(23, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 46);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(118, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 46);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 46);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboTeacher
            // 
            this.cboTeacher.FormattingEnabled = true;
            this.cboTeacher.Location = new System.Drawing.Point(123, 241);
            this.cboTeacher.Name = "cboTeacher";
            this.cboTeacher.Size = new System.Drawing.Size(151, 28);
            this.cboTeacher.TabIndex = 12;
            // 
            // cboMajors
            // 
            this.cboMajors.FormattingEnabled = true;
            this.cboMajors.Location = new System.Drawing.Point(123, 197);
            this.cboMajors.Name = "cboMajors";
            this.cboMajors.Size = new System.Drawing.Size(151, 28);
            this.cboMajors.TabIndex = 11;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(123, 148);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(151, 27);
            this.txtsemester.TabIndex = 10;
            // 
            // txtsubjectName
            // 
            this.txtsubjectName.Location = new System.Drawing.Point(123, 107);
            this.txtsubjectName.Name = "txtsubjectName";
            this.txtsubjectName.Size = new System.Drawing.Size(151, 27);
            this.txtsubjectName.TabIndex = 9;
            // 
            // txtsubjectID
            // 
            this.txtsubjectID.Location = new System.Drawing.Point(123, 62);
            this.txtsubjectID.Name = "txtsubjectID";
            this.txtsubjectID.Size = new System.Drawing.Size(151, 27);
            this.txtsubjectID.TabIndex = 8;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(19, 249);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(100, 20);
            this.lblTeacherName.TabIndex = 7;
            this.lblTeacherName.Text = "TeacherName";
            // 
            // lblMajorsID
            // 
            this.lblMajorsID.AutoSize = true;
            this.lblMajorsID.Location = new System.Drawing.Point(19, 200);
            this.lblMajorsID.Name = "lblMajorsID";
            this.lblMajorsID.Size = new System.Drawing.Size(69, 20);
            this.lblMajorsID.TabIndex = 6;
            this.lblMajorsID.Text = "MajorsID";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(19, 151);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(70, 20);
            this.lblSemester.TabIndex = 5;
            this.lblSemester.Text = "Semester";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(19, 107);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(98, 20);
            this.lblSubjectName.TabIndex = 4;
            this.lblSubjectName.Text = "SubjectName";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Location = new System.Drawing.Point(19, 62);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(73, 20);
            this.lblSubjectID.TabIndex = 3;
            this.lblSubjectID.Text = "SubjectID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(741, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject Management";
            // 
            // SubjectGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectGUI";
            this.Text = "SubjectGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboTeacher;
        private System.Windows.Forms.ComboBox cboMajors;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtsubjectName;
        private System.Windows.Forms.TextBox txtsubjectID;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblMajorsID;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}