namespace Lez02_02_Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nominativo = "Pippo Franco";
            //string? nominativo = null;
            //Console.WriteLine(nominativo);

            //Console.WriteLine("Pippo" + " Franco");

            //int a = 2;
            //int b = 5;

            //Console.WriteLine("La somma dei numeri è: " + a + b);// La somme dei numeri è: 25. E' una stringa
            //Console.WriteLine("La somma dei numeri è: " + (a + b));//La somma dei numeri è: 7.
            //Console.WriteLine( a + b + " La somma dei numeri è");

            //Operazioni semplici tra stringhe:
            /*
                Scrivere un programma che mandi in output le seguenti due stringhe:

                Giovanni Pace è 37 anni vecchio ed ha una temperatura corporea di 36.5°C.
                Mario Rossi è 23 anni vecchio ed ha una temperatura corporea di 38.5°C.
             */

            //string nominativo1 = "Giovanni Pace";
            //int eta1 = 37;
            //float temp1 = 36.5f;

            //Console.WriteLine(nominativo1 + " è " + eta1 + " anni vecchio ed ha una temperatura corporea di " + temp1 + "°C");
            //Console.WriteLine($"{ nominativo1} è {eta1} anni vecchio ed ha una temperatura corporea di {temp1}°C"); //Interpolazione

            ////string nominativo2 = "Mario Rossi";
            ////int eta2 = 23;
            ////float temp2 = 38.5f;
            //nominativo1 = "Mario Rossi";
            //eta1 = 23;
            //temp1 = 38.5f;

            //Console.WriteLine(nominativo1 + " è " + eta1 + " anni vecchio ed ha una temperatura corporea di " + temp1 + "°C");
            //Console.WriteLine($"{nominativo1} è {eta1} anni vecchio ed ha una temperatura corporea di {temp1}°C"); //Interpolazione
            //Console.WriteLine("Giovanni Pace è 37 anni vecchio ed ha una temperatura corporea di 36.5°C.");
            //Console.WriteLine("Mario Rossi è 23 anni vecchio ed ha una temperatura corporea di 38.5°C.");

            //-------------------------------------------------------------------

            //Console.WriteLine($"Il risultato è: {5 + 6}");

            //string nominativo = "Pippo Franco";
            //Console.WriteLine($"Il nome {nominativo} ha una lunghezza di {nominativo.Length}");

            //int lunghezza = nominativo.Length;
            //Console.WriteLine($"Il nome {nominativo} ha una lunghezza di {lunghezza}");

            //------------------------------------------------------------------

            //string? frase = "Mi piace tanto \"programmare\""; // il backslash è un parser e disabilita la funzionalità del carattere successivo
            //Console.WriteLine(frase);

            //------------------------------------------------------------------

            string frase = "Sono Pippo Franco e mi piace programmare";
            Console.WriteLine(frase.IndexOf("Franco"));

            if (frase.IndexOf("Pappagallo") != -1)
                Console.WriteLine("Trovato");
            else
                Console.WriteLine("Non Trovato");
        }
    }
}
