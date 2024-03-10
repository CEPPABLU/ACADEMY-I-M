using Task_Edicola.Classes;

namespace Task_Edicola
{
    internal class Program
    {
        private static string? titolo;

        static void Main(string[] args)
        {
            Edicola edicolaFralla = new Edicola("Fralla Giornalaio", "Via Lapponia, 33");
            bool insAbi = true;
            //CicloWhile
            while (insAbi)
            {
                Console.WriteLine("Buongiorno,le elenco le azioni che può effettuare:\n"  +
                    "Scrivendo \"aggiungi giornale\" aggiungerà un giornale,\nscrivendo \"aggiungi rivista\" aggiungerà una rivista,\n" +
                    "scrivendo \"rimuovi giornale\" rimuoverà un giornale,\nscrivendo \"rimuovi rivista\"rimuoverà una rivista,\n" +
                    "scrivendo \"aggiorna stock pubblicazione\" aggiornerà lo stock della pubblicazione\n" +
                    "scrivendo \"vendita pubblicazione\" segnerà una vendita\n" +
                    "scrivendo \"stampa elenco pubblicazioni\" avrà la lista completa.\n" +
                    "Per uscire dal programma le basterà digitare \"p******\"");
                string? inputUtente = Console.ReadLine().ToUpper();
         
                switch (inputUtente)
                {
                    case ("AGGIUNGI GIORNALE"):
                        Console.WriteLine("Inserisci la redazione:");
                        string? redazione = Console.ReadLine().ToUpper();
                        Console.WriteLine("Inserisci il codice:");
                        string? codice = Console.ReadLine().ToUpper();
                        Console.WriteLine("Inserisci lo stock:");
                        int? stockg = int.Parse(Console.ReadLine());
                        int vendite = 0;
                        Pubblicazioni gio = new Giornale(redazione, codice, stockg, vendite);
                        edicolaFralla.aggiungiMagazzino(gio);
                        gio.stampaDettagli();
                        break;
                    case ("AGGIUNGI RIVISTA"):
                        Console.WriteLine("Inserisci il titolo:");
                        string? titolo = Console.ReadLine().ToUpper();
                        Console.WriteLine("Inserisci il categoria:");
                        string? categoria = Console.ReadLine().ToUpper();
                        Console.WriteLine("Inserisci il codice:");
                        string? codiceRiv = Console.ReadLine().ToUpper();
                        Console.WriteLine("Inserisci lo stock:");
                        int? stockRiv = int.Parse(Console.ReadLine());
                        int venditeRiv = 0;
                        Pubblicazioni riv = new Rivista(titolo, categoria, codiceRiv, stockRiv, venditeRiv);
                        edicolaFralla.aggiungiMagazzino(riv);
                        riv.stampaDettagli();
                        break;
                    case ("RIMUOVI PUBBLICAZIONE"):
                        Console.WriteLine("Inserisci il codice:");
                        string? codiceRim = Console.ReadLine().ToUpper();
                        edicolaFralla.rimuoviMagazzino(codiceRim);
                        break;
                    case ("AGGIORNA STOCK PUBBLICAZIONE"):
                        Console.WriteLine("Inserisci il codice della pubblicazione da aggiornare:");
                        string? codicePubAgg = Console.ReadLine().ToUpper();
                        Console.WriteLine("Inserisci il numero dello stock:");
                        int nuovoStock = int.Parse(Console.ReadLine());
                        edicolaFralla.updateStock(codicePubAgg, nuovoStock);
                        break;
                    case ("VENDITA PUBBLICAZIONE"):
                        Console.WriteLine("Inserisci il codice della pubblicazione venduta");
                        string? codicePubVen = Console.ReadLine().ToUpper();
                        Console.WriteLine("Inserisci quante unità vendute");
                        int vendita = int.Parse(Console.ReadLine());
                        edicolaFralla.updateVendite(codicePubVen, vendita);
                        break;
                    case ("STAMPA ELENCO PUBBLICAZIONI"):
                        edicolaFralla.stampaElenco();
                        break;
                    case ("P******"):
                        insAbi = false;
                        break;
                    default:
                        Console.WriteLine("Errore digitazione");
                        break;      
                }
            }
        }
    }
}
