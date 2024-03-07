using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_09_Astrazione.Classes
{
    internal class Cane : Animale
    {
        public Cane() { }
        public Cane(string? nome)
        {
           Nome = nome;
        }

        public string V { get; }

        public override void versoEmesso()
        {
            Console.WriteLine($"{Nome} fa BAU");
        }
    }
}
