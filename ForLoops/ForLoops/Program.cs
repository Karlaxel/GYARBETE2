using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            x = 5;
           int c = 2 + x * 7;
            Console.WriteLine(c);
            // int i = 0;   Vi definierar vår räknare i for-loopen. Datorer börjar alltid räkna från och med 0.
            // i < 20;      Kan ses som en if-sats. Loopen körs när uttrycket är sant, dvs. medan i är mindre än 20. OBS. Inte lika med tjugo!
            // i++;         Addera räkne-variabeln med 1. Kan även skrivas i = i + 1; eller i += 1;

            // For-loopen körs 20 gånger, från och med att i är 0 tills i är 19.
            for (int i = 0; i < 20; i++)
            {
                // Om resten från i / 2 är noll, kör koden nedan.
                // Läs mer om modulo operatorn (%) i boken på sida 53-54.
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " är ett jämnt tal");
                }
                else // Annars blir det rest från divisionen.
                {
                    Console.WriteLine(i + " är ett ojämnt tal");
                }
            }

            Console.ReadLine();
        }
    }
}
