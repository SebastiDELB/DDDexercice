using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class RH
    {
        private Guid RHID;
        private string nom;
        private string prenom;
        private string mail;

        public RH(string unNom, string unPrenom, string unMail)
        {
            this.RHID = new Guid();
            this.nom = unNom;
            this.prenom = unPrenom;
            this.mail = unMail;
        }

        public void CreationEntretien(Creneau unCreneau, List<Recruteur> desRecruteurs, Candidat unCandidat)
        {
            Entretien unEntretien = new Entretien(unCreneau, desRecruteurs, unCandidat);
        }
    }
}
