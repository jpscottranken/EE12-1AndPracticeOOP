using BMIOOP1;

namespace BMIOOP2
{
    public partial class frmBMI : Form
    {
        //  Declare and initialize program constants
        const decimal MINHEIGHT =  12m;
        const decimal MAXHEIGHT =  96m;
        const decimal MINWEIGHT =   1m;
        const decimal MAXWEIGHT = 777m;

        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                //  Get data from the textboxes
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                decimal height = decimal.Parse(txtHeight.Text.Trim());
                decimal weight = decimal.Parse(txtWeight.Text.Trim());

                //  Instantiate a new person object
                Person person = new Person(firstName, lastName,
                                           height, weight);

                //  Calculate BMI and BMI status
                person.BMIAndBMIStatus();

                //  Fill in BMI and BMIStatus textboxes
                txtBMI.Text       = person.BMI.ToString("n2");
                txtBMIStatus.Text = person.BMIStatus;

                //  Add person object to listbox
                lstResults.Items.Add(person.ToString());
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //  Validate firstName not empty
            errorMessage += Validator.IsPresent(txtFirstName.Text.Trim(),
                                                nameof(Person.FirstName));

            //  Validate lastName not empty
            errorMessage += Validator.IsPresent(txtLastName.Text.Trim(),
                                                nameof(Person.LastName));

            //  Validate height not empty
            errorMessage += Validator.IsPresent(txtHeight.Text.Trim(),
                                                nameof(Person.Height));
            errorMessage += Validator.IsDecimal(txtHeight.Text.Trim(),
                                    nameof(Person.Height));
            errorMessage += Validator.IsWithinRange(txtHeight.Text.Trim(),
                                    nameof(Person.Height),
                                    MINHEIGHT, MAXHEIGHT);

            //  Validate weight not empty
            errorMessage += Validator.IsPresent(txtWeight.Text.Trim(),
                                    nameof(Person.Weight));
            errorMessage += Validator.IsDecimal(txtWeight.Text.Trim(),
                                    nameof(Person.Weight));
            errorMessage += Validator.IsWithinRange(txtWeight.Text.Trim(),
                                    nameof(Person.Weight),
                                    MINWEIGHT, MAXWEIGHT);

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
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtBMI.Text = "";
            txtBMIStatus.Text = "";
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
