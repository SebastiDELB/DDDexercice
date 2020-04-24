using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Creneau
    {
        public Guid creneauID { get; private set; }
        public DateTime date { get; private set; }
        public int heureDebut { get; private set; }
        public int heureFin { get; private set; }


        public Creneau(DateTime dateCreneau, int dureeEnMinute)
        {
            DayOfWeek Samedi = DayOfWeek.Saturday;
            DayOfWeek dimanche = DayOfWeek.Sunday;
            const int heureMinimaleDeDebut = 8;
            const int heureMaxDeFin = 22;

            if (dureeEnMinute <= 0)
            {
                throw new ArgumentNullException("il faudrait préciser la durée");
            }
            if (dateCreneau.DayOfWeek == Samedi || dateCreneau.DayOfWeek == dimanche)
            {
                throw new Exception("C'est le week end, go nextflix");
            }
            if (dateCreneau.Hour < heureMinimaleDeDebut)
            {
                throw new Exception("il est trop tôt");
            }
            if ((dateCreneau.Hour + (dureeEnMinute / 60))> heureMaxDeFin)
            {
                throw new Exception("Faut pas abuser sur l'heure coco");
            }
            this.date = dateCreneau;
            this.heureDebut = dateCreneau.Hour;
            this.heureFin = heureDebut + dureeEnMinute;
            this.creneauID = Guid.NewGuid();
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
