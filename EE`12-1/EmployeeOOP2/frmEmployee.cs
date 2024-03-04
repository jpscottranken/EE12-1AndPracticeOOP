namespace EmployeeOOP2
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                //  "Shortcut" for the names
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string empNumber = txtEmployeeNumber.Text.Trim();
                decimal hours = Convert.ToDecimal(txtHoursWorked.Text.Trim());
                decimal hrate = Convert.ToDecimal(txtHourlyRate.Text.Trim());
                decimal grossPay = 0m;

                //  Instantiate an Employee object
                Employee employee = new Employee (firstName, lastName,
                                          empNumber, hours, hrate);

                //  Call method to calculate grossPay
                grossPay = employee.CalculateGrossPay(hours, hrate);

                //  Fill in the grossPay textbox
                txtGrossPay.Text = $"{grossPay:c}";

                //  Add current employee to listbox
                lstResults.Items.Add(employee.ToString());
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //  Validate first name
            errorMessage += Validator.IsPresent(txtFirstName.Text,
                                            nameof(Employee.FirstName));
            //  Validate last name
            errorMessage += Validator.IsPresent(txtLastName.Text,
                                            nameof(Employee.LastName));
            //  Validate employee number
            errorMessage += Validator.IsPresent(txtEmployeeNumber.Text,
                                            nameof(Employee.EmployeeNumber));

            //  Validate hours worked
            errorMessage += Validator.IsPresent(txtHoursWorked.Text,
                                            nameof(Employee.HoursWorked));
            errorMessage += Validator.IsDecimal(txtHoursWorked.Text,
                                            nameof(Employee.HoursWorked));
            //  Validate hourly rate
            errorMessage += Validator.IsPresent(txtHourlyRate.Text,
                                            nameof(Employee.HourlyRate));
            errorMessage += Validator.IsDecimal(txtHourlyRate.Text,
                                            nameof(Employee.HourlyRate));

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "ENTRY ERROR");
            }

            return success;
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
