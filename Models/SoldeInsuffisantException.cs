using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class SoldeInsuffisantException : Exception
    {
        public string soldeInsuffisant {  get; set; }

        public SoldeInsuffisantException(string soldeInsuffisant) : this(soldeInsuffisant, "Solde Insuffisant")
        {

        }

        public SoldeInsuffisantException (string soldeInsuffisant,  string message) : base(message)
        {
            this.soldeInsuffisant = soldeInsuffisant;
        }

    }
}
