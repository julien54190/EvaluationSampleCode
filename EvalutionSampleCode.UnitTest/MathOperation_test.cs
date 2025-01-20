using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Initialize()
        {
            // Initialisation de la classe MathOperations avant chaque test
            _mathOperations = new MathOperations();
        }

        [DataTestMethod]
        [DataRow(10, 5, 5)] 
        [DataRow(100, 50, 50)] 
        [DataRow(1000, 500, 500)] 
        [DataRow(1199, 199, 1000)] 
        [DataRow(5, 0, 5)] 
        public void Subtract_TestePlusieursScenarios(int numberOne, int numberTwo, int resultatAttendu)
        {
            // Act
            var resultat = _mathOperations.Subtract(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(resultatAttendu, resultat);
        }

        [DataTestMethod]
        [DataRow(5, 10)] 
        [DataRow(1200, 0)] 
        [DataRow(1500, 10)] 
        public void Subtract_LanceExceptionSiParametresInvalides(int numberOne, int numberTwo)
        {
            // Assert
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [DataTestMethod]
        [DataRow(1, "Blue")] 
        [DataRow(2, "Red")] 
        [DataRow(9, "Blue")] 
        [DataRow(10, "Red")] 
        [DataRow(0, "Red")] 
        public void GetColorFromOddsNumber_TesteCouleurs(int number, string couleurAttendue)
        {
            // Act
            var resultat = _mathOperations.GetColorFromOddsNumber(number);

            // Assert
            Assert.AreEqual(couleurAttendue, resultat);
        }

        [DataTestMethod]
        [DataRow(-1)] 
        [DataRow(-10)]
        public void GetColorFromOddsNumber_LanceExceptionSiNombreNegatif(int number)
        {
            // Assert
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetColorFromOddsNumber(number));
        }
    }
}
