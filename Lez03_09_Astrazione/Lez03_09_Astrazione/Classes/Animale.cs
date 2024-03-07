using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_09_Astrazione.Classes
{
    internal abstract class Animale
    {
        public bool HasPelo { get; set; }
        public int NumZamp { get; set; }
        public bool Vola { get; set; }

        public string? Nome { get; set; }

        public abstract void versoEmesso(); //Il metodo astratto non ha il corpo
        
    }
}
