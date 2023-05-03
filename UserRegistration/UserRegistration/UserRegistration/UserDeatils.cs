using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// This class cantains the code of user deatils 
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// Purpose of this method is creating for validate first name
        /// </summary>
        public void FirstNameMethod()
        {
            Console.Write("Enter your frist name: ");
            String fname = Console.ReadLine();
            Regex firstname = new Regex(@"^[A-Z][a-z]{2,}$");
            if (firstname.IsMatch(fname))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        /// <summary>
        /// Purpose of this method is creating for validate last name
        /// </summary>
        public void LastNameMethod()
        {
            Console.Write("Enter your last name: ");
            String lname = Console.ReadLine();
            Regex lastname = new Regex(@"^[A-Z][a-z]{2,}$");
            if (lastname.IsMatch(lname))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        /// <summary>
        /// Purpose of this method is creating for validate various email format
        /// </summary>
        public void EmailMethod()
        {
            Console.Write("Enter your last emailid: ");
            String emailid = Console.ReadLine();
            Regex email= new Regex(@"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$");
            if (email.IsMatch(emailid))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        /// <summary>
        /// Purpose of this method is creating for validate various mobile format
        /// </summary>
        public void MobileMethod()
        {
            Console.Write("Enter your mobile number: ");
            String mobileno = Console.ReadLine();
            Regex mobile= new Regex(@"^[0-9]{2}[ ][0-9]{10}$");
            if (mobile.IsMatch(mobileno))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        /// <summary>
        /// Purpose of this method is creating for validate various valid password format
        /// </summary>
        public void PasswordMethod()
        {
            Console.Write("Enter your valid password: ");
            String pass = Console.ReadLine();
            Regex password = new Regex(@"^.*(?=.{8,})(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!*#@&^$+=]).*$");
            if (password.IsMatch(pass))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
