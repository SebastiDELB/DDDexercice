using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class CompteRendu
    {
        public Guid compterenduID { get; private set; }
        public string avis { get; private set; }
        public Candidat candidat { get; private set; }
        public Recruteur recruteur { get; private set; }

        public CompteRendu(Candidat unCandidat, string unAvis, Recruteur unRecruteur)
        {
            this.compterenduID = Guid.NewGuid();
            this.avis = unAvis;
            this.candidat = unCandidat;
            this.recruteur = unRecruteur;
        }
        public CompteRendu AffichageCompteRendu()
        {
            return this;
        }
    }
}
