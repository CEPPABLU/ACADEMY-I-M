using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Eser_02
{
    internal class CodiceFiscale
    {
        public string? Codice { get; set; }

        public string? DataDiScadenza { get; set; }

        public override string ToString()
        {
            return $"[Codice Fiscale]\n {Codice}\n {DataDiScadenza}";
        }

        
    }
}
