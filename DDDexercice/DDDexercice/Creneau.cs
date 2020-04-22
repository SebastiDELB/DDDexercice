using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Creneau
    {
        private DateTime date { get; set; }
        private int heureDebut { get; set; }
        private int heureFin { get; set; }

        Creneau(DateTime dateCreneau, int duree)
        {
            this.date = dateCreneau;
            this.heureDebut = dateCreneau.Hour;
            this.heureFin = heureDebut + duree;
        }

        public bool Equals(DateTime Date)
        {
            if (this.date == Date)
            {
                return true;
            }
            return false;
        }
    }
}
