using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void NullReferenceExceptioneDeclarationCreneau()
        {
            Assert.ThrowsException<ArgumentNullException>(delegate { Creneau unCreneau = new Creneau(DateTime.Now, 0); });

        }
        [TestMethod]
        public void ExceptionSurLeJourDeLaSemaineDeclarationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 19);
            Assert.ThrowsException<Exception>(delegate { Creneau unCreneau = new Creneau(date, 120); });
        }
        [TestMethod]
        public void ExceptionHeureDeDebutDeclarationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 19, hour:7, minute: 49, second: 03);
            Assert.ThrowsException<Exception>(delegate { Creneau unCreneau = new Creneau(date, 120); });
        }
        [TestMethod]
        public void ExceptionHeureDeFinDeclarationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 19, hour:21, minute: 30, second:00);
            Assert.ThrowsException<Exception>(delegate { Creneau unCreneau = new Creneau(date, 120); });
        }
        [TestMethod]
        public void EntretienAccepte()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
            Creneau unCreneau = new Creneau(DateTime.Now, 120);
            Recruteur recruteur1 = new Recruteur("Duran", "Stephane", "duran.stephane@gmail.com");
            Recruteur recruteur2 = new Recruteur("L'éponge", "Bob", "bobl'éponge@gmail.com");
            List<Recruteur> desRecruteurs = new List<Recruteur>();
            desRecruteurs.Add(recruteur1);
            desRecruteurs.Add(recruteur2);
            Profil profil = new Profil("C#", 8,"C#, Java, JS","CQRS, DevOps");
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, desRecruteurs, candidat);
            entretien.Confirmer();
            Assert.AreEqual("accepte", entretien.statuts.ToString());
        }
        [TestMethod]
        public void EntretienAnnule()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
            Creneau unCreneau = new Creneau(DateTime.Now, 120);
            Recruteur recruteur1 = new Recruteur("Duran", "Stephane", "duran.stephane@gmail.com");
            Recruteur recruteur2 = new Recruteur("L'éponge", "Bob", "bobl'éponge@gmail.com");
            List<Recruteur> desRecruteurs = new List<Recruteur>();
            desRecruteurs.Add(recruteur1);
            desRecruteurs.Add(recruteur2);
            Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Entretien entretien = new Entretien(unCreneau, desRecruteurs, candidat);
            entretien.Annuler("parce que c'est un test et que voila");
            Assert.AreEqual("annule", entretien.statuts.ToString());
        }
        [TestMethod]
        public void CreationNouveauCandidat()
        {
            Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Assert.AreEqual("Wow", candidat.nom);
        }
        [TestMethod]
        public void NouveauCandidatConfirmeEntretien()
        {
            Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
            Creneau unCreneau = new Creneau(DateTime.Now, 120);
            Recruteur recruteur1 = new Recruteur("Duran", "Stephane", "duran.stephane@gmail.com");
            Recruteur recruteur2 = new Recruteur("L'éponge", "Bob", "bobl'éponge@gmail.com");
            List<Recruteur> desRecruteurs = new List<Recruteur>();
            desRecruteurs.Add(recruteur1);
            desRecruteurs.Add(recruteur2);
            Entretien entretien = new Entretien(unCreneau, desRecruteurs, candidat);
            candidat.ConfirmeEntretien(entretien);
            Assert.AreEqual("accepte", entretien.statuts.ToString());
        }
        [TestMethod]
        public void CreationCompteRendu()
        {
            Recruteur recruteur = new Recruteur("Duran", "Stephane", "duran.stephane@gmail.com");
            Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");
            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            CompteRendu compteRendu = new CompteRendu(candidat, "Très bon élément prometteur", recruteur);
            Assert.AreEqual("Très bon élément prometteur", compteRendu.avis);
        }
    }
}
