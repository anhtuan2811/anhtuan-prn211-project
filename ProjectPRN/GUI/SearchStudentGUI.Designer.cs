
namespace ProjectPRN.GUI
{
    partial class SearchStudentGUI
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMajors = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.cboMajors = new System.Windows.Forms.ComboBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Search student information by";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(45, 59);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(104, 20);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblMajors
            // 
            this.lblMajors.AutoSize = true;
            this.lblMajors.Location = new System.Drawing.Point(45, 108);
            this.lblMajors.Name = "lblMajors";
            this.lblMajors.Size = new System.Drawing.Size(54, 20);
            this.lblMajors.TabIndex = 2;
            this.lblMajors.Text = "Majors";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(45, 151);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 20);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Class";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(200, 56);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(190, 27);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // cboMajors
            // 
            this.cboMajors.FormattingEnabled = true;
            this.cboMajors.Location = new System.Drawing.Point(200, 104);
            this.cboMajors.Name = "cboMajors";
            this.cboMajors.Size = new System.Drawing.Size(190, 28);
            this.cboMajors.TabIndex = 5;
            this.cboMajors.SelectedIndexChanged += new System.EventHandler(this.cboMajors_SelectedIndexChanged);
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(200, 151);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(190, 28);
            this.cboClass.TabIndex = 6;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // SearchStudentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.cboMajors);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblMajors);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblTitle);
            this.Name = "SearchStudentGUI";
            this.Text = "SearchStudentGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMajors;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ComboBox cboMajors;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}