using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Recruteur
    {
        private Guid recruteurID;
        private string nom;
        private string prenom;
        private string mail;
        List<CompteRendu> compterendus;
        public Recruteur(string unNom, string unPrenom, string email)
        {
            this.recruteurID = new Guid();
            this.nom = unNom;
            this.prenom = unPrenom;
            this.mail = email;
        }
        public void RedactionCompteRendu(string unAvis, Candidat unCandidat)
        {
            CompteRendu unCompteRendu = new CompteRendu(unCandidat, unAvis);
            this.compterendus.Add(unCompteRendu);
        }
        public List<CompteRendu> ListDesCompteRenduRediges()
        {
            return this.compterendus;
        }
    }
}
