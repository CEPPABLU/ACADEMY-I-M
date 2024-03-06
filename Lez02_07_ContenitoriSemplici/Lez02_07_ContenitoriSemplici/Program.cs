namespace Lez02_07_ContenitoriSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeri = { 1, 2, 3, 4, 5, 6 };
            //numeri[2] = 11;
            //Console.WriteLine(numeri[2]);

            int[] numeri = new int[5];
            numeri[0] = 6;
            numeri[1] = 67;
            numeri[2] = 14;
            numeri[3] = 5;
            numeri[4] = 10;

            //Console.WriteLine(numeri.Length);
            //Console.WriteLine(numeri[0]);
            //Console.WriteLine(numeri[1]);
            //Console.WriteLine(numeri[2]);
            //Console.WriteLine(numeri[3]);
            //Console.WriteLine(numeri[4]);

            //int i = 0;

            //while (i < numeri.Length)
            //{
            //    Console.WriteLine(numeri[i]);

            //    i++;
            //}

            //------------------------------------

            //string[] parco = { "Maserati", "Lamborghini", "BMW", "FIAT" };

            //for(int i = 0; i < parco.Length; i++)
            //{
            //    Console.WriteLine(parco[i]);
            //}

            //-----------------------------------------------

            //string[] parco = { "Maserati", "Lamborghini", "BMW", "FIAT" };

            //string ricerca = "BMW";
            //bool trovato = false;

            //for(int i = 0; i < parco.Length; i++)
            //{
            //    if (parco[i].Equals(ricerca))
            //    {
            //        trovato = true;
            //    }
            //}

            //if (trovato)
            //    {
            //        Console.WriteLine("Trovato");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Non Trovato");
            //    }

            //--------------------------------------------

            //string[] parco = { "maserati", "lamborghini", "bmw", "fiat" };

            //Array.Sort(parco);

            //foreach (string auto in parco)
            //{
            //    Console.WriteLine(auto);
            //}

            //-----------------------------------------------------

            //int a = 5;

            //if(3 < 4)
            //{
            //    a = 7;
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine(b);

            //--------------------------------------------------

            /*
             * Presa stringa composta in questo modo: "Giovanni, Valeria, Marika, Mario, Valeria".
             * Trasformarla in un array evitando le ripetizioni.
             */

            // ESERCIZIO

            string nomi = "Giovanni, Valeria, Marika, Mario, Valeria";


            //SOLUZIONE 1
            //string newNomi = nomi.Replace(",", "");
            //Console.WriteLine(newNomi.IndexOf("Mario"));
            //string newNomiBis = newNomi.Remove(29);
            //char[] arrayCar = newNomiBis.ToCharArray();
            //Console.Write(arrayCar);


            //SOLUZIONE 2
            //Console.WriteLine(nomi.IndexOf("Mario"));
            //string newNomi = nomi.Remove(34);
            //string[] arraystringhe = newNomi.Split(',');

            //for (int i = 0; i < arraystringhe.Length; i++)
            //{
            //    Console.Write(arraystringhe[i]);
            //}

            //CAGATE VARIE

            //Console.WriteLine(arraystringhe.Length);
            //char[] arrayCar = nomi.ToCharArray();

            //for (int i = 0; i < arrayCar.Length-8; i++)
            //{
            //    Console.Write(arrayCar[i]);
            //}
            //foreach (char carattere in arrayCar)
            //{
            //    Console.Write(carattere);
            //}
            //Console.WriteLine(arrayCar.Length);
            //Console.WriteLine(arrayCar);
            //for (int i = 0; i < arrayCar.Length; i++)
            //{
            //    Console.Write(arrayCar[i]);
            //}


            //foreach(char pippo in nomi)
            //{
            //    Console.Write(pippo);
            //}
            //char[] delimiterChars = { ',' };

        }
    }
}
