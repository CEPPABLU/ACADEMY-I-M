using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eser_02
{
    internal class CartaIdentita
    {
        public string? Codice { get; set; }
        public string? DataDiEmissione { get; set; }
        //public DateTime DataScadenza { get; set; }
        public string? DataDiScadenza { get; set; }
        //public string? Emissione { get; set; }
        private string? emissione;
        public string? Emissione
        {
            get { return emissione; }
            set{
                if (value is not null && (value.Equals ("Comune") || value.Equals("Zecca dello stato")))
                    emissione = value;
                else
                    Console.WriteLine("Errore");                  
            }     
        }
        public override string ToString()
        {
            return $"[Carta di Identità]\n {Codice}\n {DataDiEmissione}\n {DataDiScadenza}\n {Emissione} ";
        }
    }
}
