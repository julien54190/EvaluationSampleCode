using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HtmlFormatHelperTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _helper;

        [TestInitialize]
        public void Initialize()
        {
            // Initialisation de l'objet testé avant chaque test
            _helper = new HtmlFormatHelper();
        }

        [DataTestMethod]
        [DataRow("Bonjour", "<strong>Bonjour</strong>")]
        [DataRow("Test", "<strong>Test</strong>")]
        [DataRow("", "<strong></strong>")]
        [DataRow("123", "<strong>123</strong>")]
        [DataRow("Texte avec espace", "<strong>Texte avec espace</strong>")]
        public void GetStrongFormat_TestePlusieursScenarios(string input, string expected)
        {
            // Act
            var resultat = _helper.GetStrongFormat(input);

            // Assert
            Assert.AreEqual(expected, resultat);
        }

        [DataTestMethod]
        [DataRow("Salut", "<i>Salut</i>")]
        [DataRow("Test en italique", "<i>Test en italique</i>")]
        [DataRow("", "<i></i>")]
        [DataRow("456", "<i>456</i>")]
        [DataRow("Texte avec espace", "<i>Texte avec espace</i>")]
        public void GetItalicFormat_TestePlusieursScenarios(string input, string expected)
        {
            // Act
            var resultat = _helper.GetItalicFormat(input);

            // Assert
            Assert.AreEqual(expected, resultat);
        }

        [TestMethod]
        [DataRow(new[] { "Item1", "Item2", "Item3" }, "<ul><li>Item1</li><li>Item2</li><li>Item3</li></ul>")]
        [DataRow(new[] { "Un", "Deux", "Trois" }, "<ul><li>Un</li><li>Deux</li><li>Trois</li></ul>")]
        [DataRow(new[] { "" }, "<ul><li></li></ul>")]
        [DataRow(new string[0], "<ul></ul>")]
        [DataRow(new[] { "A", "B", "C", "D" }, "<ul><li>A</li><li>B</li><li>C</li><li>D</li></ul>")]
        public void GetFormattedListElements_TestePlusieursListes(string[] contenus, string resultatAttendu)
        {
            // Act
            var resultat = _helper.GetFormattedListElements(new List<string>(contenus));

            // Assert
            Assert.AreEqual(resultatAttendu, resultat);
        }
    }
}
