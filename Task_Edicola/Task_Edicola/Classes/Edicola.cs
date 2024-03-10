using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Edicola.Classes
{
    internal class Edicola
    {
        public string? NomeEdicola { get; set; }

        public string? Indirizzo { get; set; }

        public List<Pubblicazioni> magazzino { get; set; } = new List<Pubblicazioni>();

        public Edicola(string? nomeEdicola, string? indirizzo)
        {
            NomeEdicola = nomeEdicola;
            Indirizzo = indirizzo;
        }

        public void aggiungiMagazzino(Pubblicazioni pub)
        {
            bool codicePresente = false;
            foreach (Pubblicazioni p in magazzino)
            {
                if (p.Codice == pub.Codice)
                {
                    codicePresente = true;
                    break;
                }
            }
            if (!codicePresente)
            {
                magazzino.Add(pub);
                Console.WriteLine("Aggiunto con successo!!");
            }
            else
            {
                Console.WriteLine("Errore: codice Pubblicazione già presente!");
            }

        }
        public void rimuoviMagazzino(string? codice)
        {
            bool rimosso = false;
            foreach (Pubblicazioni p in magazzino)
            {
                if ((p.Codice == codice))
                {
                    magazzino.Remove(p);
                    rimosso = true;
                    Console.WriteLine("Elemento rimosso con successo!!");
                    break;
                }
                if (!rimosso)
                {
                    Console.WriteLine("Pubblicazione non trovata!");
                }
            }
        }
        public void stampaElenco()
        {
            foreach (Pubblicazioni pub in magazzino)
            {
                pub.stampaDettagli();
            }
        }
        public void updateStock(string? codice, int? stock)
        {
            bool aggiornato = false;
            foreach (Pubblicazioni p in magazzino)
            {
                if (p.Codice == codice)
                {

                    p.Stock += stock;
                    aggiornato = true;
                    Console.WriteLine("Stock aggiornato con successo!!");
                    break;
                }
                if (!aggiornato)
                {
                    Console.WriteLine("Stock non aggiornato!");
                }else{
                    Console.WriteLine("Pubblicazione non trovata!");
                }
            }
        }
        public void updateVendite(string? codice, int? vendite)
        {
            bool aggiornato = false;
            foreach (Pubblicazioni p in magazzino)
            {
                if (p.Codice == codice)
                {
                    p.Stock -= vendite;
                    p.Vendite = vendite;
                    aggiornato = true;
                    Console.WriteLine("Vendita riuscita!");
                    break;
                }
                if (!aggiornato)
                {
                    Console.WriteLine("Stock non aggiornato!");
                }else{
                    Console.WriteLine("Pubblicazione non trovata!");
                }
            }
        }
    }
}
