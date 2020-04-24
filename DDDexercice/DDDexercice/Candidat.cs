using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Candidat
    {
        public Guid candidatID { get; private set; }
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public int age { get; private set; }
        public string mail { get; private set; }
        public Profil profil { get; private set; }
        public string CV { get; private set; } // il faut mettre un file ici mais dans le cadre de l'exercice, pour les tests, on va juste mettre un string pour simplifier

        public Candidat(string unNom, string unPrenom, int unAge, string unMail, Profil unProfil, string unCV)
        {
            this.candidatID = Guid.NewGuid();
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
        public void AnnuleEntretien(Entretien unEntretien,string unAvis)
        {
            unEntretien.Annuler(unAvis);
        }
    }
}
