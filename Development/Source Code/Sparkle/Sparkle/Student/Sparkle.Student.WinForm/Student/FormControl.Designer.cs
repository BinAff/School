namespace Sparkle.Student.WinForm.Student
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpMain.Controls.Add(this.txtAddress, 2, 3);
            this.tlpMain.Controls.Add(this.label1, 0, 0);
            this.tlpMain.Controls.Add(this.label2, 0, 1);
            this.tlpMain.Controls.Add(this.label3, 0, 2);
            this.tlpMain.Controls.Add(this.label4, 0, 3);
            this.tlpMain.Controls.Add(this.label5, 0, 5);
            this.tlpMain.Controls.Add(this.label6, 0, 6);
            this.tlpMain.Controls.Add(this.label7, 0, 7);
            this.tlpMain.Controls.Add(this.label8, 0, 8);
            this.tlpMain.Controls.Add(this.txtFirstName, 2, 0);
            this.tlpMain.Controls.Add(this.txtMiddleName, 2, 1);
            this.tlpMain.Controls.Add(this.txtLastName, 2, 2);
            this.tlpMain.Controls.Add(this.txtCity, 2, 7);
            this.tlpMain.Controls.Add(this.txtPin, 2, 8);
            this.tlpMain.Controls.Add(this.cboCountry, 2, 5);
            this.tlpMain.Controls.Add(this.cboState, 2, 6);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.MinimumSize = new System.Drawing.Size(100, 216);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 10;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.Size = new System.Drawing.Size(480, 333);
            this.tlpMain.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(242, 75);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.tlpMain.SetRowSpan(this.txtAddress, 2);
            this.txtAddress.Size = new System.Drawing.Size(213, 42);
            this.txtAddress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Country";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "State";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "City";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(242, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMiddleName.Location = new System.Drawing.Point(242, 27);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(213, 20);
            this.txtMiddleName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(242, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCity.Location = new System.Drawing.Point(242, 171);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(213, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtPin
            // 
            this.txtPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPin.Location = new System.Drawing.Point(242, 195);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(213, 20);
            this.txtPin.TabIndex = 14;
            // 
            // cboCountry
            // 
            this.cboCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(242, 123);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(213, 21);
            this.cboCountry.TabIndex = 15;
            // 
            // cboState
            // 
            this.cboState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(242, 147);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(213, 21);
            this.cboState.TabIndex = 16;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "FormControl";
            this.Size = new System.Drawing.Size(480, 333);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboState;
    }
}
