using System;

namespace EE_12_1
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the inventory item.
        private InventoryItem item = null!;

        // Add a method here that gets and returns a new item.
        public InventoryItem GetNewItem()
        {
            this.ShowDialog();
            return item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Add code here that creates a new item
                // and closes the form.
                item = new(
                    Convert.ToInt32(txtItemNo.Text),
                    txtDescription.Text,
                    Convert.ToDecimal(txtPrice.Text)
                );
                this.Close();
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtItemNo.Text, "Item no");
            errorMessage += Validator.IsInt32(txtItemNo.Text, "Item no");
            errorMessage += Validator.IsPresent(txtDescription.Text, "Description");
            errorMessage += Validator.IsPresent(txtPrice.Text, "Price");
            errorMessage += Validator.IsDecimal(txtPrice.Text, "Price");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
