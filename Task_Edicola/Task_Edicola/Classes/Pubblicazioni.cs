using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Edicola.Classes
{
    internal abstract class Pubblicazioni
    {
        public string? Codice { get; set; }
        public int? Stock { get; set; }
        public int? Vendite { get; set; }

        //public static int contatore { get; private set; } = 0;

        //public static int Contatore
        //{
        //    get { return contatore; }
        //}
        public abstract void stampaDettagli();
    }
}
