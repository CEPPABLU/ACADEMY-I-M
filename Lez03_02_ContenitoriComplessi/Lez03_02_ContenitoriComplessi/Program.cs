namespace Lez03_02_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stuUno = { "Giovanni Pace", "12345", "PCAGNN" };
            //string[] stuDue = { "Valeria Verdi", "12346", "VLRVRD" };
            //string[] stuTre = { "Mario Rossi", "12347", "MRRRSS" };

            //string[][] elenco = {stuUno, stuDue, stuTre };

            //for (int i = 0; i < elenco.Length; i++)
            //{
            //    string[] temp = elenco[i];
            //    for (int j = 0;j < temp.Length; j++)
            //    {
            //        Console.WriteLine(temp[j]);
            //    }
            //}
            //Console.WriteLine("Quale codice fiscale vuoi cercare??");
            //string? input = Console.ReadLine();

            //for (int i = 0;i< elenco.Length; i++)
            //{
            //    if (input is not null &&
            //        elenco[i][2].Equals(input.ToUpper().Trim()))
            //    {
            //        Console.WriteLine($"Nome: {elenco[i][0]}\nMatricola: {elenco[i][1]}\nCF:{elenco[i][2]}");
            //    }
            //}

            //for (int i = 0; i < elenco.Length; i++)
            //{
            //    Console.WriteLine(elenco[2]);

            //    //for (int j = 0; j < elenco[i].length; j++)
            //    //{
            //    //    console.writeline(elenco[i][2]);
            //    //}
            //}

            //--------------------------------------------------------------

            //string[][] elencoBis =
            //{
            //    { "Giovanni Pace", "12345", "PCAGNN" },
            //    { "Valeria Verdi", "12346", "VLRVRD" },
            //    { "Mario Rossi", "12347", "MRRRSS" }
            //};


            // ---------- ESERCIZIO --------

            //Titolo - AUTORE - ISBN - Casa Editrice
            string[] libro_1 = { "Il signore degli anelli", "JRRT", "123456-1225", "Casa ed 1" };
            string[] libro_2 = { "Il ritorno del re", "JRRT", "123456-1226", "Casa ed 1" };
            string[] libro_3 = { "Il visconte dimezzato", "I.Calvino", "987456-1225", "Casone editrice" };
            string[] libro_4 = { "Storia del buongiorno", "A. Christie", "456466-1225", "Casone editrice" };
            string[] libro_5 = { "Le due torri", "JRRT", "456463-1225", "Casa ed 1" };

            string[][] store = { libro_1, libro_2, libro_3, libro_4, libro_5 };

            //SOLUZIONE MIA

            Console.WriteLine("Quale autore vuoi cercare?");
            string? inputUtente = Console.ReadLine();
            int contatore = 0;

            for (int i = 0; i < store.Length; i++)
            {
                if (inputUtente is not null && store[i][1].Equals(inputUtente.ToUpper().Trim()))
                {
                    //Console.WriteLine(store[i][1]);
                    contatore++;
                }
            }

            Console.WriteLine(contatore);

            //SOLUZIONE PROF
            foreach (string[] libro in store)
            {

            }
            //Contare tutti i libri di JRRT o di un autore inserito a mano.        }
        }
    }
}
