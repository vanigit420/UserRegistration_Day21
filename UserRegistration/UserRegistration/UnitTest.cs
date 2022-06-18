using UserRegistration_Day21;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        //method for testing user details 
        [TestMethod]
        [TestCategory("User Details")]
        public void UserDetails()
        {
            bool expected = true;
            string firstName = "Nivas";
            string lastName = "Grandhi";
            string emailID = "ggj.nivas@ggmail.com";
            string mobileNum = "91 8790988099";
            string password = "Asdfg@1sbj";
            ValidUserRegistraton pattern = new ValidUserRegistraton();
            Assert.AreEqual(expected, pattern.ValidateFName(firstName));
            Assert.AreEqual(expected, pattern.ValidateLName(lastName));
            Assert.AreEqual(expected, pattern.ValidateEmail(emailID));
            Assert.AreEqual(expected, pattern.ValidateMobile(mobileNum));
            Assert.AreEqual(expected, pattern.ValidatePassword4(password));
        }
        //testing all emails samples
        [TestMethod]
        [TestCategory("Emails")]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId(string email)
        {
            bool expected = true;
            ValidUserRegistraton pattern = new ValidUserRegistraton();
            Assert.AreEqual(expected, pattern.ValidateEmail(email));
        }
    }
}