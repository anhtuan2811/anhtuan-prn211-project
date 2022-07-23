
namespace ProjectPRN.GUI
{
    partial class MarksGUI
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
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.cboMajorsName = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblMajorsName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtExerciseName = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
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
            this.lblTitle.Location = new System.Drawing.Point(455, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Marks Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSubject);
            this.groupBox1.Controls.Add(this.cboClassName);
            this.groupBox1.Controls.Add(this.cboMajorsName);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.lblMajorsName);
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(126, 113);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(226, 28);
            this.cboSubject.TabIndex = 5;
            this.cboSubject.SelectedIndexChanged += new System.EventHandler(this.cboSubject_SelectedIndexChanged);
            // 
            // cboClassName
            // 
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(126, 71);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(226, 28);
            this.cboClassName.TabIndex = 4;
            this.cboClassName.SelectedIndexChanged += new System.EventHandler(this.cboClassName_SelectedIndexChanged);
            // 
            // cboMajorsName
            // 
            this.cboMajorsName.FormattingEnabled = true;
            this.cboMajorsName.Location = new System.Drawing.Point(126, 31);
            this.cboMajorsName.Name = "cboMajorsName";
            this.cboMajorsName.Size = new System.Drawing.Size(226, 28);
            this.cboMajorsName.TabIndex = 3;
            this.cboMajorsName.SelectedIndexChanged += new System.EventHandler(this.cboMajorsName_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(24, 116);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(58, 20);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(24, 74);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(82, 20);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "ClassName";
            // 
            // lblMajorsName
            // 
            this.lblMajorsName.AutoSize = true;
            this.lblMajorsName.Location = new System.Drawing.Point(24, 34);
            this.lblMajorsName.Name = "lblMajorsName";
            this.lblMajorsName.Size = new System.Drawing.Size(94, 20);
            this.lblMajorsName.TabIndex = 0;
            this.lblMajorsName.Text = "MajorsName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.txtMarks);
            this.groupBox2.Controls.Add(this.txtExerciseName);
            this.groupBox2.Controls.Add(this.txtStudentName);
            this.groupBox2.Controls.Add(this.txtStudentID);
            this.groupBox2.Controls.Add(this.lblMarks);
            this.groupBox2.Controls.Add(this.lblExerciseName);
            this.groupBox2.Controls.Add(this.lblStudentName);
            this.groupBox2.Controls.Add(this.lblStudentID);
            this.groupBox2.Location = new System.Drawing.Point(571, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(288, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 27);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtMarks
            // 
            this.txtMarks.Enabled = false;
            this.txtMarks.Location = new System.Drawing.Point(135, 128);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(49, 27);
            this.txtMarks.TabIndex = 8;
            // 
            // txtExerciseName
            // 
            this.txtExerciseName.Enabled = false;
            this.txtExerciseName.Location = new System.Drawing.Point(135, 91);
            this.txtExerciseName.Name = "txtExerciseName";
            this.txtExerciseName.Size = new System.Drawing.Size(92, 27);
            this.txtExerciseName.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Location = new System.Drawing.Point(135, 57);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(201, 27);
            this.txtStudentName.TabIndex = 6;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Location = new System.Drawing.Point(135, 24);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 27);
            this.txtStudentID.TabIndex = 5;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(16, 131);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(48, 20);
            this.lblMarks.TabIndex = 4;
            this.lblMarks.Text = "Marks";
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Location = new System.Drawing.Point(5, 94);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(102, 20);
            this.lblExerciseName.TabIndex = 3;
            this.lblExerciseName.Text = "ExerciseName";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(7, 60);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(100, 20);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "StudentName";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(7, 31);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(78, 20);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "StudentID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 309);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MarksGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "MarksGUI";
            this.Text = "MarksGUI";
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
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.ComboBox cboMajorsName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblMajorsName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtExerciseName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}