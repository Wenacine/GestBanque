using Models;

namespace GestBanque;

class Program
{
    static void Main(string[] args)
    {
        Courant courant = new Courant();
        courant.Depot(1000);
        courant.Retrait(500);
    }
}





    