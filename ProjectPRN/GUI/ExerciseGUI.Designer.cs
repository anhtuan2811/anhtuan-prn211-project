
namespace ProjectPRN.GUI
{
    partial class ExerciseGUI
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
            this.btnDeleteExercise = new System.Windows.Forms.Button();
            this.btnEditExercise = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtExerciseName = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.lblSubjectsName = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.Location = new System.Drawing.Point(968, 475);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteExercise.TabIndex = 33;
            this.btnDeleteExercise.Text = "Delete";
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            this.btnDeleteExercise.Click += new System.EventHandler(this.btnDeleteExercise_Click);
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.Location = new System.Drawing.Point(968, 426);
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.Size = new System.Drawing.Size(94, 29);
            this.btnEditExercise.TabIndex = 32;
            this.btnEditExercise.Text = "Edit";
            this.btnEditExercise.UseVisualStyleBackColor = true;
            this.btnEditExercise.Click += new System.EventHandler(this.btnEditExercise_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(414, 389);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(478, 205);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(478, 205);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(70, 498);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(202, 27);
            this.txtPercentage.TabIndex = 25;
            // 
            // txtExerciseName
            // 
            this.txtExerciseName.Location = new System.Drawing.Point(70, 412);
            this.txtExerciseName.Name = "txtExerciseName";
            this.txtExerciseName.Size = new System.Drawing.Size(202, 27);
            this.txtExerciseName.TabIndex = 24;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(70, 475);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(85, 20);
            this.lblPercentage.TabIndex = 23;
            this.lblPercentage.Text = "Percentage:";
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Location = new System.Drawing.Point(70, 389);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(102, 20);
            this.lblExerciseName.TabIndex = 22;
            this.lblExerciseName.Text = "ExerciseName";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(70, 215);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(202, 27);
            this.txtSubjectName.TabIndex = 21;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(70, 118);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(202, 27);
            this.txtSubjectID.TabIndex = 20;
            // 
            // lblSubjectsName
            // 
            this.lblSubjectsName.AutoSize = true;
            this.lblSubjectsName.Location = new System.Drawing.Point(70, 192);
            this.lblSubjectsName.Name = "lblSubjectsName";
            this.lblSubjectsName.Size = new System.Drawing.Size(105, 20);
            this.lblSubjectsName.TabIndex = 19;
            this.lblSubjectsName.Text = "Subject Name:";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Location = new System.Drawing.Point(70, 95);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(73, 20);
            this.lblSubjectID.TabIndex = 18;
            this.lblSubjectID.Text = "SubjectID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Manage Exercise";
            // 
            // ExerciseGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 621);
            this.Controls.Add(this.btnDeleteExercise);
            this.Controls.Add(this.btnEditExercise);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtExerciseName);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblExerciseName);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.lblSubjectsName);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.label1);
            this.Name = "ExerciseGUI";
            this.Text = "ExerciseGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteExercise;
        private System.Windows.Forms.Button btnEditExercise;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtExerciseName;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.Label lblSubjectsName;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label label1;
    }
}