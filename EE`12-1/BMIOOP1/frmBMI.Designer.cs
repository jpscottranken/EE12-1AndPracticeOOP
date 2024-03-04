namespace BMIOOP1
{
    partial class frmBMI
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
            lblFirstName = new Label();
            lblBMI = new Label();
            lblBIStatus = new Label();
            lblWeight = new Label();
            lblHeight = new Label();
            lblLastName = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtFirstName = new TextBox();
            txtBMI = new TextBox();
            txtBMIStatus = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtLastName = new TextBox();
            lstResults = new ListBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.FromArgb(255, 128, 128);
            lblFirstName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(57, 61);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(265, 35);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            lblBMI.BackColor = Color.FromArgb(255, 128, 128);
            lblBMI.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblBMI.ForeColor = Color.White;
            lblBMI.Location = new Point(57, 351);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(265, 35);
            lblBMI.TabIndex = 14;
            lblBMI.Text = "BMI:";
            lblBMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBIStatus
            // 
            lblBIStatus.BackColor = Color.FromArgb(255, 128, 128);
            lblBIStatus.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblBIStatus.ForeColor = Color.White;
            lblBIStatus.Location = new Point(57, 425);
            lblBIStatus.Name = "lblBIStatus";
            lblBIStatus.Size = new Size(265, 35);
            lblBIStatus.TabIndex = 15;
            lblBIStatus.Text = "BMI Status:";
            lblBIStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            lblWeight.BackColor = Color.FromArgb(255, 128, 128);
            lblWeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblWeight.ForeColor = Color.White;
            lblWeight.Location = new Point(57, 283);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(265, 35);
            lblWeight.TabIndex = 13;
            lblWeight.Text = "Weight:";
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            lblHeight.BackColor = Color.FromArgb(255, 128, 128);
            lblHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHeight.ForeColor = Color.White;
            lblHeight.Location = new Point(57, 209);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(265, 35);
            lblHeight.TabIndex = 12;
            lblHeight.Text = "Height:";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.FromArgb(255, 128, 128);
            lblLastName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(57, 136);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(265, 35);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(315, 515);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(265, 67);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(621, 515);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(265, 67);
            btnClear.TabIndex = 7;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(922, 515);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(265, 67);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtFirstName.Location = new Point(372, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(247, 38);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBMI
            // 
            txtBMI.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtBMI.Location = new Point(372, 351);
            txtBMI.Name = "txtBMI";
            txtBMI.ReadOnly = true;
            txtBMI.Size = new Size(247, 38);
            txtBMI.TabIndex = 4;
            txtBMI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBMIStatus
            // 
            txtBMIStatus.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtBMIStatus.Location = new Point(372, 422);
            txtBMIStatus.Name = "txtBMIStatus";
            txtBMIStatus.ReadOnly = true;
            txtBMIStatus.Size = new Size(247, 38);
            txtBMIStatus.TabIndex = 5;
            txtBMIStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            txtWeight.AccessibleRole = AccessibleRole.WhiteSpace;
            txtWeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtWeight.Location = new Point(372, 283);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(247, 38);
            txtWeight.TabIndex = 3;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHeight.Location = new Point(372, 209);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(247, 38);
            txtHeight.TabIndex = 2;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtLastName.Location = new Point(372, 136);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(247, 38);
            txtLastName.TabIndex = 1;
            txtLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // lstResults
            // 
            lstResults.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 31;
            lstResults.Location = new Point(657, 58);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(742, 376);
            lstResults.TabIndex = 9;
            // 
            // frmBMI
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            CancelButton = btnClear;
            ClientSize = new Size(1449, 663);
            Controls.Add(lstResults);
            Controls.Add(txtLastName);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(txtBMIStatus);
            Controls.Add(txtBMI);
            Controls.Add(txtFirstName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblLastName);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblBIStatus);
            Controls.Add(lblBMI);
            Controls.Add(lblFirstName);
            Name = "frmBMI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Body Mass Index Program Using Object-Oriented Programming (OOP) - Version 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblBMI;
        private Label lblBIStatus;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblLastName;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtFirstName;
        private TextBox txtBMI;
        private TextBox txtBMIStatus;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtLastName;
        private ListBox lstResults;
    }
}
