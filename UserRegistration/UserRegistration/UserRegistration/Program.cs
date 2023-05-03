using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// This class contains main method of user registration project
    /// </summary>
    public class Program
    {   
        /// <summary>
        /// Purpose of this method is controlling the all method in this project
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            UserDetails details = new UserDetails();
            details.FirstNameMethod();
            details.LastNameMethod();
            details.EmailMethod();
            details.MobileMethod();
            details.PasswordMethod();
        }
    }
}
