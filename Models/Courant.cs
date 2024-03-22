namespace Models;

public class Courant
{
    public string Numero;
    public double _Solde;
    public double Solde { get => Solde; private set => Solde = value; }
    public double LigneDeCredit = 0;
    public Personne Titulaire;


public void Retrait(double montant)
{
    if (montant < 0)
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

}
