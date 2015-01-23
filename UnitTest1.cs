using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individuele_Opdracht;


namespace Kieskeurig
{


    [TestClass]
    public class UnitTest
    {

        /// <summary>
        /// Testmethode om te kijken of de naam van het product klopt
        /// </summary>
        [TestMethod]
        public void TestProductNaam()
        {
            string expected = "Samsung E100";
            DatabaseMng databasemng = new DatabaseMng();
            Product p = databasemng.GetProduct("Samsung E100");
            string result = p.Naam;
            //verwachte result is true
            Assert.AreEqual(expected, result);
        }
        
    }
}