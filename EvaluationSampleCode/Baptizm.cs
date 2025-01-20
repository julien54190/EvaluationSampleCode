using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode
{
    public class Baptizm
    {
        public ClergyMember ClergyMember { get; set; }

        public Baptizm(ClergyMember clergyMember)
        {
            ClergyMember = clergyMember;
        }

        // Can be baptized by any priest or any pope
        public bool CanBeBaptizedBy(ClergyMember clergyMember)
        { 
            return clergyMember.IsPriest || clergyMember.IsPope;
        }

        // Can only be teached by created ClergyMember
        public bool CanBeTeachedBy(ClergyMember clergyMember)
        {
            return  clergyMember == ClergyMember;
        }
    }

    // Cette classe est uniquement là pour l'implémentation du dessus
    // Pas de test à réaliser
    public class ClergyMember
    {
        public bool IsPriest { get; set; }
        public bool IsPope { get; set; }

        public ClergyMember()
        {
            IsPriest = false;
            IsPope = false;
        }
    }
}
