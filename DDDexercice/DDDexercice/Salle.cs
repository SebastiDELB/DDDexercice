using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Salle
    {
        private Guid salleID;
        private int numero;
        private Entretien entretien;
        private string nom;

        public Salle(int unNumero, Entretien unEntretien, string unNom)
        {
            this.salleID = new Guid();
            this.numero = unNumero;
            this.entretien = unEntretien;
            this.nom = unNom;
        }
    }
}
