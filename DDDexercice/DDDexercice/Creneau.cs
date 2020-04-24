using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Creneau
    {
        private Guid creneauID;
        private DateTime date { get; set; }
        private int heureDebut { get; set; }
        private int heureFin { get; set; }


        public Creneau(DateTime dateCreneau, int duree)
        {
            DayOfWeek Samedi = DayOfWeek.Saturday;
            DayOfWeek dimanche = DayOfWeek.Sunday;
            
            if (duree <= 0)
            {
                throw new ArgumentNullException("il faudrait préciser la durée");
            }
            if (dateCreneau.DayOfWeek == Samedi || dateCreneau.DayOfWeek == dimanche)
            {
                throw new Exception("C'est le week end, go nextflix");
            }
            if (dateCreneau.Hour < 8)
            {
                throw new Exception("il est trop tôt");
            }
            if ((dateCreneau.Hour + (duree/60))> 22)
            {
                throw new Exception("Faut pas abuser sur l'heure coco");
            }
            /*if (dateCreneau.DayOfWeek == Samedi || dateCreneau.DayOfWeek == dimanche)
            {
                throw new Exception("C'est le week end, go nextflix");
            }*/
            this.date = dateCreneau;
            this.heureDebut = dateCreneau.Hour;
            this.heureFin = heureDebut + duree;
            this.creneauID = new Guid();
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
