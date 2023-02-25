using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19
{
    public class Covid
    {
        public long updated { get; set; }
        public string country { get; set; }
        public int cases { get; set; }
        public int todayCases { get; set; }
        public int deaths { get; set; }
        public int todayDeaths { get; set; }
        public int recovered { get; set; }
        public int todayRecovered { get; set; }
        public int active { get; set; }
        public int critical { get; set; }
        public int casesPerOneMillion { get; set; }
        public int deathsPerOneMillion { get; set; }
        public int tests { get; set; }
        public int testsPerOneMillion { get; set; }
        public int population { get; set; }
        public string continent { get; set; }
        public int oneCasePerPeople { get; set; }
        public int oneDeathPerPeople { get; set; }
        public int oneTestPerPeople { get; set; }
        public double activePerOneMillion { get; set; }
        public double recoveredPerOneMillion { get; set; }
        public double criticalPerOneMillion { get; set; }
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Hospitalized { get; set; }
        public int Deaths { get; set; }
        public int NewConfirmed { get; set; }
        public int NewRecovered { get; set; }
        public int NewHospitalized { get; set; }
        public int NewDeaths { get; set; }
        public string UpdateDate { get; set; }
        public string DevBy { get; set; }
    }
}
