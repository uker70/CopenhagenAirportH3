using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopenhagenAirportH3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CopenhagenAirportH3Entities ctx = new CopenhagenAirportH3Entities())
            {
                SQLQuery.Query(ctx);
                foreach (Airport airport in ctx.Airports)
                {
                    Console.WriteLine("IATA: "+airport.IATA);
                    Console.WriteLine("Name: "+airport.Name);

                    foreach (Airline routeOwner in airport.Airlines)
                    {
                        Console.WriteLine("Owner: "+routeOwner.Name);
                    }

                    foreach (Airline route in airport.Airlines1)
                    {
                        Console.WriteLine("Route: "+route.Name);
                    }
                    Console.WriteLine("------------");
                }


                Console.ReadKey();
            };
            
        }
    }
}
