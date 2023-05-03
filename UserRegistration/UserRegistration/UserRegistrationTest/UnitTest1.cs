using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace UserRegistrationTest
{
    /// <summary>
    /// This class cantains the code of testing for user registrations 
    /// </summary>
    public class FirstNameTest
    {
        UserDetailsTest myobj = new UserDetailsTest();
        //--------------------------Test for first name------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void FirstNmaeTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest first = new UserDetailsTest();
            Assert.IsFalse(first.FirstNameMethod("biru"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void FirstNameTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest first = new UserDetailsTest();
            Assert.IsTrue(first.FirstNameMethod("Biru"));
        }

        //--------------------------Test for last name------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void LastNmaeTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest last = new UserDetailsTest();
            Assert.IsFalse(last.LastNameMethod("singh"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void LastNameTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest last= new UserDetailsTest();
            Assert.IsTrue(last.LastNameMethod("Singh"));
        }

        //-----------------------Test for emailid---------------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void EmailMethodTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest email= new UserDetailsTest();
            Assert.IsFalse(email.EmailMethod("abc12.xyz.co.in"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void EmailMethodTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest email= new UserDetailsTest();
            Assert.IsTrue(email.EmailMethod("abc.xyz@bridgelabz.co.in"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void EmailMethodTest_RightInput1_ReturnsTrue()
        {
            UserDetailsTest email = new UserDetailsTest();
            Assert.IsTrue(email.EmailMethod("abc@yahoo.com"));
        }

        //-----------------------Test for mobile number---------------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void MobileMethodTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest mobile = new UserDetailsTest();
            Assert.IsFalse(mobile.MobileMethod("6234748761"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void MobileMethodTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest mobile = new UserDetailsTest();
            Assert.IsTrue(mobile.MobileMethod("91 7735452322"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void MobileMethodTest_RightInput1_ReturnsTrue()
        {
            UserDetailsTest mobile = new UserDetailsTest();
            Assert.IsTrue(mobile.MobileMethod("91 7735452322"));
        }

        //-----------------------Test for valid password---------------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void PasswordMethodTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest password = new UserDetailsTest();
            Assert.IsFalse(password.PasswordMethod("soham@345"));
        }

        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void PasswordMethodTest_WorngInput1_ReturnsFalse()
        {
            UserDetailsTest password = new UserDetailsTest();
            Assert.IsFalse(password.PasswordMethod("soham345"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void PasswordMethodTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest password = new UserDetailsTest();
            Assert.IsTrue(password.PasswordMethod("Binay@998"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void PasswordMethodTest_RightInput1_ReturnsTrue()
        {
            UserDetailsTest password = new UserDetailsTest();
            Assert.IsTrue(password.PasswordMethod("ramKr@123"));
        }
        
        //-----------------------------Testing groups of emails at a time--------------------------------------
        /// <summary>
        /// This method is checking for multiple gmail in parameters
        /// </summary>
        [TestCase("abc@yahoo.com",true)]
        [TestCase("abc.100@yahoo.com", true)]
        [TestCase("abc", false)]
        [TestCase("abc@.com", false)]
        [TestCase("abc123@.com.com", false)]
        [TestCase("abc@gmail.com.aa.au",false)]
        [TestCase("abc@gmail.com",true)]
        [TestCase("abc.100@abc.com.au",true)]
        [TestCase("..abc@abc.com",false)]
        [TestCase("abc.@gmail.com", false)]
        [TestCase("abc@gmail.com.1a", false)]
        [TestCase("abc..2002@gmail.com", false)]

        public void EmailslMethodTest_RightInput_ReturnsTrueFalse(String emailid,bool exceptedvalue)
        {
            UserDetailsTest myobj = new UserDetailsTest();
            Assert.AreEqual(exceptedvalue,myobj.EmailsMethod(emailid));
        }
    }
}