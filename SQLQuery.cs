using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopenhagenAirportH3
{
    class SQLQuery
    {
        public static void Query(CopenhagenAirportH3Entities ctx)
        {
            Airport cph = new Airport(){IATA = "CPH", Name = "Copenhagen"};
            Airport cai = new Airport() {IATA = "CAI", Name = "Cairo"};
            Airport aar = new Airport() {IATA = "AAR", Name = "Arhus"};
            Airport aal = new Airport() {IATA = "AAL", Name = "Aalborg"};
            Airport ams = new Airport() {IATA = "AMS", Name = "Amsterdam"};
            Airport lax = new Airport() {IATA = "LAX", Name = "Los Angeles"};

            ctx.Airports.Add(cph);
            ctx.Airports.Add(cai);
            ctx.Airports.Add(aar);
            ctx.Airports.Add(aal);
            ctx.Airports.Add(ams);
            ctx.Airports.Add(lax);

            Airline sas = new Airline() { Name = "SAS" };
            Airline klm = new Airline() { Name = "KLM" };
            Airline nostrum = new Airline() { Name = "Air Nostrum" };
            Airline norwegwian = new Airline() { Name = "Norwegian" };
            Airline egyptAir = new Airline() { Name = "EgyptAir" };

            ctx.Airlines.Add(sas);
            ctx.Airlines.Add(klm);
            ctx.Airlines.Add(nostrum);
            ctx.Airlines.Add(norwegwian);
            ctx.Airlines.Add(egyptAir);

            ctx.Airports.Find(cph).Airlines.Add(sas);
            ctx.Airports.Find(aar).Airlines.Add(sas);
            ctx.Airports.Find(aal).Airlines.Add(sas);
            ctx.Airports.Find(cai).Airlines.Add(egyptAir);
            ctx.Airports.Find(ams).Airlines.Add(klm);
            ctx.Airports.Find(lax).Airlines.Add(nostrum);

            ctx.Airports.Find(aar).Airlines1.Add(sas);
            ctx.Airports.Find(aar).Airlines1.Add(norwegwian);
            ctx.Airports.Find(aal).Airlines1.Add(sas);
            ctx.Airports.Find(cai).Airlines1.Add(egyptAir);
            ctx.Airports.Find(ams).Airlines1.Add(klm);
            ctx.Airports.Find(ams).Airlines1.Add(sas);
            ctx.Airports.Find(lax).Airlines1.Add(nostrum);

        }
    }
}
