using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TestProfil
    {
        [TestMethod]
        public void CreationProfil()
        {
            Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");

            Assert.AreEqual(8, profil.nombreAnneeExperience);
        }
    }
}
