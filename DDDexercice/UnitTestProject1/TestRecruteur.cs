﻿using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class TestRecruteur
    {
        DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
        Creneau unCreneau = new Creneau(DateTime.Now, 120);
        Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");

        [TestMethod]
        public void CreationNouveauRecruteur()
        {
            Recruteur recruteur = new Recruteur("Waza", "Michel", "michel.waza@gmail.com");
            Assert.AreEqual("Waza", recruteur.nom);
        }
        [TestMethod]
        public void RecruteurConfirmeUnEntretien()
        {
           
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, candidat);
            Recruteur recruteur1 = new Recruteur("Waza", "Michel", "michel.waza@gmail.com");
            recruteur1.ParticipeAUnEntretien(entretien);

            List<Recruteur> tempListDeRecruteur = entretien.ListDesRecruteurs();
            Recruteur recruteurPourTest = tempListDeRecruteur[0];
            Assert.AreEqual("Waza", recruteurPourTest.nom);
        }
        [TestMethod]
        public void RecruteurSeDesisteEAUnEntretien()
        {
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            
            Entretien entretien = new Entretien(unCreneau, candidat);
            
            Recruteur recruteur1 = new Recruteur("Waza", "Michel", "michel.waza@gmail.com");

            entretien.AjoutRecruteur(recruteur1);
            recruteur1.SeRetireDeLEntretien(entretien);

            Assert.AreEqual(0, entretien.ListDesRecruteurs().Count());
        }
    }
}
