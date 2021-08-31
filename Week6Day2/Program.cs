using System;
using System.Linq;
using Week6Day2.Core.Models;
using Week6Day2.EF;

namespace Week6Day2
{
    class Program
    {   
        
        //Istanza di KnightContext:
        private static KnightsContext _knightsContext = new KnightsContext();
        static void Main(string[] args)
        {
            _knightsContext.Database.EnsureCreated(); //per assicurarsi dell'esistenza del db
                                                      //se non esiste lo crea
                                                      //(questo metodo si usa nei test)

            //recuperiamo tutti i cavalieri
            Console.WriteLine("Stampa prima dell'aggiunta: ");
            FetchKnights();

            //aggiungiamo un cavaliere
            AddKnight();

            //recuperiamo tutti i cavalieri dopo l'aggiunta
            Console.WriteLine("Stampa dopo l'aggiunta: ");
            FetchKnights();
        }

        private static void FetchKnights()
        {
            var knights = _knightsContext.Knights.ToList();

            //Stampiamo il numero di record di cavalieri nella tabella db
            Console.WriteLine($"Il numero di cavalieri è  {knights.Count}");

            //Stampiamo i nomi dei cavalieri nel db
            foreach( var k in knights)
            {
                Console.WriteLine($"{k.FirstName}, {k.LastName}");
            }
        }

        private static void AddKnight()
        {
            var newKnight = new Knight { FirstName = "Orar", LastName = "Pinco" }; //avrà una lista di armi vuota

            _knightsContext.Knights.Add(newKnight);

            _knightsContext.SaveChanges();

        }
    }
}
