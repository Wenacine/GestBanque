using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ToolsTest
{
    
    public class TestPersonne
    {

        //[InlineData("John", null)]
        //[InlineData(null, "Doe")]
        //[InlineData(null, null)]

        [Fact]
        public void testDonneesPersonne()
        {
            //Arrange
            DateTime anniversaire = new DateTime(1970, 1, 1);

            //Act
            Personne personne = new Personne("Doe","John", anniversaire);

            //Assert
            Assert.NotNull(personne);
            Assert.Equal("Doe", personne.Nom);
            Assert.Equal("John", personne.Prenom);
            Assert.Equal(anniversaire, personne.DateNaiss);
        } 
    }
}
