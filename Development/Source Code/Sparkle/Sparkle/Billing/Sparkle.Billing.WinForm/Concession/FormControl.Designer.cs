namespace Sparkle.Billing.WinForm.Concession
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFeeDefinition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCaste = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rdlNo = new System.Windows.Forms.RadioButton();
            this.rdlYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.label1, 0, 0);
            this.tlpMain.Controls.Add(this.cboFeeDefinition, 2, 0);
            this.tlpMain.Controls.Add(this.label3, 0, 1);
            this.tlpMain.Controls.Add(this.cboCaste, 2, 1);
            this.tlpMain.Controls.Add(this.label4, 0, 2);
            this.tlpMain.Controls.Add(this.txtAmount, 2, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 2, 3);
            this.tlpMain.Controls.Add(this.label2, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.MinimumSize = new System.Drawing.Size(100, 52);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(331, 100);
            this.tlpMain.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 168;
            this.label1.Text = "Fee Definition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFeeDefinition
            // 
            this.cboFeeDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFeeDefinition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFeeDefinition.FormattingEnabled = true;
            this.cboFeeDefinition.Location = new System.Drawing.Point(168, 3);
            this.cboFeeDefinition.Name = "cboFeeDefinition";
            this.cboFeeDefinition.Size = new System.Drawing.Size(139, 21);
            this.cboFeeDefinition.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 170;
            this.label3.Text = "Caste";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCaste
            // 
            this.cboCaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaste.FormattingEnabled = true;
            this.cboCaste.Location = new System.Drawing.Point(168, 27);
            this.cboCaste.Name = "cboCaste";
            this.cboCaste.Size = new System.Drawing.Size(139, 21);
            this.cboCaste.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 172;
            this.label4.Text = "Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Location = new System.Drawing.Point(168, 51);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(139, 20);
            this.txtAmount.TabIndex = 173;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rdlNo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdlYes, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(165, 72);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(145, 24);
            this.tableLayoutPanel2.TabIndex = 174;
            // 
            // rdlNo
            // 
            this.rdlNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdlNo.Location = new System.Drawing.Point(75, 3);
            this.rdlNo.Name = "rdlNo";
            this.rdlNo.Size = new System.Drawing.Size(67, 18);
            this.rdlNo.TabIndex = 168;
            this.rdlNo.TabStop = true;
            this.rdlNo.Text = "No";
            this.rdlNo.UseVisualStyleBackColor = true;
            // 
            // rdlYes
            // 
            this.rdlYes.Checked = true;
            this.rdlYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdlYes.Location = new System.Drawing.Point(3, 3);
            this.rdlYes.Name = "rdlYes";
            this.rdlYes.Size = new System.Drawing.Size(66, 18);
            this.rdlYes.TabIndex = 167;
            this.rdlYes.TabStop = true;
            this.rdlYes.Text = "Yes";
            this.rdlYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 175;
            this.label2.Text = "Is concession percentage?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(330, 100);
            this.Name = "FormControl";
            this.Size = new System.Drawing.Size(331, 100);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFeeDefinition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCaste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rdlNo;
        private System.Windows.Forms.RadioButton rdlYes;
        private System.Windows.Forms.Label label2;
    }
}
