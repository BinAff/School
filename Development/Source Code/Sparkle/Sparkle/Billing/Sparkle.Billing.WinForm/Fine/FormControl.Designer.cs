namespace Sparkle.Billing.WinForm.Fine
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
            this.cboFineType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFineDefinition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStandard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LowerLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.cboFineType, 2, 0);
            this.tlpMain.Controls.Add(this.label2, 0, 0);
            this.tlpMain.Controls.Add(this.label1, 0, 1);
            this.tlpMain.Controls.Add(this.cboFineDefinition, 2, 1);
            this.tlpMain.Controls.Add(this.label3, 0, 2);
            this.tlpMain.Controls.Add(this.cboStandard, 2, 2);
            this.tlpMain.Controls.Add(this.label4, 0, 3);
            this.tlpMain.Controls.Add(this.txtAmount, 2, 3);
            this.tlpMain.Controls.Add(this.label5, 0, 4);
            this.tlpMain.Controls.Add(this.dataGridView1, 0, 5);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.MinimumSize = new System.Drawing.Size(100, 52);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(400, 245);
            this.tlpMain.TabIndex = 12;
            // 
            // cboFineType
            // 
            this.cboFineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFineType.FormattingEnabled = true;
            this.cboFineType.Location = new System.Drawing.Point(203, 3);
            this.cboFineType.Name = "cboFineType";
            this.cboFineType.Size = new System.Drawing.Size(174, 21);
            this.cboFineType.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 167;
            this.label2.Text = "Fine Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 168;
            this.label1.Text = "Fine Definition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFineDefinition
            // 
            this.cboFineDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFineDefinition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFineDefinition.FormattingEnabled = true;
            this.cboFineDefinition.Location = new System.Drawing.Point(203, 27);
            this.cboFineDefinition.Name = "cboFineDefinition";
            this.cboFineDefinition.Size = new System.Drawing.Size(174, 21);
            this.cboFineDefinition.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 170;
            this.label3.Text = "Standard";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStandard
            // 
            this.cboStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStandard.FormattingEnabled = true;
            this.cboStandard.Location = new System.Drawing.Point(203, 51);
            this.cboStandard.Name = "cboStandard";
            this.cboStandard.Size = new System.Drawing.Size(174, 21);
            this.cboStandard.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 172;
            this.label4.Text = "Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Location = new System.Drawing.Point(203, 75);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(174, 20);
            this.txtAmount.TabIndex = 173;
            // 
            // label5
            // 
            this.tlpMain.SetColumnSpan(this.label5, 3);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 24);
            this.label5.TabIndex = 174;
            this.label5.Text = "Slab";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LowerLimit,
            this.UpperLimit,
            this.Amount});
            this.tlpMain.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 114);
            this.dataGridView1.TabIndex = 175;
            // 
            // LowerLimit
            // 
            this.LowerLimit.HeaderText = "Lower Limit";
            this.LowerLimit.Name = "LowerLimit";
            // 
            // UpperLimit
            // 
            this.UpperLimit.HeaderText = "Upper Limit";
            this.UpperLimit.Name = "UpperLimit";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(400, 244);
            this.Name = "FormControl";
            this.Size = new System.Drawing.Size(400, 245);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ComboBox cboFineType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFineDefinition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStandard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}
