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
        private List<Recruteur> recruteurs;
        private Candidat candidat;

        private enum lesStatus
        {
            enAttente,
            annule,
            accepte
        };
        public Entretien(Creneau unCreneau, List<Recruteur> desRecruteurs, Candidat unCandidat)
        {
            this.entretienid = new Guid();
            this.creneau = unCreneau;
            this.statut = lesStatus.enAttente;
            this.creneau = unCreneau;
            desRecruteurs.ForEach(delegate(Recruteur recruteur)
            {
                this.recruteurs.Add(recruteur);
            });
            this.candidat = unCandidat;
        }
        public void Confirmer()
        {
            this.statut = lesStatus.accepte;
        }
        //d'après les consignes, on ne sauvegarde pas la raison de annulé, ce qui est inutile donc de la réclamer en paramètre
        public void Annuler(string raison)
        {
            this.statut = lesStatus.annule;
        }
    }
}
