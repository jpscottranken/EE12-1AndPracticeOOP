using System;

namespace BMIOOP1
{
    public class Person
    {
        //  Declare and initialize program constants
        const decimal MINOPTIMAL = 18.5m;
        const decimal MINOVER    = 25.0m;
        const decimal MINOBESE   = 30.0m;

        //  Create class variables
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public decimal Height { get; set; }
        public decimal Weight { get; set; }

        public decimal BMI { get; set; }
        public string BMIStatus { get; set; } = "";

        //  Full-Arg Constructor
        public Person(string fn, string ln, decimal h, decimal w)
        {
            FirstName = fn;
            LastName = ln;
            Height = h;
            Weight = w;
        }

        //  Calculate BMI using formula shown.
        //  Set BMIStatus based upon the BMI.
        public void BMIAndBMIStatus()
        {
            BMI = (Weight / (Height * Height)) * 703;

            if (BMI < MINOPTIMAL)
            {
                BMIStatus = "Underweight";
            }
            else if (BMI < MINOVER) 
            {
                BMIStatus = "Optimal Weight";
            }
            else if (BMI < MINOBESE)
            {
                BMIStatus = "Overweight";
            }
            else if (BMI >= MINOBESE)
            {
                BMIStatus = "Obese";
            }
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} {Height} inches {Weight} lbs. BMI: {BMI:n2} Status: {BMIStatus}";
        }
    }
}
