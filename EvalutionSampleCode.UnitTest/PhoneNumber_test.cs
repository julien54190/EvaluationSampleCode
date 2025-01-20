using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EvaluationSampleCode.Tests
{
    [TestClass]
    public class PhoneNumberTests
    {
        // Test pour vérifier que le numéro de téléphone valide est bien parsé et formaté correctement
        [TestMethod]
        [DataRow("0123456789", "(012)345-6789")]
        [DataRow("0654321098", "(065)432-1098")]
        [DataRow("0987654321", "(098)765-4321")]
        [DataRow("0123456780", "(012)345-6780")]
        [DataRow("0708091011", "(070)809-1011")]
        public void TestParseValide(string input, string expected)
        {
            // Acte : Appel de la méthode Parse pour transformer la chaîne en PhoneNumber
            PhoneNumber phoneNumber = PhoneNumber.Parse(input);

            // Assert : Vérifier si le résultat correspond à l'attendu
            Assert.AreEqual(expected, phoneNumber.ToString(), "Le format du numéro de téléphone est incorrect.");
        }

        // Test pour vérifier que la méthode Parse lance une exception lorsque le numéro est trop court
        [TestMethod]
        [DataRow("12345678")]  
        [DataRow("12345")]   
        [DataRow("1")]        
        [DataRow("123456789")] 
        public void TestParseExceptionTropCourt(string input)
        {
            // Essayer de parser un numéro trop court
            var exception = Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(input));

            // Vérifier que le message d'erreur est correct
            Assert.AreEqual("Phone number should be 10 digits long.", exception.Message);
        }

        // Test pour vérifier que la méthode Parse lance une exception pour un numéro trop long
        [TestMethod]
        [DataRow("012345678901")]  
        [DataRow("1234567890123")] 
        [DataRow("9876543210987")] 
        [DataRow("1112223334445")] 
        public void TestParseExceptionTropLong(string input)
        {
            // Essayer de parser un numéro trop long
            var exception = Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(input));

            // Vérifier que le message d'erreur est correct
            Assert.AreEqual("Phone number should be 10 digits long.", exception.Message);
        }

        // Test pour vérifier que la méthode Parse lance une exception si le numéro est vide
        [TestMethod]
        [DataRow("")]  
        [DataRow("   ")] 
        [DataRow("\t")]  
        [DataRow("\n")]  
        public void TestParseExceptionVide(string input)
        {
            // Essayer de parser un numéro vide ou contenant des espaces
            var exception = Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(input));

            // Vérifier que le message d'erreur est correct
            Assert.AreEqual("Phone number cannot be blank.", exception.Message);
        }

        // // Test pour vérifier que la méthode Parse lance une exception si le numéro est null

    }
}
