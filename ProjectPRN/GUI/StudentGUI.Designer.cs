
namespace ProjectPRN.GUI
{
    partial class StudentGUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboMajors = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMajors = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(454, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.cboMajors);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Controls.Add(this.lblMajors);
            this.groupBox1.Location = new System.Drawing.Point(33, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search student by";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(241, 60);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(152, 28);
            this.cboClass.TabIndex = 12;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // cboMajors
            // 
            this.cboMajors.FormattingEnabled = true;
            this.cboMajors.Location = new System.Drawing.Point(241, 20);
            this.cboMajors.Name = "cboMajors";
            this.cboMajors.Size = new System.Drawing.Size(152, 28);
            this.cboMajors.TabIndex = 11;
            this.cboMajors.SelectedIndexChanged += new System.EventHandler(this.cboMajors_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(142, 62);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(45, 20);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Class:";
            // 
            // lblMajors
            // 
            this.lblMajors.AutoSize = true;
            this.lblMajors.Location = new System.Drawing.Point(142, 23);
            this.lblMajors.Name = "lblMajors";
            this.lblMajors.Size = new System.Drawing.Size(57, 20);
            this.lblMajors.TabIndex = 0;
            this.lblMajors.Text = "Majors:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.cboClassName);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.cboGender);
            this.groupBox2.Controls.Add(this.dateTimePickerDOB);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtStudentID);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblClassName);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.lblDOB);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lblStudentID);
            this.groupBox2.Location = new System.Drawing.Point(759, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student\'s information";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(147, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 270);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 27);
            this.txtEmail.TabIndex = 13;
            // 
            // cboClassName
            // 
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(104, 231);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(204, 28);
            this.cboClassName.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 27);
            this.txtAddress.TabIndex = 11;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(104, 152);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(204, 28);
            this.cboGender.TabIndex = 10;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(104, 113);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(204, 27);
            this.dateTimePickerDOB.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 27);
            this.txtName.TabIndex = 8;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(104, 37);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(204, 27);
            this.txtStudentID.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 277);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(16, 239);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(85, 20);
            this.lblClassName.TabIndex = 5;
            this.lblClassName.Text = "ClassName:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 198);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(13, 152);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(16, 120);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(43, 20);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(13, 40);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(82, 20);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(681, 381);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // StudentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "StudentGUI";
            this.Text = "StudentGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboMajors;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMajors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}