using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.Methods
{
    public class ValidationMethods
    {

        public bool nameValidation(string name) { 
            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Complete enter name.");
                return false;
            }
            return true;
        }
        public bool passwordValidation(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 12 ||
                !password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                MessageBox.Show("Password must be 8-12 characters long,\r\ncontain at least one uppercase and one lowercase letter.");
                return false;
            }
            return true;
        }

        public bool emailValidation(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Enter valid your email.");
                return false;
            }

            if(!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid email address. Please try again.");
                return false;
            }

            
            return true;
        }

        public bool phoneValidation(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Invalid phone number. Please try again.");
                return false;
            }

            // Regular expression for validating phone numbers
            string pattern = @"^\+?[0-9]{10,15}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, pattern))
            {
                MessageBox.Show("Invalid phone number format. Please use a valid format (e.g., +1234567890 or 1234567890).");
                return false;
            }

            return true;
        }

        public bool validationInputDatas(string data, string input)
        {

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show($"Enter valid your {input}");
                return false;
            }

            return true;
        }

        public bool numberValidation(string input, string show)
        {
            if(double.TryParse(input, out _))
            {
                return true;
            }

            MessageBox.Show($"Valid only number in {show}");
            return false;
        }
    }
}
