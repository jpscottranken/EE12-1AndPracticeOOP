namespace BMIOOP2
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
            lstResults = new ListBox();
            txtLastName = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            txtBMIStatus = new TextBox();
            txtBMI = new TextBox();
            txtFirstName = new TextBox();
            btnExit = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            lblLastName = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            lblBIStatus = new Label();
            lblBMI = new Label();
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
            lstResults.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtLastName.Location = new Point(368, 147);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(247, 38);
            txtLastName.TabIndex = 1;
            txtLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHeight.Location = new Point(368, 220);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(247, 38);
            txtHeight.TabIndex = 2;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            txtWeight.AccessibleRole = AccessibleRole.WhiteSpace;
            txtWeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtWeight.Location = new Point(368, 294);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(247, 38);
            txtWeight.TabIndex = 3;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBMIStatus
            // 
            txtBMIStatus.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtBMIStatus.Location = new Point(368, 433);
            txtBMIStatus.Name = "txtBMIStatus";
            txtBMIStatus.ReadOnly = true;
            txtBMIStatus.Size = new Size(247, 38);
            txtBMIStatus.TabIndex = 9;
            txtBMIStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBMI
            // 
            txtBMI.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtBMI.Location = new Point(368, 362);
            txtBMI.Name = "txtBMI";
            txtBMI.ReadOnly = true;
            txtBMI.Size = new Size(247, 38);
            txtBMI.TabIndex = 8;
            txtBMI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtFirstName.Location = new Point(368, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(247, 38);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(918, 526);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(265, 67);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(617, 526);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(265, 67);
            btnClear.TabIndex = 5;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += this.btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(311, 526);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(265, 67);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += this.btnCalculate_Click;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Yellow;
            lblLastName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(53, 147);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(265, 35);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            lblHeight.BackColor = Color.Yellow;
            lblHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHeight.ForeColor = Color.Black;
            lblHeight.Location = new Point(53, 220);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(265, 35);
            lblHeight.TabIndex = 12;
            lblHeight.Text = "Height:";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            lblWeight.BackColor = Color.Yellow;
            lblWeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblWeight.ForeColor = Color.Black;
            lblWeight.Location = new Point(53, 294);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(265, 35);
            lblWeight.TabIndex = 13;
            lblWeight.Text = "Weight:";
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBIStatus
            // 
            lblBIStatus.BackColor = Color.Yellow;
            lblBIStatus.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblBIStatus.ForeColor = Color.Black;
            lblBIStatus.Location = new Point(53, 436);
            lblBIStatus.Name = "lblBIStatus";
            lblBIStatus.Size = new Size(265, 35);
            lblBIStatus.TabIndex = 15;
            lblBIStatus.Text = "BMI Status:";
            lblBIStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            lblBMI.BackColor = Color.Yellow;
            lblBMI.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblBMI.ForeColor = Color.Black;
            lblBMI.Location = new Point(53, 362);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(265, 35);
            lblBMI.TabIndex = 14;
            lblBMI.Text = "BMI:";
            lblBMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Yellow;
            lblFirstName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(53, 72);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(265, 35);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmBMI
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
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
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstResults;
        private TextBox txtLastName;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private TextBox txtBMIStatus;
        private TextBox txtBMI;
        private TextBox txtFirstName;
        private Button btnExit;
        private Button btnClear;
        private Button btnCalculate;
        private Label lblLastName;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblBIStatus;
        private Label lblBMI;
        private Label lblFirstName;
    }
}
