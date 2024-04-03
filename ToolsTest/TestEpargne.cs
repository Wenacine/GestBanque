using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ToolsTest
{
    public class TestEpargne
    {
        [Fact]
        public void RetraitPositif()
        {
            Personne john = new Personne("Doe","John", DateTime.Now);
            Epargne epargne = new Epargne("0001", john, 500, DateTime.Now);

            epargne.Depot(500);
            epargne.Retrait(200);

            Assert.Equal(300, epargne.Solde);
        }
        
    }
}
