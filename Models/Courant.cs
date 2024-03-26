﻿namespace Models;

public class Courant : Compte
{
    private double _ligneDeCredit;

    public double LigneDeCredit
    {
        get
        {
            return _ligneDeCredit;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("La ligne de crédit est strictement positive..."); // => Erreur : Exception
                return;
            }
            _ligneDeCredit = value;
        }
    }

    public override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);
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