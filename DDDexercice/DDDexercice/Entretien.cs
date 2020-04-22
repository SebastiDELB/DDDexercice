using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Entretien
    {
        private Guid entretienid;
        private lesStatus statut;
        private Creneau creneau;
        private string recruteur;
        private string candidat;

        public lesStatus GetStatut()
        {
            return statut;
        }
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
            statut = lesStatus.enAttente;
            creneau = unCreneau;
            recruteur = unRecruteur;
            candidat = unCandidat;
        }
        public void Confirmer()
        {
            statut = lesStatus.accepte;
        }
        public void Annuler(string raison)
        {
            statut = lesStatus.annule;
        }
    }
}
