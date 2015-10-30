namespace Sparkle.Student.WinForm
{
    partial class Menu
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
            this.btnAttendenceManagement = new System.Windows.Forms.Button();
            this.btnStudentInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAttendenceManagement
            // 
            this.btnAttendenceManagement.Enabled = false;
            this.btnAttendenceManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendenceManagement.Location = new System.Drawing.Point(112, 12);
            this.btnAttendenceManagement.Name = "btnAttendenceManagement";
            this.btnAttendenceManagement.Size = new System.Drawing.Size(94, 94);
            this.btnAttendenceManagement.TabIndex = 2;
            this.btnAttendenceManagement.Text = "Attendence Management";
            this.btnAttendenceManagement.UseVisualStyleBackColor = true;
            this.btnAttendenceManagement.Click += new System.EventHandler(this.btnAttendenceManagement_Click);
            // 
            // btnStudentInformation
            // 
            this.btnStudentInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformation.Location = new System.Drawing.Point(12, 12);
            this.btnStudentInformation.Name = "btnStudentInformation";
            this.btnStudentInformation.Size = new System.Drawing.Size(94, 94);
            this.btnStudentInformation.TabIndex = 1;
            this.btnStudentInformation.Text = "Student Information";
            this.btnStudentInformation.UseVisualStyleBackColor = true;
            this.btnStudentInformation.Click += new System.EventHandler(this.btnStudentInformation_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 118);
            this.Controls.Add(this.btnStudentInformation);
            this.Controls.Add(this.btnAttendenceManagement);
            this.Name = "ManagerForm";
            this.Text = "Student Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttendenceManagement;
        private System.Windows.Forms.Button btnStudentInformation;
    }
}