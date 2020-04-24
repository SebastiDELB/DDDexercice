using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCandidat
    {
        DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
        Creneau unCreneau = new Creneau(DateTime.Now, 120);
        Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");

        [TestMethod]
        public void EntretienAccepteParLeCandidat()
        {
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);
            candidat.ConfirmeEntretien(entretien);
            Assert.AreEqual("accepte", entretien.statuts.ToString());
        }
        [TestMethod]
        public void EntretienAnnuleParLeCandidat()
        {
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);
            string avis = ("parce que c'est un test et que voila");
            candidat.AnnuleEntretien(entretien, avis);
            Assert.AreEqual("annule", entretien.statuts.ToString());
        }
        [TestMethod]
        public void CreationNouveauCandidat()
        {
            Candidat candidat = new Candidat("Deuspi", "Erik", 43, "erik.deuspi@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Assert.AreEqual("Deuspi", candidat.nom);
        }
    }
}
