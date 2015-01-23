using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individuele_Opdracht;


namespace Kieskeurig
{


    [TestClass]
    public class UnitTest
    {

        /// <summary>
        /// Testmethode om te kijken of de gebruiker met gebruiker ID 1 ook wel echt als voornaam Nathan heeft
        /// </summary>
        [TestMethod]
        public void TestVoornaamGebruiker1()
        {
            string expected = "Nathan";
            string result = string.Empty;
            DatabaseMng databasemng = new DatabaseMng();
            foreach (Gebruiker gebruiker in DatabaseMng.GetGebruiker())
            {
                if (gebruiker.gebruikerID == 1)
                {
                    result = gebruiker.Voornaam;
                }
            }
            Assert.AreEqual(expected, result);
        }

    }
}