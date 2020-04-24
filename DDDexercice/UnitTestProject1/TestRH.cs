using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TestRH
    {
        DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
        Creneau unCreneau = new Creneau(DateTime.Now, 120);
        Profil profil = new Profil("C#", 8, "C#, Java, JS", "CQRS, DevOps");

        [TestMethod]
        public void CreationRH()
        {
            RH rh = new RH("babi", "myrtille", "myrtille.babi@gmail.com");
            Assert.AreEqual("myrtille", rh.prenom);
        }
        [TestMethod]
        public void CreationEntretienParRH()
        {
            RH rh = new RH("babi", "myrtille", "myrtille.babi@gmail.com");

            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");
            Assert.AreEqual(true, rh.CreationEntretien(unCreneau, candidat));
        }
        [TestMethod]
        public void AssignationRecruteurParRH()
        {
            RH rh = new RH("babi", "myrtille", "myrtille.babi@gmail.com");

            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");

            Entretien entretien = new Entretien(unCreneau, candidat);

            Recruteur recruteur = new Recruteur("Waza", "Michel", "michel.waza@gmail.com");

            List<Recruteur> listDeRecruteur = new List<Recruteur>();
            listDeRecruteur.Add(recruteur);

            rh.AssigneUnouDesRecruteurAUnEntretien(entretien, listDeRecruteur);

            Assert.AreEqual("Waza", entretien.recruteurs[0].nom);
        }
        [TestMethod]
        public void ChangementDEntretienDUneSalle()
        {

            RH rh = new RH("babi", "myrtille", "myrtille.babi@gmail.com");

            Candidat candidat = new Candidat("Wow", "Gontrand", 43, "gantrand.wow@gmail.com", profil, "ceci est un cv, veuillez lire l'attribut privé de la classe");

           

            Entretien entretien1 = new Entretien(unCreneau, candidat);
            Entretien entretien2 = new Entretien(unCreneau, candidat);

            Recruteur recruteur1 = new Recruteur("Waza", "Michel", "michel.waza@gmail.com");
            Recruteur recruteur2 = new Recruteur("EZ", "Deud", "deud.ez@gmail.com");

            entretien1.AjoutRecruteur(recruteur1);
            entretien2.AjoutRecruteur(recruteur2);

            Salle salle = new Salle(10, entretien1, "Bleu");

            rh.ChangerEntretienDUneSalle(salle, entretien2);

            Assert.AreEqual("EZ", salle.entretien.recruteurs[0].nom);
        }
    }
}
