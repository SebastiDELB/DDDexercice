using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Salle
    {
        public Guid salleID { get; private set; }
        public int numero { get; private set; }
        public Entretien entretien { get; private set; }
        public string nom { get; private set; }

        public Salle(int unNumero, Entretien unEntretien, string unNom)
        {
            this.salleID = Guid.NewGuid();
            this.numero = unNumero;
            this.entretien = unEntretien;
            this.nom = unNom;
        }
    }
}
