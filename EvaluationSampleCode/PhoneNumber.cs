using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode
{
    public class PhoneNumber
    {
        public string Area { get; }
        public string Major { get; }
        public string Minor { get; }

        // Exemple : 0123456789 est un numéro valable
        // Area : 012
        // Major : 345
        // Minor : 6789
        private PhoneNumber(string area, string major, string minor)
        {
            Area = area;
            Major = major;
            Minor = minor;
        }

        // Attention, cette méthode est static est a pour objectif de retourner un PhoneNumber instancié
        public static PhoneNumber Parse(string number)
        {
            if (String.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Phone number cannot be blank.");

            if (number.Length != 10)
                throw new ArgumentException("Phone number should be 10 digits long.");

            var area = number.Substring(0, 3);
            var major = number.Substring(3, 3);
            var minor = number.Substring(6);

            return new PhoneNumber(area, major, minor);
        }

        // A tester uniquement sur un PhoneNumber instancié via correctement par la méthode Parse
        public override string ToString()
        {
            return String.Format($"({Area}){Major}-{Minor}");
        }
    }
}
