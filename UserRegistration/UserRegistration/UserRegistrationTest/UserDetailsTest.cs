using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationTest
{
    class UserDetailsTest
    {
        /// <summary>
        /// This method cantains the code of validating user first name
        /// </summary>
        /// <param name="fname"></param>
        /// <returns>true|false</returns>
        public bool FirstNameMethod(String fname)
        {
            Regex firstname = new Regex(@"^[A-Z][a-z]{2,}$");
            if (firstname.IsMatch(fname))
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method cantains the code of validating user first name
        /// </summary>
        /// <param name="fname"></param>
        /// <returns>true|false</returns>
        public bool LastNameMethod(String lname)
        {
            Regex lastname = new Regex(@"^[A-Z][a-z]{2,}$");
            if (lastname.IsMatch(lname))
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method cantains the code of validating user email
        /// </summary>
        /// <param name="fname"></param>
        /// <returns>true|false</returns>
        public bool EmailMethod(String emailid)
        {
            Regex email= new Regex(@"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$");
            if (email.IsMatch(emailid))
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method cantains the code of validating user mobile number
        /// </summary>
        /// <param name="fname"></param>
        /// <returns>true|false</returns>
        public bool MobileMethod(String mobileno)
        {
            Regex mobile = new Regex(@"^[0-9]{2}[ ][0-9]{10}$");
            if (mobile.IsMatch(mobileno))
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method cantains the code of validating password format
        /// </summary>
        /// <param name="fname"></param>
        /// <returns>true|false</returns>
        public bool PasswordMethod(String pass)
        {
            Regex password= new Regex(@"^.*(?=.{8,})(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!*#@&^$+=]).*$");
            if (password.IsMatch(pass))
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method cantains the code of validating user email
        /// </summary>
        /// <param name="fname"></param>
        /// <returns>true|false</returns>
        public bool EmailsMethod(String emailid)
        {
            Regex email = new Regex(@"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$");
            if (email.IsMatch(emailid))
                return true;
            else
                return false;
        }
    }
}
