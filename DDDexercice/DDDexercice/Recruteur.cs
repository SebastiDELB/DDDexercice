using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Recruteur
    {
        public Guid recruteurID { get; private set; }
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public string mail { get; private set; }
        public Recruteur(string unNom, string unPrenom, string email)
        {
            this.recruteurID = Guid.NewGuid();
            this.nom = unNom;
            this.prenom = unPrenom;
            this.mail = email;
        }
        public void ParticipeAUnEntretien(Entretien unEntretien)
        {
            unEntretien.recruteurs.Add(this);
        }
        public void SeRetireDeLEntretien(Entretien unEntretien)
        {
            unEntretien.RetireRecruteur(this);
        }
    }
}
