using System;
using System.Collections.Generic;
using System.Text;

namespace DDDexercice
{
    public class Profil
    {
        private Guid profilID;
        private string specialite;
        private int nombreAnneeExperience;
        private string technoMaitrisees;
        private string softSkills;

        public Profil(string uneSpecialite, int unNombreAnneeExperience, string desTechnoMaitrisees, string desSoftSkills)
        {
            this.profilID = new Guid();
            this.specialite = uneSpecialite;
            this.nombreAnneeExperience = unNombreAnneeExperience;
            this.technoMaitrisees = desTechnoMaitrisees;
            this.softSkills = desSoftSkills;
        }
    }
}
