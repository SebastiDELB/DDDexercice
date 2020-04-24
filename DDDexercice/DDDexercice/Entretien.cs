using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DDDexercice
{
    public class Entretien
    {
        public Guid entretienid { get; private set; }
        public lesStatus statuts { get; private set; }
        public Creneau creneau { get; private set; }
        public List<Recruteur> recruteurs { get; private set; }
        public Candidat candidat { get; private set; }

        public enum lesStatus
        {
            [Description("enAttente")]
            enAttente,
            [Description("annule")]
            annule,
            [Description("accepte")]
            accepte,
        };
        public Entretien(Creneau unCreneau, Candidat unCandidat)
        {
            this.entretienid = Guid.NewGuid();
            this.creneau = unCreneau;
            this.statuts = lesStatus.enAttente;
            this.creneau = unCreneau;
            this.candidat = unCandidat;
            this.recruteurs = new List<Recruteur>();
        }
        public void Confirmer()
        {
            this.statuts = lesStatus.accepte;
        }
        //d'après les consignes, on ne sauvegarde pas la raison de annulé, ce qui est inutile donc de la réclamer en paramètre
        public void Annuler(string raison)
        {
            this.statuts = lesStatus.annule;
        }
        public List<Recruteur> ListDesRecruteurs()
        {
            return this.recruteurs;
        }
        public void AjoutRecruteur(Recruteur unRecruteur)
        {
            recruteurs.Add(unRecruteur);
        }
    }
}
