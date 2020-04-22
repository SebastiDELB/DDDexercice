using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    class Entretien
    {
        private Guid entretienid;
        private string status;
        private Creneau creneau;
        private string recruteur;
        private string candidat;

        Entretien(Creneau unCreneau, string unRecruteur, string unCandidat)
        {
            entretienid = new Guid();
            status = "en attente";
            creneau = unCreneau;
            recruteur = unRecruteur;
            candidat = unCandidat;
        }
        public void Confirmer()
        {
            status = "accepté";
        }
        public void Annuler(string raison)
        {
            status = "annulé " + raison; 
        }
    }
}
