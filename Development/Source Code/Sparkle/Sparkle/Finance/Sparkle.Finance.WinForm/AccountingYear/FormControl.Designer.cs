namespace Sparkle.Finance.WinForm.AccountingYear
{
    partial class FormControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdlCurrYrYes = new System.Windows.Forms.RadioButton();
            this.rdlCurrYrNo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 162;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(174, 3);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 165;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.label1, 0, 0);
            this.tlpMain.Controls.Add(this.txtName, 2, 0);
            this.tlpMain.Controls.Add(this.groupBox1, 2, 1);
            this.tlpMain.Controls.Add(this.label2, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.MinimumSize = new System.Drawing.Size(100, 76);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.Size = new System.Drawing.Size(342, 141);
            this.tlpMain.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdlCurrYrNo);
            this.groupBox1.Controls.Add(this.rdlCurrYrYes);
            this.groupBox1.Location = new System.Drawing.Point(174, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 36);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            // 
            // rdlCurrYrYes
            // 
            this.rdlCurrYrYes.AutoSize = true;
            this.rdlCurrYrYes.Checked = true;
            this.rdlCurrYrYes.Location = new System.Drawing.Point(6, 13);
            this.rdlCurrYrYes.Name = "rdlCurrYrYes";
            this.rdlCurrYrYes.Size = new System.Drawing.Size(43, 17);
            this.rdlCurrYrYes.TabIndex = 0;
            this.rdlCurrYrYes.TabStop = true;
            this.rdlCurrYrYes.Text = "Yes";
            this.rdlCurrYrYes.UseVisualStyleBackColor = true;
            // 
            // rdlCurrYrNo
            // 
            this.rdlCurrYrNo.AutoSize = true;
            this.rdlCurrYrNo.Location = new System.Drawing.Point(70, 13);
            this.rdlCurrYrNo.Name = "rdlCurrYrNo";
            this.rdlCurrYrNo.Size = new System.Drawing.Size(39, 17);
            this.rdlCurrYrNo.TabIndex = 1;
            this.rdlCurrYrNo.TabStop = true;
            this.rdlCurrYrNo.Text = "No";
            this.rdlCurrYrNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 167;
            this.label2.Text = "Is Current Year?";
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "FormControl";
            this.Size = new System.Drawing.Size(342, 141);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdlCurrYrNo;
        private System.Windows.Forms.RadioButton rdlCurrYrYes;
        private System.Windows.Forms.Label label2;
    }
}
