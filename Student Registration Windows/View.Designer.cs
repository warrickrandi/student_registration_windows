namespace Student_Registration_Windows
{
    partial class View
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
            this.btnMainPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.STUDENTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATIONALITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(1168, 24);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(141, 38);
            this.btnMainPage.TabIndex = 0;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.gridViewStudents);
            this.groupBox1.Location = new System.Drawing.Point(21, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 646);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Students";
            // 
            // gridViewStudents
            // 
            this.gridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STUDENTID,
            this.FIRST_NAME,
            this.LAST_NAME,
            this.ADDRESS,
            this.GENDER,
            this.NIC,
            this.EMAIL,
            this.NATIONALITY,
            this.CONTACT_NO});
            this.gridViewStudents.Location = new System.Drawing.Point(6, 44);
            this.gridViewStudents.Name = "gridViewStudents";
            this.gridViewStudents.RowTemplate.Height = 24;
            this.gridViewStudents.Size = new System.Drawing.Size(1266, 477);
            this.gridViewStudents.TabIndex = 0;
            this.gridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(544, 557);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(141, 38);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // STUDENTID
            // 
            this.STUDENTID.DataPropertyName = "STUDENTID";
            this.STUDENTID.HeaderText = "Student ID";
            this.STUDENTID.Name = "STUDENTID";
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.DataPropertyName = "FIRST_NAME";
            this.FIRST_NAME.HeaderText = "First Name";
            this.FIRST_NAME.Name = "FIRST_NAME";
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.DataPropertyName = "LAST_NAME";
            this.LAST_NAME.HeaderText = "Last Name";
            this.LAST_NAME.Name = "LAST_NAME";
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Address";
            this.ADDRESS.Name = "ADDRESS";
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "GENDER";
            this.GENDER.HeaderText = "Gender";
            this.GENDER.Name = "GENDER";
            // 
            // NIC
            // 
            this.NIC.DataPropertyName = "NIC";
            this.NIC.HeaderText = "NIC";
            this.NIC.Name = "NIC";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // NATIONALITY
            // 
            this.NATIONALITY.DataPropertyName = "NATIONALITY";
            this.NATIONALITY.HeaderText = "Nationality";
            this.NATIONALITY.Name = "NATIONALITY";
            // 
            // CONTACT_NO
            // 
            this.CONTACT_NO.DataPropertyName = "CONTACT_NO";
            this.CONTACT_NO.HeaderText = "Contact No";
            this.CONTACT_NO.Name = "CONTACT_NO";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMainPage);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridViewStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATIONALITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACT_NO;
    }
}