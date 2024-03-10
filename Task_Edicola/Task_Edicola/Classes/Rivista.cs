using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Edicola.Classes
{
    internal class Rivista : Pubblicazioni
    {
        public string? Titolo {  get; set; }

        public string? Categoria {  get; set; }

        public static int ContatoreRivista { get; private set; }
        public Rivista(string? titolo, string? categoria, string? codice, int? stock, int vendite)
        {
            Titolo = titolo;
            Categoria = categoria;
            Codice = codice;
            Stock = stock;
            Vendite = vendite;
            //ContatoreRivista++;
        }
        public override void stampaDettagli()
        {
            Console.WriteLine($"[RIVISTA] Titolo: {Titolo}, Cat: {Categoria}, Cod.Univoco {Codice}, Quantità: {Stock}," +
                $" Unità Vendute: {Vendite}");
        }
    }
}
