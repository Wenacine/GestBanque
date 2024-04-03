using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsTest
{

    public class TestCourant
    {
        [Fact]
        public void RetraitWithValidAmount()
        {
            //Arrange
            Personne titulaire = new Personne("Doe", "John", DateTime.Now);
            Courant courant = new Courant("0001", titulaire);
            courant.Depot(100);

            //Act
            courant.Retrait(5);

            //Assert
            Assert.Equal(95, courant.Solde);
        }
    }
}
