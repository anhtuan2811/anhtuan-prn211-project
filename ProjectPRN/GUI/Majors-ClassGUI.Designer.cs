
namespace ProjectPRN.GUI
{
    partial class Majors_ClassGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMajorsID = new System.Windows.Forms.Label();
            this.lblMajorsName = new System.Windows.Forms.Label();
            this.txtMajorsID = new System.Windows.Forms.TextBox();
            this.txtMajorsName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddMajors = new System.Windows.Forms.Button();
            this.btnEditMajors = new System.Windows.Forms.Button();
            this.btnDeleteMajors = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.AddClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Majors/Class";
            // 
            // lblMajorsID
            // 
            this.lblMajorsID.AutoSize = true;
            this.lblMajorsID.Location = new System.Drawing.Point(33, 92);
            this.lblMajorsID.Name = "lblMajorsID";
            this.lblMajorsID.Size = new System.Drawing.Size(69, 20);
            this.lblMajorsID.TabIndex = 1;
            this.lblMajorsID.Text = "MajorsID";
            this.lblMajorsID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMajorsName
            // 
            this.lblMajorsName.AutoSize = true;
            this.lblMajorsName.Location = new System.Drawing.Point(33, 189);
            this.lblMajorsName.Name = "lblMajorsName";
            this.lblMajorsName.Size = new System.Drawing.Size(94, 20);
            this.lblMajorsName.TabIndex = 2;
            this.lblMajorsName.Text = "MajorsName";
            // 
            // txtMajorsID
            // 
            this.txtMajorsID.Location = new System.Drawing.Point(33, 115);
            this.txtMajorsID.Name = "txtMajorsID";
            this.txtMajorsID.Size = new System.Drawing.Size(202, 27);
            this.txtMajorsID.TabIndex = 3;
            // 
            // txtMajorsName
            // 
            this.txtMajorsName.Location = new System.Drawing.Point(33, 212);
            this.txtMajorsName.Name = "txtMajorsName";
            this.txtMajorsName.Size = new System.Drawing.Size(202, 27);
            this.txtMajorsName.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(33, 495);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(202, 27);
            this.txtClassName.TabIndex = 8;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(33, 409);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(202, 27);
            this.txtClassID.TabIndex = 7;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(33, 472);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(82, 20);
            this.lblClassName.TabIndex = 6;
            this.lblClassName.Text = "ClassName";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(33, 386);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(57, 20);
            this.lblClassID.TabIndex = 5;
            this.lblClassID.Text = "ClassID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(478, 205);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(377, 386);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(478, 205);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnAddMajors
            // 
            this.btnAddMajors.Location = new System.Drawing.Point(931, 146);
            this.btnAddMajors.Name = "btnAddMajors";
            this.btnAddMajors.Size = new System.Drawing.Size(94, 29);
            this.btnAddMajors.TabIndex = 11;
            this.btnAddMajors.Text = "Add";
            this.btnAddMajors.UseVisualStyleBackColor = true;
            this.btnAddMajors.Click += new System.EventHandler(this.btnAddMajors_Click);
            // 
            // btnEditMajors
            // 
            this.btnEditMajors.Location = new System.Drawing.Point(931, 198);
            this.btnEditMajors.Name = "btnEditMajors";
            this.btnEditMajors.Size = new System.Drawing.Size(94, 29);
            this.btnEditMajors.TabIndex = 12;
            this.btnEditMajors.Text = "Edit";
            this.btnEditMajors.UseVisualStyleBackColor = true;
            this.btnEditMajors.Click += new System.EventHandler(this.btnEditMajors_Click);
            // 
            // btnDeleteMajors
            // 
            this.btnDeleteMajors.Location = new System.Drawing.Point(931, 248);
            this.btnDeleteMajors.Name = "btnDeleteMajors";
            this.btnDeleteMajors.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteMajors.TabIndex = 13;
            this.btnDeleteMajors.Text = "Delete";
            this.btnDeleteMajors.UseVisualStyleBackColor = true;
            this.btnDeleteMajors.Click += new System.EventHandler(this.btnDeleteMajors_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(931, 522);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteClass.TabIndex = 16;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(931, 472);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(94, 29);
            this.btnEditClass.TabIndex = 15;
            this.btnEditClass.Text = "Edit";
            this.btnEditClass.UseVisualStyleBackColor = true;
            // 
            // AddClass
            // 
            this.AddClass.Location = new System.Drawing.Point(931, 420);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(94, 29);
            this.AddClass.TabIndex = 14;
            this.AddClass.Text = "Add";
            this.AddClass.UseVisualStyleBackColor = true;
            // 
            // Majors_ClassGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 621);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.AddClass);
            this.Controls.Add(this.btnDeleteMajors);
            this.Controls.Add(this.btnEditMajors);
            this.Controls.Add(this.btnAddMajors);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.txtMajorsName);
            this.Controls.Add(this.txtMajorsID);
            this.Controls.Add(this.lblMajorsName);
            this.Controls.Add(this.lblMajorsID);
            this.Controls.Add(this.label1);
            this.Name = "Majors_ClassGUI";
            this.Text = "Majors_ClassGUI";
            this.Load += new System.EventHandler(this.Majors_ClassGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMajorsID;
        private System.Windows.Forms.Label lblMajorsName;
        private System.Windows.Forms.TextBox txtMajorsID;
        private System.Windows.Forms.TextBox txtMajorsName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAddMajors;
        private System.Windows.Forms.Button btnEditMajors;
        private System.Windows.Forms.Button btnDeleteMajors;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button AddClass;
    }
}