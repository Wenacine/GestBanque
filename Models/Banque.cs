using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banque
    {

        public Banque(string nom)
        {
            _comptes = new Dictionary<string, Compte>();
            this.Nom = nom;
        }

        private Dictionary<string, Compte> _comptes;

        public string? Nom { get; init; }

        public Compte? this[string numero]
        {
            get
            {
                if (!_comptes.ContainsKey(numero))
                    return null;

                return _comptes[numero];
            }
        }

        public void Ajouter(Compte compte)
        {
            _comptes.Add(compte.Numero, compte);
            compte.PassageEnNegatifEvent += PassageEnNegatifAction;
        }

        private void PassageEnNegatifAction(Compte compte)
        {
            Console.WriteLine($"« Le compte {compte.Numero} vient de passer en négatif");
        }

        public void Supprimer(string numero)
        {
            if (!_comptes.ContainsKey(numero))
                return;
            Compte compte = this[numero]!;
            _comptes[numero].PassageEnNegatifEvent -= PassageEnNegatifAction;
            _comptes.Remove(numero);
            
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0D;

            //foreach(KeyValuePair<string, Courant> kvp in _comptes)
            //{
            //    if(kvp.Value.Titulaire == titulaire)
            //    {
            //        total += kvp.Value;
            //    }
            //}

            foreach (Compte compte in _comptes.Values)
            {
                if (compte.Titulaire == titulaire)
                {
                    total += compte;
                }
            }

            return total;
        }
    }
}