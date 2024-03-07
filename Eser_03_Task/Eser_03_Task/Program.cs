using Eser_03_Task.Classes;

namespace Eser_03_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               * Creare un sistema che mantenga traccia degli oggetti contenuti nelle stanze 
               * della vostra casa.
               * Di ogni oggetto voglio conoscere:
               * - Nome
               * - Descrizione
               * - Valore dell'oggetto
               * 
               * Di ogni stanza voglio conoscere il nome
               */

            Stanza cucina = new Stanza() { Nome = "Cucina" };
            Stanza bagno = new Stanza() { Nome = "Bagno" };
            Stanza studio = new Stanza() { Nome = "Studio" };

            Oggetto frullatore = new Oggetto("Frullatore", "Bello", "Millemila");
            Oggetto frigo = new Oggetto("Frigo", "Figo", "3 Centesimi");
            Oggetto scolapasta = new Oggetto("Scolapasta", "Bucato", "0 Euro");
            
            Oggetto water = new Oggetto("Water", "Bianco", "Inestimabilea");
            Oggetto lavandino = new Oggetto("Lavandino", "Nero", "Inestimabileo");
            Oggetto scopettone = new Oggetto("Scopettone", "Profumato", "Inestimabilei");

            Oggetto scrivania = new Oggetto("Scrivania", "Legno Massello", "Un Miliardo");
            Oggetto lampada = new Oggetto("Lampada", "Arcobaleno", "Fluidità");
            Oggetto sedia = new Oggetto("Sedia Ergonomica", "Lilla", "Vussiti");

            bool insAbi = true;
            //CicloWhile
            while (insAbi)
            {
                Console.WriteLine("Scegli tra Cucina, Bagno o Studio " +
                    "oppure digita P******* per uscire");
                string? inputUtente = Console.ReadLine().ToUpper();

                switch (inputUtente)
                {
                    case ("CUCINA"):
                        cucina.aggiungiOggetto(frullatore);
                        cucina.aggiungiOggetto(frigo);
                        cucina.aggiungiOggetto(scolapasta);
                        frullatore.stampaDettagli(inputUtente);
                        frigo.stampaDettagli("");
                        scolapasta.stampaDettagli("");
                        //cucina.checkLista();
                        break;
                    case ("BAGNO"):
                        bagno.aggiungiOggetto(water);
                        bagno.aggiungiOggetto(lavandino);
                        bagno.aggiungiOggetto(scopettone);
                        //bagno.checkLista();
                        water.stampaDettagli(inputUtente);
                        lavandino.stampaDettagli("");
                        scopettone.stampaDettagli("");
                        break;
                    case ("STUDIO"):
                        studio.aggiungiOggetto(water);
                        studio.aggiungiOggetto(lavandino);
                        studio.aggiungiOggetto(scopettone);
                        //bagno.checkLista();
                        scrivania.stampaDettagli(inputUtente);
                        lampada.stampaDettagli("");
                        sedia.stampaDettagli("");
                        break;
                    case ("P*******"):
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
