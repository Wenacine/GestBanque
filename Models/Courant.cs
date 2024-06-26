﻿namespace Models;

public class Courant : Compte
{
    public Courant(string numero, Personne titulaire) : base (numero, titulaire)   
    {
        
    }

    public Courant(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
    {

    }

    public Courant(string numero, double ligneDeCredit, Personne titulaire ) : base(numero, titulaire)
    {
        LigneDeCredit = ligneDeCredit;
    }


    private double _ligneDeCredit;

    public double LigneDeCredit
    {
        get
        {
            return _ligneDeCredit;
        }

        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("InvalidOperation");
                //Console.WriteLine("La ligne de crédit est strictement positive..."); // => Erreur : Exception
                //return;
            }
            _ligneDeCredit = value;
        }
    }

    public override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);

        if(Solde - montant < 0)
        {
            PassageEnNegatif();
        }

    }

    protected override double CalculInteret()
    {
        if(Solde > 0)
        {
            return Solde * (3 / 100);
        }
        return Solde * (9.75 / 100);
    }
}