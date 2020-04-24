using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Candidat
    {
        private Guid candidatID;
        private string nom;
        private string prenom;
        private int age;
        private string mail;
        private Profil profil;
        private string CV; // il faut mettre un file ici mais dans le cadre de l'exercice, pour les tests, on va juste mettre un string pour simplifier

        public Candidat(string unNom, string unPrenom, int unAge, string unMail, Profil unProfil, string unCV)
        {
            this.candidatID = new Guid();
            this.nom = unNom;
            this.prenom = unPrenom;
            this.age = unAge;
            this.mail = unMail;
            this.profil = unProfil;
            this.CV = unCV;
        }

        public void ConfirmeEntretien(Entretien unEntretien)
        {
            unEntretien.Confirmer();
        }
    }
}
