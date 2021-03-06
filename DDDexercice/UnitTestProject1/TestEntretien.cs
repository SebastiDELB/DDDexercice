﻿using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class TestEntretien
    {
        DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
        Creneau unCreneau = new Creneau(DateTime.Now, 120);
        Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");

        [TestMethod]
        public void CreationEntretien()
        {
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);

            Assert.AreEqual("enAttente", entretien.statuts.ToString());
        }
        [TestMethod]
        public void AcceptationEntretien()
        {
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);
            entretien.Confirmer();

            Assert.AreEqual("accepte", entretien.statuts.ToString());
        }
        [TestMethod]
        public void AnnulationEntretien()
        {
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);
            entretien.Annuler("avis");

            Assert.AreEqual("annule", entretien.statuts.ToString());
        }
        [TestMethod]
        public void RetirerUnRecruteurDeLEntretien()
        {
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);
            Recruteur recruteur1 = new Recruteur("Waza", "Michel", "michel.waza@gmail.com");

            entretien.AjoutRecruteur(recruteur1);
            entretien.RetireRecruteur(recruteur1);

            Assert.AreEqual(0, entretien.ListDesRecruteurs().Count());
        }

            
    }
}
