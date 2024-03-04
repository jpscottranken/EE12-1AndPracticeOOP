/*
 *      Please create me a C# GUI application.
 *      
 *      It should have 6 labels:
 *      
 *      -	One for firstName
 *      -	One for lastName
 *      -	One for height
 *      -	One for weight
 *      -	One for body mass index (bmi)
 *      -	One for bmi status
 *
 *      It should have six textboxes:
 *      
 *      -	One for firstName (cannot be empty)   
 *      -	One for lastName  (cannot be empty)
 *      -	One for height	  (must be an integer, range 12 - 96 inches)
 *      -	One for weight	  (must be an integer, range 1 - 777 pounds)
 *      -	One for body mass index (BMI),
 *      	calculated as:	  (weight / (height * height)) * 703
 *      -	One for body mass index status, calculated as:
 *			underweight, optimal weight, overweight, or obese.
 *      -	Create a BMI class to hold the firstName, 
 *          lastName, height, weight, bmi, and bmi status. 
 *          
 *          Also, create a method overriding ToString() to
 *          print out all of the textbox values above.
 *          
 *      -	Create getters and setters for all inputs above.
 *      
 *      -	Get the actual inputs from the textboxes above
 */

namespace BMIOOP1
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
           try
            {
                //  Get data from the textboxes
                string firstName = txtFirstName.Text.Trim();
                string lastName  = txtLastName.Text.Trim();
                decimal height   = decimal.Parse(txtHeight.Text.Trim());
                decimal weight   = decimal.Parse(txtWeight.Text.Trim());

                //  Validate height
                if (height < MINHEIGHT || height > MAXHEIGHT)
                {
                    ShowErrorMessage("Height Must Be Between " +
                                     MINHEIGHT + " and " + MAXHEIGHT +
                                     " inches.", "INVALID HEIGHT");
                    txtHeight.Text = "";
                    txtHeight.Focus();
                    return;
                }

                //  Validate weight
                if (weight < MINWEIGHT || weight > MAXWEIGHT)
                {
                    ShowErrorMessage("Weight Must Be Between " +
                                     MINWEIGHT + " and " + MAXWEIGHT +
                                     " pounds.", "INVALID WEIGHT");
                    txtWeight.Text = "";
                    txtWeight.Focus();
                    return;
                }

                //  Instantiate a new Person object
                Person person = new Person(firstName, lastName,
                                           height, weight);

                //  Calculate the new Person objects BMI
                person.BMIAndBMIStatus();

                //  Add BMI and BMI status to 
                //  their respective textboxes
                txtBMI.Text       = person.BMI.ToString("n2");
                txtBMIStatus.Text = person.BMIStatus;

                //  Add Person to ListBox
                lstResults.Items.Add(person.ToString());
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n\n" +
                                 "Height and Weight Must Be Valid Ints.",
                                 "ERROR IN INPUT");
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
