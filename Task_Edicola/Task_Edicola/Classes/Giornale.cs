using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Edicola.Classes
{
    internal class Giornale : Pubblicazioni
    {

        public string? Redazione { get; set; }
        //public static int ContatoreGiornale { get; private set; }
        public Giornale(string? redazione, string? codice, int? stock, int vendite)
        {
            Redazione = redazione;
            Codice = codice;
            Stock = stock;
            Vendite = vendite;
            //ContatoreGiornale++;
        }
        public override void stampaDettagli()
        {
            Console.WriteLine($"[GIORNALE] Redazione: {Redazione}, Cod.Univoco: {Codice}, Quantità: {Stock}" +
                $" Unità Vendute: {Vendite}");
        }
    }
}
