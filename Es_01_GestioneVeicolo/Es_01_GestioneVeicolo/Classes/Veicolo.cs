using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Es_01_GestioneVeicolo.Classes
{
    internal abstract class Veicolo
    {
        public string? Marca {  get; set; }
        public int Cilindrata { get; set; }

        public abstract void stampaDettagli();
    }
}
