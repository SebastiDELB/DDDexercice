using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Profil
    {
        public Guid profilID { get; private set; }
        public string specialite { get; private set; }
        public int nombreAnneeExperience { get; private set;}
        public string technoMaitrisees { get; private set; }
        public string softSkills { get; private set; }

        public Profil(string uneSpecialite, int unNombreAnneeExperience, string desTechnoMaitrisees, string desSoftSkills)
        {
            this.profilID = Guid.NewGuid();
            this.specialite = uneSpecialite;
            this.nombreAnneeExperience = unNombreAnneeExperience;
            this.technoMaitrisees = desTechnoMaitrisees;
            this.softSkills = desSoftSkills;
        }
    }
}
