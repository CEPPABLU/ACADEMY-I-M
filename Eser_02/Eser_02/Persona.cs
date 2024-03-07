using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eser_02
{
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }

        public CartaIdentita? CartaIdentita { get; set; }

        public CodiceFiscale? CodiceFiscale { get; set; }

        public override string ToString()
        {
            return $"[UTENTE]\n {Nome}\n {Cognome}\n{CartaIdentita}\n{CodiceFiscale}";
        }
    }
}
