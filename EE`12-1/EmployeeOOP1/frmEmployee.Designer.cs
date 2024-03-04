namespace EmployeeOOP1
{
    partial class frmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstResults = new ListBox();
            txtLastName = new TextBox();
            txtEmployeeNumber = new TextBox();
            txtHoursWorked = new TextBox();
            txtGrossPay = new TextBox();
            txtHourlyRate = new TextBox();
            txtFirstName = new TextBox();
            btnExit = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            lblLastName = new Label();
            lblEmployeeNumber = new Label();
            lblHoursWorked = new Label();
            lblGrossPay = new Label();
            lblHourlyRate = new Label();
            lblFirstName = new Label();
            SuspendLayout();
            // 
            // lstResults
            // 
            lstResults.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 31;
            lstResults.Location = new Point(653, 69);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(742, 376);
            lstResults.TabIndex = 9;
            //lstResults.SelectedIndexChanged += this.lstResults_SelectedIndexChanged;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtLastName.Location = new Point(368, 147);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(247, 38);
            txtLastName.TabIndex = 1;
            txtLastName.TextAlign = HorizontalAlignment.Center;
            //txtLastName.TextChanged += this.txtLastName_TextChanged;
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtEmployeeNumber.Location = new Point(368, 220);
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(247, 38);
            txtEmployeeNumber.TabIndex = 2;
            txtEmployeeNumber.TextAlign = HorizontalAlignment.Center;
            //txtEmployeeNumber.TextChanged += this.txtEmployeeNumber_TextChanged;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.AccessibleRole = AccessibleRole.WhiteSpace;
            txtHoursWorked.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHoursWorked.Location = new Point(368, 294);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(247, 38);
            txtHoursWorked.TabIndex = 3;
            txtHoursWorked.TextAlign = HorizontalAlignment.Center;
            //txtHoursWorked.TextChanged += this.txtHoursWorked_TextChanged;
            // 
            // txtGrossPay
            // 
            txtGrossPay.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtGrossPay.Location = new Point(368, 433);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.ReadOnly = true;
            txtGrossPay.Size = new Size(247, 38);
            txtGrossPay.TabIndex = 8;
            txtGrossPay.TextAlign = HorizontalAlignment.Center;
            //txtGrossPay.TextChanged += this.txtGrossPay_TextChanged;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHourlyRate.Location = new Point(368, 362);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(247, 38);
            txtHourlyRate.TabIndex = 4;
            txtHourlyRate.TextAlign = HorizontalAlignment.Center;
            //txtHourlyRate.TextChanged += this.txtHourlyRate_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtFirstName.Location = new Point(368, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(247, 38);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            //txtFirstName.TextChanged += this.txtFirstName_TextChanged;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(918, 526);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(265, 67);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(617, 526);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(265, 67);
            btnClear.TabIndex = 6;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(311, 526);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(265, 67);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Lime;
            lblLastName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(53, 147);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(265, 35);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            //lblLastName.Click += this.lblLastName_Click;
            // 
            // lblEmployeeNumber
            // 
            lblEmployeeNumber.BackColor = Color.Lime;
            lblEmployeeNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblEmployeeNumber.ForeColor = Color.Black;
            lblEmployeeNumber.Location = new Point(53, 220);
            lblEmployeeNumber.Name = "lblEmployeeNumber";
            lblEmployeeNumber.Size = new Size(265, 35);
            lblEmployeeNumber.TabIndex = 12;
            lblEmployeeNumber.Text = "Employee #:";
            lblEmployeeNumber.TextAlign = ContentAlignment.MiddleCenter;
            //lblEmployeeNumber.Click += this.lblEmployeeNumber_Click;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.BackColor = Color.Lime;
            lblHoursWorked.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHoursWorked.ForeColor = Color.Black;
            lblHoursWorked.Location = new Point(53, 294);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(265, 35);
            lblHoursWorked.TabIndex = 13;
            lblHoursWorked.Text = "Hours (0 - 84):";
            lblHoursWorked.TextAlign = ContentAlignment.MiddleCenter;
            //lblHoursWorked.Click += this.lblHoursWorked_Click;
            // 
            // lblGrossPay
            // 
            lblGrossPay.BackColor = Color.Lime;
            lblGrossPay.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblGrossPay.ForeColor = Color.Black;
            lblGrossPay.Location = new Point(53, 436);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(265, 35);
            lblGrossPay.TabIndex = 15;
            lblGrossPay.Text = "Gross Pay:";
            lblGrossPay.TextAlign = ContentAlignment.MiddleCenter;
            //lblGrossPay.Click += this.lblGrossPay_Click;
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.BackColor = Color.Lime;
            lblHourlyRate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHourlyRate.ForeColor = Color.Black;
            lblHourlyRate.Location = new Point(53, 362);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(265, 35);
            lblHourlyRate.TabIndex = 14;
            lblHourlyRate.Text = "Rate (0 - 99.99):";
            lblHourlyRate.TextAlign = ContentAlignment.MiddleCenter;
            //lblHourlyRate.Click += this.lblHourlyRate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Lime;
            lblFirstName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(53, 72);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(265, 35);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            //lblFirstName.Click += this.lblFirstName_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1449, 663);
            Controls.Add(lstResults);
            Controls.Add(txtLastName);
            Controls.Add(txtEmployeeNumber);
            Controls.Add(txtHoursWorked);
            Controls.Add(txtGrossPay);
            Controls.Add(txtHourlyRate);
            Controls.Add(txtFirstName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblLastName);
            Controls.Add(lblEmployeeNumber);
            Controls.Add(lblHoursWorked);
            Controls.Add(lblGrossPay);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblFirstName);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstResults;
        private TextBox txtLastName;
        private TextBox txtEmployeeNumber;
        private TextBox txtHoursWorked;
        private TextBox txtGrossPay;
        private TextBox txtHourlyRate;
        private TextBox txtFirstName;
        private Button btnExit;
        private Button btnClear;
        private Button btnCalculate;
        private Label lblLastName;
        private Label lblEmployeeNumber;
        private Label lblHoursWorked;
        private Label lblGrossPay;
        private Label lblHourlyRate;
        private Label lblFirstName;
    }
}
