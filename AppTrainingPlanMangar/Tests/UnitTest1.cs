using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjektZaliczeniowy;

namespace TestyProjektu
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CwiczenieNazwaUstawionaKonstruktoremTest()
        {
            //Arrange
            Cwiczenie cw;
            string nazwa = "Cwiczenie1";
            //Act
            cw = new Cwiczenie(nazwa);
            //Assert
            Assert.AreEqual(nazwa, cw.Nazwa);
        }
        [TestMethod]
        public void CwiczeniePorownywanieKategoriaNazwaTest()
        {
            //Arrange
            var cw1 = new Cwiczenie(KatergoraCw.Brzuch, "Rowerek");
            var cw2 = new Cwiczenie(KatergoraCw.Brzuch, "Brzuszki");
            int wynik = 0;
            //Act
            wynik = cw1.CompareTo(cw2);
            //Assert
            Assert.AreEqual(1, wynik);
        }
        [TestMethod]
        public void ObliczIloscPowtorzenTest()
        {
            //Arrange 
            SzczegolyCwiczenia szcw = new SzczegolyCwiczenia()
            {
                Powtorzenia = "8",
                Serie = "4"
            };
            int wynik = 0;
            //Act
            wynik = szcw.ObliczIloscPowtorzen();
            //Assert
            Assert.AreEqual(wynik, 4 * 8);
        }
        [TestMethod]
        [ExpectedException(typeof(LetterException))]
        public void CwiczenieZlaNazwaTest()
        {
            //Arrange
            Cwiczenie cw = new Cwiczenie();
            string zlaNazwa = "cwiczenie";
            //Act
            cw.Nazwa = zlaNazwa;
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(Number1Exception))]
        public void SzczegolyCwiczeniaZleSerieTest()
        {
            //Arrange
            SzczegolyCwiczenia scw = new SzczegolyCwiczenia();
            string serie = "10";
            //Act
            scw.Serie = serie;
            //Arrange
        }
    }
}
