namespace Sparkle.HR.WinForm
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
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnAttendenceManagement = new System.Windows.Forms.Button();
            this.btnLeaveManagement = new System.Windows.Forms.Button();
            this.btnPayrollManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Enabled = false;
            this.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffManagement.Location = new System.Drawing.Point(12, 12);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(94, 94);
            this.btnStaffManagement.TabIndex = 3;
            this.btnStaffManagement.Text = "Staff Management";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnAttendenceManagement
            // 
            this.btnAttendenceManagement.Enabled = false;
            this.btnAttendenceManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendenceManagement.Location = new System.Drawing.Point(112, 12);
            this.btnAttendenceManagement.Name = "btnAttendenceManagement";
            this.btnAttendenceManagement.Size = new System.Drawing.Size(94, 94);
            this.btnAttendenceManagement.TabIndex = 10;
            this.btnAttendenceManagement.Text = "Attendence Management";
            this.btnAttendenceManagement.UseVisualStyleBackColor = true;
            this.btnAttendenceManagement.Click += new System.EventHandler(this.btnAttendenceManagement_Click);
            // 
            // btnLeaveManagement
            // 
            this.btnLeaveManagement.Enabled = false;
            this.btnLeaveManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveManagement.Location = new System.Drawing.Point(212, 12);
            this.btnLeaveManagement.Name = "btnLeaveManagement";
            this.btnLeaveManagement.Size = new System.Drawing.Size(94, 94);
            this.btnLeaveManagement.TabIndex = 11;
            this.btnLeaveManagement.Text = "Leave Management";
            this.btnLeaveManagement.UseVisualStyleBackColor = true;
            this.btnLeaveManagement.Click += new System.EventHandler(this.btnLeaveManagement_Click);
            // 
            // btnPayrollManagement
            // 
            this.btnPayrollManagement.Enabled = false;
            this.btnPayrollManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayrollManagement.Location = new System.Drawing.Point(312, 12);
            this.btnPayrollManagement.Name = "btnPayrollManagement";
            this.btnPayrollManagement.Size = new System.Drawing.Size(94, 94);
            this.btnPayrollManagement.TabIndex = 12;
            this.btnPayrollManagement.Text = "Payroll Management";
            this.btnPayrollManagement.UseVisualStyleBackColor = true;
            this.btnPayrollManagement.Click += new System.EventHandler(this.btnPayrollManagement_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 116);
            this.Controls.Add(this.btnPayrollManagement);
            this.Controls.Add(this.btnLeaveManagement);
            this.Controls.Add(this.btnAttendenceManagement);
            this.Controls.Add(this.btnStaffManagement);
            this.Name = "ManagerForm";
            this.Text = "HR Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnAttendenceManagement;
        private System.Windows.Forms.Button btnLeaveManagement;
        private System.Windows.Forms.Button btnPayrollManagement;
    }
}

