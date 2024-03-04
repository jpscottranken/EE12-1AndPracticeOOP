namespace EE_12_1
{
    partial class frmNewItem
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
            lblItemNo = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            txtItemNo = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblItemNo
            // 
            lblItemNo.BackColor = Color.FromArgb(128, 128, 255);
            lblItemNo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblItemNo.ForeColor = Color.White;
            lblItemNo.Location = new Point(118, 35);
            lblItemNo.Name = "lblItemNo";
            lblItemNo.Size = new Size(248, 39);
            lblItemNo.TabIndex = 0;
            lblItemNo.Text = "Item No:";
            lblItemNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.FromArgb(128, 128, 255);
            lblDescription.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(118, 131);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(248, 38);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.FromArgb(128, 128, 255);
            lblPrice.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(118, 227);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(248, 35);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtItemNo
            // 
            txtItemNo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtItemNo.Location = new Point(422, 36);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(248, 38);
            txtItemNo.TabIndex = 3;
            txtItemNo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDescription.Location = new Point(422, 131);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(248, 38);
            txtDescription.TabIndex = 4;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtPrice.Location = new Point(422, 224);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(248, 38);
            txtPrice.TabIndex = 5;
            txtPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSave.Location = new Point(118, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(248, 62);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCancel.Location = new Point(422, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(248, 62);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmNewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtItemNo);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblItemNo);
            Name = "frmNewItem";
            Text = "frmNewItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemNo;
        private Label lblDescription;
        private Label lblPrice;
        private TextBox txtItemNo;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}