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
                return;

                numeroCompte.Remove(numero);
        }
    }
}
