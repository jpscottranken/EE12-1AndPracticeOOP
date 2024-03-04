namespace EE_12_1
{
    partial class frmInventoryMaint
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
            lstItems = new ListBox();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 31;
            lstItems.Location = new Point(12, 12);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(551, 407);
            lstItems.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnAddItem.Location = new Point(598, 12);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(190, 64);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "&Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnDeleteItem.Location = new Point(598, 182);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(190, 64);
            btnDeleteItem.TabIndex = 2;
            btnDeleteItem.Text = "&Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(598, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 64);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmInventoryMaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnAddItem);
            Controls.Add(lstItems);
            Name = "frmInventoryMaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Extra Exercise 12-1 - Inventory Maintenance";
            Load += this.frmInventoryMaint_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstItems;
        private Button btnAddItem;
        private Button btnDeleteItem;
        private Button btnExit;
    }
}
