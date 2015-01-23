using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individuele_Opdracht;


namespace Kieskeurig

        [TestMethod]
        public void NamePropTest()
        {
            Person p = new Person();

            p.Name = "Jan";
            p.Surname = "Roelofsen";

            Assert.AreEqual("Jan Roelofsen", p.FullName);
        }

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