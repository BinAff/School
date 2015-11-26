namespace Sparkle.Office.WinForm
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
            this.btnStateManagement = new System.Windows.Forms.Button();
            this.btnCountryManagement = new System.Windows.Forms.Button();
            this.btnCasteManagement = new System.Windows.Forms.Button();
            this.btnReligionManagement = new System.Windows.Forms.Button();
            this.btnSubCasteManagement = new System.Windows.Forms.Button();
            this.btnGenderManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStateManagement
            // 
            this.btnStateManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStateManagement.Location = new System.Drawing.Point(112, 12);
            this.btnStateManagement.Name = "btnStateManagement";
            this.btnStateManagement.Size = new System.Drawing.Size(94, 94);
            this.btnStateManagement.TabIndex = 2;
            this.btnStateManagement.Text = "State Management";
            this.btnStateManagement.UseVisualStyleBackColor = true;
            this.btnStateManagement.Click += new System.EventHandler(this.btnStateManagement_Click);
            // 
            // btnCountryManagement
            // 
            this.btnCountryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountryManagement.Location = new System.Drawing.Point(12, 12);
            this.btnCountryManagement.Name = "btnCountryManagement";
            this.btnCountryManagement.Size = new System.Drawing.Size(94, 94);
            this.btnCountryManagement.TabIndex = 1;
            this.btnCountryManagement.Text = "Country Management";
            this.btnCountryManagement.UseVisualStyleBackColor = true;
            this.btnCountryManagement.Click += new System.EventHandler(this.btnCountryManagement_Click);
            // 
            // btnCasteManagement
            // 
            this.btnCasteManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasteManagement.Location = new System.Drawing.Point(212, 12);
            this.btnCasteManagement.Name = "btnCasteManagement";
            this.btnCasteManagement.Size = new System.Drawing.Size(94, 94);
            this.btnCasteManagement.TabIndex = 3;
            this.btnCasteManagement.Text = "Caste Management";
            this.btnCasteManagement.UseVisualStyleBackColor = true;
            this.btnCasteManagement.Click += new System.EventHandler(this.btnCasteManagement_Click);
            // 
            // btnReligionManagement
            // 
            this.btnReligionManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReligionManagement.Location = new System.Drawing.Point(512, 12);
            this.btnReligionManagement.Name = "btnReligionManagement";
            this.btnReligionManagement.Size = new System.Drawing.Size(94, 94);
            this.btnReligionManagement.TabIndex = 6;
            this.btnReligionManagement.Text = "Religion Management";
            this.btnReligionManagement.UseVisualStyleBackColor = true;
            this.btnReligionManagement.Click += new System.EventHandler(this.btnReligionManagement_Click);
            // 
            // btnSubCasteManagement
            // 
            this.btnSubCasteManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCasteManagement.Location = new System.Drawing.Point(312, 12);
            this.btnSubCasteManagement.Name = "btnSubCasteManagement";
            this.btnSubCasteManagement.Size = new System.Drawing.Size(94, 94);
            this.btnSubCasteManagement.TabIndex = 4;
            this.btnSubCasteManagement.Text = "Sub Caste Management";
            this.btnSubCasteManagement.UseVisualStyleBackColor = true;
            this.btnSubCasteManagement.Click += new System.EventHandler(this.btnSubCasteManagement_Click);
            // 
            // btnGenderManagement
            // 
            this.btnGenderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenderManagement.Location = new System.Drawing.Point(412, 12);
            this.btnGenderManagement.Name = "btnGenderManagement";
            this.btnGenderManagement.Size = new System.Drawing.Size(94, 94);
            this.btnGenderManagement.TabIndex = 5;
            this.btnGenderManagement.Text = "Gender Management";
            this.btnGenderManagement.UseVisualStyleBackColor = true;
            this.btnGenderManagement.Click += new System.EventHandler(this.btnGenderManagement_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 113);
            this.Controls.Add(this.btnReligionManagement);
            this.Controls.Add(this.btnSubCasteManagement);
            this.Controls.Add(this.btnGenderManagement);
            this.Controls.Add(this.btnCasteManagement);
            this.Controls.Add(this.btnCountryManagement);
            this.Controls.Add(this.btnStateManagement);
            this.Name = "Menu";
            this.Text = "Office Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStateManagement;
        private System.Windows.Forms.Button btnCountryManagement;
        private System.Windows.Forms.Button btnCasteManagement;
        private System.Windows.Forms.Button btnReligionManagement;
        private System.Windows.Forms.Button btnSubCasteManagement;
        private System.Windows.Forms.Button btnGenderManagement;

    }
}

