namespace Student_Registration_Windows
{
    partial class Main
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
            this.btnViewStdudent = new System.Windows.Forms.Button();
            this.btnAddStduent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStduent);
            this.groupBox1.Controls.Add(this.btnViewStdudent);
            this.groupBox1.Location = new System.Drawing.Point(73, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // btnViewStdudent
            // 
            this.btnViewStdudent.Location = new System.Drawing.Point(88, 225);
            this.btnViewStdudent.Name = "btnViewStdudent";
            this.btnViewStdudent.Size = new System.Drawing.Size(204, 68);
            this.btnViewStdudent.TabIndex = 1;
            this.btnViewStdudent.Text = "View Student";
            this.btnViewStdudent.UseVisualStyleBackColor = true;
            this.btnViewStdudent.Click += new System.EventHandler(this.btnViewStdudent_Click);
            // 
            // btnAddStduent
            // 
            this.btnAddStduent.Location = new System.Drawing.Point(88, 99);
            this.btnAddStduent.Name = "btnAddStduent";
            this.btnAddStduent.Size = new System.Drawing.Size(204, 68);
            this.btnAddStduent.TabIndex = 2;
            this.btnAddStduent.Text = "Add Student";
            this.btnAddStduent.UseVisualStyleBackColor = true;
            this.btnAddStduent.Click += new System.EventHandler(this.btnAddStduent_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 470);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewStdudent;
        private System.Windows.Forms.Button btnAddStduent;
    }
}

