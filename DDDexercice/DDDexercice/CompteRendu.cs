using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class CompteRendu
    {
        private Guid compterenduID;
        private string avis;
        private Candidat candidat;

        public CompteRendu(Candidat unCandidat, string unAvis)
        {
            this.compterenduID = new Guid();
            this.avis = unAvis;
            this.candidat = unCandidat;
        }
        public CompteRendu AffichageCompteRendu()
        {
            return this;
        }
    }
}
