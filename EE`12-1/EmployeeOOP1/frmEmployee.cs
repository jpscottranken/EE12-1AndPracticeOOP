namespace EmployeeOOP1
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName  = txtLastName.Text.Trim();
                string empNumber = txtEmployeeNumber.Text.Trim();
                decimal hours    = decimal.Parse(txtHoursWorked.Text.Trim());
                decimal hrate    = decimal.Parse(txtHourlyRate.Text.Trim());
                decimal gross    = 0m;

                //  Instantiate a new Employee object
                Employee employee = new Employee(firstName, lastName,
                                          empNumber, hours, hrate);

                gross = employee.CalculateGrossPay(hours, hrate);

                //  Fill in the grossPay textbox
                txtGrossPay.Text = $"{gross:c}";

                //  Add current employee to the listbox
                lstResults.Items.Add(employee.ToString());
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n\n" +
                                "Invalid Input.", "INPUT ERROR");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmployeeNumber.Text = "";
            txtHoursWorked.Text = "";
            txtHourlyRate.Text = "";
            txtGrossPay.Text = "";
            txtFirstName.Focus();
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
