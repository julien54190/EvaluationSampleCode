using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode
{
    // Vous devez utiliser des DataRow pour ces tests (pour vérifier que vous avez bien compris)
    public class MathOperations
    {
        public int Subtract(int numberOne, int numberTwo)
        {
            if (numberOne < numberTwo)
                throw new ArgumentException("Second parameter cannot be higher than first parameter");

            if (numberOne >= 1200)
                throw new ArgumentException("First parameter cannot be higher or equal to 1200");

            return numberOne - numberTwo;
        }

        public string GetColorFromOddsNumber(int number)
        {
            if (number < 0)
                throw new ArgumentException("Limit argument can't be negative");

            if (number % 2 == 0)
                return "Red";

            return "Blue";
        }
    }
}
