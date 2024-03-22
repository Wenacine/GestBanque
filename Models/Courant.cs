namespace Models;

public class Courant
{
    private string _numero;
    private double _solde;
    private double _ligneDeCredit = 0;
    private Personne titulaire;

    public string Numero
    {
        get
        {
            return _numero;
        }

        set
        {
            _numero = value;
        }
    }

    public double Solde
    {
        get
        {
            return _solde;
        }

        private set
        {
            _solde = value;
        }
    }

    public double LigneDeCredit
    {
        get
        {
            return _ligneDeCredit;
        }

        set
        {
            if(value < 0){
                Console.WriteLine("La ligne de crédit est strictement positive");
                return;
            }
            _ligneDeCredit = value;
        }
    }

    public Personne Titulaire
    {
        get
        {
            return titulaire;
        }

        set
        {
            titulaire = value;
        }
    }

    public void Retrait(double montant)
{
    if (montant <= 0)
    {
        Console.WriteLine($"Vous ne pouvez pas retirer d'argent");
        return;
    }

    //if (montant > Solde + LigneDeCredit) 
    //{
    //    Console.WriteLine("Vous n'avez pas assez d'argent");
    //}

    if((Solde - montant) < -LigneDeCredit)
    {
        Console.WriteLine("Vous n'avez pas assez d'argent");
        return;
        //Console.WriteLine("Vous pouvez retirer de l'argent");
    }

    Solde -= montant;
}

public void Depot(double montant)
{
    if(montant < 0)
    {
        Console.WriteLine("Vous ne pouvez pas déposer l'argent sur le compte.");
        return;
    }

    Solde += montant;
}

    public static double operator + (Courant solde1, Courant solde2)
    {
        if(solde1._solde  <= 0)
        {

        }
    }

}
