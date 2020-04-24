using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace UnitTestProject1
{
    [TestClass]
    public class TestSalle
    {
        [TestMethod]
        public void CreationSalle()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
            Creneau unCreneau = new Creneau(DateTime.Now, 120);
            Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);
            Salle salle = new Salle(37, entretien, "Salle Mireille");
            Assert.AreEqual("Salle Mireille", salle.nom);
        }
    }
}
