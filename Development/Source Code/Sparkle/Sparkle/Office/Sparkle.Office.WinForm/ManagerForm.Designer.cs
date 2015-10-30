namespace Sparkle.Office.WinForm
{
    partial class ManagerForm
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
            this.btnStateManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStateManagement
            // 
            this.btnStateManagement.Enabled = false;
            this.btnStateManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStateManagement.Location = new System.Drawing.Point(12, 12);
            this.btnStateManagement.Name = "btnStateManagement";
            this.btnStateManagement.Size = new System.Drawing.Size(94, 94);
            this.btnStateManagement.TabIndex = 10;
            this.btnStateManagement.Text = "State Management";
            this.btnStateManagement.UseVisualStyleBackColor = true;
            this.btnStateManagement.Click += new System.EventHandler(this.btnStateManagement_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(115, 118);
            this.Controls.Add(this.btnStateManagement);
            this.Name = "ManagerForm";
            this.Text = "Office Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStateManagement;

    }
}

