using System;

namespace EmployeeOOP1
{
    public class Employee
    {
        //  Declare and initialize class constants
        const decimal MINHOURS =  0.00m;
        const decimal MAXHOURS = 84.00m;
        const decimal MINHRATE =  0.00m;
        const decimal MAXHRATE = 99.99m;
        const decimal MAXNONOT = 40.00m;
        const decimal OVERTIME =  1.5m;

        //  Class variables
        private string  firstName;
        private string  lastName;
        private string  employeeNumber;
        private decimal hoursWorked;
        private decimal hourlyRate;

        //  Full-Arg Constructor
        public Employee(string fn, string ln, string en,
                        decimal hw, decimal hr)
        {
            firstName       = fn;
            lastName        = ln;
            employeeNumber  = en;
            hoursWorked     = hw;
            hourlyRate      = hr;
        }

        //  Getters and Setters
        public string FirstName
        {
            get => firstName;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First Name Cannot Be Empty.");
                }
            }
        }

        public string LastName
        {
            get => lastName;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last Name Cannot Be Empty.");
                }
            }
        }

        public string EmployeeNumber
        {
            get => employeeNumber;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Employee Number Cannot Be Empty.");
                }
            }
        }

        public decimal HoursWorked
        {
            get => hoursWorked;

            set
            {
                //  Range check
                if (value < MINHOURS || value > MAXHOURS)
                {
                    throw new ArgumentOutOfRangeException("Hours must be " +
                                  "between " + MINHOURS + " and " + MAXHOURS,
                                  "INVALID HOURS");
                }
            }
        }

        public decimal HourlyRate
        {
            get => hourlyRate;

            set
            {
                //  Range check
                if (value < MINHRATE || value > MAXHRATE)
                {
                    throw new ArgumentOutOfRangeException("Rate must be " +
                                  "between " + MINHRATE + " and " + MAXHRATE,
                                  "INVALID HOURLY RATE");
                }
            }
        }

        public decimal GrossPay { get; private set; }

        public decimal CalculateGrossPay(decimal HoursWorked, decimal HourlyRate)
        {
            if (HoursWorked <= MAXNONOT)
            {
                //  NO overtime was worked
                GrossPay = Convert.ToDecimal(HoursWorked * HourlyRate);
            }
            else
            {
                //  Overtime WAS worked
                GrossPay = Convert.ToDecimal(MAXNONOT * HourlyRate)
                         + Convert.ToDecimal((HoursWorked - MAXNONOT) * HourlyRate * OVERTIME);
            }

            return GrossPay;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} Emp#: {EmployeeNumber} Hours: {HoursWorked:n2} Rate: {HourlyRate:c} Gross: {GrossPay:c}";
        }
    }
}
