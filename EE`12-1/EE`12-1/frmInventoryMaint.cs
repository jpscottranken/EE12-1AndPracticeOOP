using System;

namespace EE_12_1
{
    public partial class frmInventoryMaint : Form
    {

        //  Add a statement here that
        //  declares the list of items.
        private List<InventoryItem> items = null!;

        public frmInventoryMaint()
        {
            InitializeComponent();
        }

        private void frmInventoryMaint_Load(object sender, EventArgs e)
        {
            //  Add a statement here that
            //  gets the list of items.
            items = InventoryDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            //  Add code here that loads the
            //  list box with the items in the list.
            foreach (InventoryItem item in items)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void AddNewItem()
        {
            //  Add code here that creates an instance
            //  of the New Item form and then gets a
            //  new item from that form.
            frmNewItem newItemForm = new frmNewItem();
            InventoryItem item = newItemForm.GetNewItem();
            if (item != null)
            {
                items.Add(item);
                InventoryDB.SaveItems(items);
                FillItemListBox();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteExistingItem();
        }

        private void DeleteExistingItem()
        {
            //  Show which item is currently highlighted
            int i = lstItems.SelectedIndex;

            if (i == -1)
            {
                //  NOTHING is currently highlighted
                MessageBox.Show("Please select an item to delete.", "No item selected");
            }
            else
            {
                //  Add code here that displays a dialog
                //  box to confirm the deletion and then
                //  removes the item from the list, saves
                //  the list of products, and refreshes
                //  the list box if the deletion is confirmed.
                InventoryItem item = items[i];

                string message = $"Are you sure you want to delete {item.Description}?";
                DialogResult result =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    items.Remove(item);
                    InventoryDB.SaveItems(items);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

    }
}
