using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Creneau : ValueObject
    {
        public DateTime date { get; private set; }
        public int heureDebut { get; private set; }
        public int heureFin { get; private set; }

        private Creneau() { }

        public Creneau(DateTime dateCreneau, int duree)
        {
            date = dateCreneau;
            heureDebut = dateCreneau.Hour;
            heureFin = heureDebut + duree;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return date;
            yield return heureDebut;
            yield return heureFin;
        }
    }
}
