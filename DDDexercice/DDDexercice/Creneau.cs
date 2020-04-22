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

        public Creneau(DateTime dateCreneau, int duree)
        {
            if(dateCreneau == null)
            {
                throw new NotImplementedException("il faudrait préciser la date");
            }
            if (duree != 0)
            {
                throw new Exception("il faudrait préciser la durée");
            }
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
