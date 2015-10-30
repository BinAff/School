namespace Sparkle.Examination.Winform
{
    partial class ManagementForm
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
            this.btnQuestionSetter = new System.Windows.Forms.Button();
            this.btnResultManagement = new System.Windows.Forms.Button();
            this.btnExaminationCalander = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestionSetter
            // 
            this.btnQuestionSetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionSetter.Location = new System.Drawing.Point(12, 12);
            this.btnQuestionSetter.Name = "btnQuestionSetter";
            this.btnQuestionSetter.Size = new System.Drawing.Size(94, 94);
            this.btnQuestionSetter.TabIndex = 14;
            this.btnQuestionSetter.Text = "Question Setter";
            this.btnQuestionSetter.UseVisualStyleBackColor = true;
            // 
            // btnResultManagement
            // 
            this.btnResultManagement.Enabled = false;
            this.btnResultManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultManagement.Location = new System.Drawing.Point(112, 12);
            this.btnResultManagement.Name = "btnResultManagement";
            this.btnResultManagement.Size = new System.Drawing.Size(94, 94);
            this.btnResultManagement.TabIndex = 15;
            this.btnResultManagement.Text = "Result Management";
            this.btnResultManagement.UseVisualStyleBackColor = true;
            // 
            // btnExaminationCalander
            // 
            this.btnExaminationCalander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminationCalander.Location = new System.Drawing.Point(212, 12);
            this.btnExaminationCalander.Name = "btnExaminationCalander";
            this.btnExaminationCalander.Size = new System.Drawing.Size(94, 94);
            this.btnExaminationCalander.TabIndex = 16;
            this.btnExaminationCalander.Text = "Examination Calander";
            this.btnExaminationCalander.UseVisualStyleBackColor = true;
            // 
            // ExaminationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.btnExaminationCalander);
            this.Controls.Add(this.btnResultManagement);
            this.Controls.Add(this.btnQuestionSetter);
            this.Name = "ExaminationManagementForm";
            this.Text = "Examination Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionSetter;
        private System.Windows.Forms.Button btnResultManagement;
        private System.Windows.Forms.Button btnExaminationCalander;
    }
}

