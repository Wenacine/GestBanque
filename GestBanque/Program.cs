using Models;

namespace GestBanque;

class Program
{
    static void Main(string[] args)
    {
        #region Celsius Fahrenheit
        Celsius celsius = new Celsius() { Temperature = 30};
        Fahrenheit fahrenheit = celsius; //Utilisation surcharge d'opérateur de conversion implicite
        Console.WriteLine($"{celsius.Temperature} °C -> {fahrenheit.Temperature}°F");
        celsius = (Celsius) fahrenheit;
        Console.WriteLine($"{fahrenheit.Temperature}° F -> {celsius.Temperature}°C");
        #endregion

        Banque banque = new Banque("MyFavouriteBank");

        Personne doeJohn = new Personne("Doe","John", new DateTime(1970, 1, 1));

        /*Courant courant = new Courant()
        {
            Numero = "0001",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        Courant courant1 = new Courant()
        {
            Numero = "0001",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        Courant courant2 = new Courant()
        {
            Numero = "0001",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        Epargne epargne = new Epargne()
        {
            Numero = "new compte",
            Titulaire = doeJohn

        };*/

    }
}





    