using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class RH
    {
        public Guid RHID { get; private set; }
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public string mail{ get; private set; }

        public RH(string unNom, string unPrenom, string unMail)
        {
            this.RHID = Guid.NewGuid();
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
