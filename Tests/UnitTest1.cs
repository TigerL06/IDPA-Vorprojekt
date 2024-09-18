using System;
using Gewinnverteilung;


namespace Tests
{
    [TestClass]
        public class BerechnungTests
        {
            [TestMethod]
            public void BeitragReserven()
            {
                // Arrange
                FinanzDaten finanzDaten = new FinanzDaten();
                finanzDaten.Daten(gewinn: 10000, aktie: 5000, parti: 2000, gesetz: 100, vort: 1000, div: 5);
                Berechnung berechnung = new Berechnung(finanzDaten);

                // Act
                var result = berechnung.BeitragReserven();

                // Assert
                Assert.AreEqual(500, result);  // 5% von 10000
            }
        
             [TestMethod]
            public void BeitragReserven_BeiNullGewinn()
            {
                // Arrange
                FinanzDaten finanzDaten = new FinanzDaten();
                finanzDaten.Daten(gewinn: 0, aktie: 5000, parti: 2000, gesetz: 300, vort: 100, div: 5);
                Berechnung berechnung = new Berechnung(finanzDaten);

                // Act
                var result = berechnung.BeitragReserven();

                // Assert
                Assert.AreEqual(-1, result);//-1, weil diese Zahl der Klasse BenutzerInteraktion sagt, dass es keinen Gewinn gab.
            }

            [TestMethod]
            public void BeitragDividende()
            {
                // Arrange
                FinanzDaten finanzDaten = new FinanzDaten();
                finanzDaten.Daten(gewinn: 10000, aktie: 5000, parti: 2000, gesetz: 300, vort: 100, div: 10);
                Berechnung berechnung = new Berechnung(finanzDaten);

                // Act
                var result = berechnung.BeitragDividende();

                // Assert
                Assert.AreEqual(1000, result);  // 10% von 10000
            }

            [TestMethod]

            public void BeitragAktie()
            {
                // Arrange
                FinanzDaten finanzDaten = new FinanzDaten();
                finanzDaten.Daten(10000, 6000, 2000, 3000, 1000, 10);
                var berechnung = new Berechnung(finanzDaten);
                berechnung.BeitragDividende();  // Berechnung des Dividendbeitrags

                // Act
                double result = berechnung.BeitragAktie();

                // Assert
                Assert.AreEqual(750, result);  // Beitrag Aktie = 1000 / 5000
            }

            [TestMethod]

            public void BeitragPati()
            {
                // Arrange
                var finanzDaten = new FinanzDaten();
                finanzDaten.Daten(gewinn: 10000, aktie: 6000, parti: 2000, gesetz: 3000, vort: 1000, div: 10);
                var berechnung = new Berechnung(finanzDaten);
                berechnung.BeitragDividende();  // Berechnung des Dividendbeitrags

                // Act
                double result = berechnung.BeitragPati();

                // Assert
                Assert.AreEqual(250, result);  // Beitrag Partizipal = 1000 / 2000
            }

            [TestMethod]

            public void VortragPos()
            {
                // Arrange
                var finanzDaten = new FinanzDaten();
                finanzDaten.Daten(gewinn: 10000, aktie: 6000, parti: 2000, gesetz: 3000, vort: 1000, div: 10);
                var berechnung = new Berechnung(finanzDaten);

                // Act
                var test = berechnung.BeitragDividende();
                var result = berechnung.VortragPos();

                // Assert
                Assert.AreEqual(10000, result);  // Vortrag Pos = 10000 - 1000 + 1000
            }


            [TestMethod]
            public void VortragNeg()
            {
                // Arrange
                var finanzDaten = new FinanzDaten();
                finanzDaten.Daten(gewinn: 10000, aktie: 5000, parti: 5000, gesetz: 3000, vort: -1000, div: 10);
                var berechnung = new Berechnung(finanzDaten);

                // Act
                var test = berechnung.BeitragDividende();
                var result = berechnung.VortragPos();

                // Assert
                Assert.AreEqual(8000, result);  // Vortrag Neg = 10000 - 1000 - 1000
            }
        }

}