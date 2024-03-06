namespace Lez02_06_CicliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                while(condizione){
                        //Corpo da eseguire
                }
             */

            //int indice = 0;

            //while (indice < 5)
            //{
            //    Console.WriteLine("Ciao");

            //    indice++;
            //}

            //--------------------------------------------

            //int indice = 0;

            //while (indice < 5)
            //{
            //    Console.WriteLine($"Sono all'indice {indice+1}");  //indice + 1 non va a modificare il valore dell'indice

            //    indice++;      
            //}

            //---------------------------------------------------

            //int i = 0;
            //do
            //{
            //    Console.WriteLine($"Sono all'indice {i + 1}");

            //    i++;
            //} while (i < 0);

            //--------------------------------------------------------

            //bool inserimentoabilitato = true;

            //while (inserimentoabilitato)
            //{
            //    Console.WriteLine("inserisci il tuo nome o digita q per uscire");
            //    string? inpututente = Console.ReadLine();

            //    if (inpututente != null && inpututente.Equals("q"))
            //        inserimentoabilitato = false;
            //    else
            //        Console.WriteLine($"ciao {inpututente}");
            //}

            /*
             * STEP 1
             * scrivere un sistema di gestione invitati alla propria festa.
             * L'inserimento avviene tramite console che prende in input (in due tempi diversi) il nome e cognome.
             * 
             * All'uscita del programma verrà stampato l'elenco delle persone precedentemente inserita, separate da virgola.
             */

            //bool inserimentoAbilitato = true;
            //string nome = null;
            //string cognome = null;
            //int index = 0;
            //while (index < 5)
            //{

            //Console.WriteLine("Inserici il nome");
            //nome = Console.ReadLine();

            //Console.WriteLine("Inserisci il cognome");
            //cognome = Console.ReadLine();

            //    if (nome != null && cognome != null)

            //       inserimentoAbilitato = false;
            //    index++;
            //}

            //Console.WriteLine($"{nome} , {cognome}");

            bool isnAbi = true;
            string risultato = "";

            while (isnAbi)
            {
                Console.WriteLine("Cosa vuoi fare?\n" +
                    "premi Invio per un nuovo utente o digita Q per uscire");
                string? inputScelta = Console.ReadLine();

                if(inputScelta != null && inputScelta.Equals("Q")) 
                    isnAbi = false;
                else
                {
                    Console.WriteLine("Inserici il nome");
                    string? nome = Console.ReadLine();

                    Console.WriteLine("Inserisci il cognome");
                    string? cognome = Console.ReadLine();

                    risultato += nome + " " + cognome + ",";
                }
            }
                Console.WriteLine(risultato);

        }
    }
}
