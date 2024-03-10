using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_02_StaticiEreditari.CLasses
{
    internal class Trenino : Giocattolo
    {
        public bool HasRotaie { get; set; }

        public Trenino() 
        {
            Console.WriteLine($"[TRENINO] costruttore invocato, sono il giocattolo {Contatore}");
        }

        public  void rumoreTrenino()
        {
            Console.WriteLine("Ciuff Ciuff");
        }
    }
}
