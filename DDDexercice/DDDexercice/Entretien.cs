using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Entretien
    {
        private Guid entretienid;
        private lesStatus status;
        private Creneau creneau;
        private string recruteur;
        private string candidat;

        private enum lesStatus
        {
            enAttente,
            annule,
            accepte
        };
        public Entretien(Creneau unCreneau, string unRecruteur, string unCandidat)
        {
            entretienid = new Guid();
            creneau = unCreneau;
            status = (lesStatus)0;
            creneau = unCreneau;
            recruteur = unRecruteur;
            candidat = unCandidat;
        }
        public void Confirmer()
        {
            status = (lesStatus)2;
        }
        public void Annuler(string raison)
        {
            status = (lesStatus)1;
        }
    }
}
