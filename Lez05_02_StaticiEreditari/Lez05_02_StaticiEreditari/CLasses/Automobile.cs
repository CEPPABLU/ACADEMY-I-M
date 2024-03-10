using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_02_StaticiEreditari.CLasses
{
    internal class Automobile : Giocattolo
    {

        public bool HasBatterie { get; set; } = false;

        public Automobile() // Inizializziamo il giocattolo
        {
            Console.WriteLine($"[AUTOMOBILE] costruttore invocato, sono il giocattolo {Contatore}");
            
        }
    }
}
