using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal interface ICustomer
    {
        double Solde {  get; }

        void Depot(double Montant);
        void Retrait(double Montant);
    }
}
