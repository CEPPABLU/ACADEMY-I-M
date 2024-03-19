using Eserc_01_LINQ_Lista_Prodotti.Classes;
using System.Text.RegularExpressions;

namespace Eserc_01_LINQ_Lista_Prodotti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Prodotto> elenco = new List<Prodotto>()
           {
               new Prodotto("Lavatrice", "Carrello basso", 10f, "Elettrodomestico", 20),
               new Prodotto("Lampada", "Luce a neon", 5f, "Arredo", 20),
               new Prodotto("Scopettone", "Nero e bello", 7f, "Bagno", 20),
               new Prodotto("Valvola", "Bella", 2f, "Elettrodomestico", 20),
               new Prodotto("Libreria", "Buona", 7f, "Arredo",20)
           };

            //var risultato = from oggetto in elenco
            //                where oggetto.Categoria.Equals("Elettrodomestico")  //E' meglio con oggetto.Categoria == "Elettrodomestico"
            //                select oggetto;

            //foreach (var o in risultato)
            //{
            //    Console.WriteLine(o);
            //};

            var risultato = elenco.Where(p => p.Categoria == "Elettrodomestico");

            foreach (var o in risultato)
            {
                Console.WriteLine($"{o.Nome}");
            };

            //Console.WriteLine($"Prezzo medio " + elenco.Average(s => s.Prezzo));

            //var numeriche = from oggetto in elenco
            //                select oggetto.Categoria;

            var somma = from oggg in elenco
                        //where libro.Genere.Equals("Fantasy")
                        group oggg by oggg.Categoria into contenitoreCategoria
                        select contenitoreCategoria;

            foreach(var o in somma)
            {
                Console.WriteLine($"Categoria:{o.Key}");

                foreach(var p in o)
                {
                    Console.WriteLine($"Somma Prodotti: {o.Sum(p => p.Quantita)}");
                    break;
                }
            };
            float prodotto_finale_locale;
            float prodotto_totale;
            float prodotto_finale = 0;

            var prod = from oggg in elenco
                        //where libro.Genere.Equals("Fantasy")
                        group oggg by oggg.Categoria into contenitoreCategoria
                        select contenitoreCategoria;

            foreach (var o in prod)
            {
                prodotto_totale = 0;
                prodotto_finale_locale = 0;
                //Console.WriteLine($"Categoria:{o.Key}");
                foreach (var p in o)
                {
                    prodotto_totale = p.Quantita * p.Prezzo;
                    prodotto_finale_locale += prodotto_totale;
                    //Console.WriteLine(prodotto_finale);
                }
                prodotto_finale = prodotto_finale + prodotto_finale_locale;
            }
            Console.WriteLine($"Prodotto finale:{prodotto_finale}");
        }


    }
}
