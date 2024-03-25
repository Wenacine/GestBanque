namespace Models
{
    public class Banque
    {
        
        private string nomBanque { get; set; }

        public string NomBanque
        {
            get
            {
                return nomBanque;
            }

            set
            {
                nomBanque = value;
            }
        }

        private Dictionary<string, Courant> numeroCompte = new Dictionary<string, Courant>(); //Initialiser!
        public Courant? this[string Key]
        {
            get
            {
                if(Key == null)
                {
                    return null;
                }
                if(!numeroCompte.ContainsKey(Key))
                {
                    return null;
                }

                return numeroCompte[Key];

            }
        }

        public void Ajouter(Courant compte)
        {
            numeroCompte.Add(compte.Numero,compte);
        } 

        public void Supprimer(string numero)
        {
            if (!numeroCompte.ContainsKey(numero))
            {
                return;
            }
            else
            {
                numeroCompte.Remove(numero);
            }
                
        }

      public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0D;

       
            /*foreach (KeyValuePair<string, Courant> kvp in numeroCompte)
            {
                if(kvp.Value.Titulaire == titulaire)
                {
                    total += kvp.Value;
                }
            }*/

            foreach (Courant courant in numeroCompte.Values)
            {
                if (courant.Titulaire == titulaire)
                {
                    total += courant;
                }
            }

            return total;
        }

    }

  
}
