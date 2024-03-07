using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eser_03_Task.Classes
{
    internal class Stanza
    {
        public string? Nome { get; set; }

        private List<Oggetto> elenco { get; set; } = new List<Oggetto>();
        public void aggiungiOggetto(Oggetto utile)
        {
            elenco.Add(utile);
        }
        //public void checkLista()
        //{
        //    foreach(Oggetto utile in elenco)
        //    {
        //        Console.WriteLine(utile.Nome + " " + utile.Descrizione + " " + utile.ValoreOggetto);
        //        //Console.WriteLine(utile.Descrizione);
        //        //Console.WriteLine(utile.ValoreOggetto);
        //    }
        //}

        public void creazioneListe(string val1, string val2, string val3)
        {
            Oggetto waterr = new Oggetto(val1, val2, val3);
        }
    }

}
