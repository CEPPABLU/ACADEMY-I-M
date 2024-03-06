namespace Lez02_01_Variabili //Deve assumere lo stesso nome del progetto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipo di dato primitivo
            //int eta = 15;
            //int eta;        //Dichiarazione
            //eta = 15;       //Assegnazione

            //float b = 15.7f;
            //Console.WriteLine(b);

            //double c = 14.6d;
            //Console.WriteLine(c);

            //double d = b;
            //Console.WriteLine(d);

            //Console.WriteLine(b == d); //Restituisce TRUE

            //--------------------------------------------------------

            //int valoreUno = 8;                              //1
            //int valoreDue = 5;                              //1

            //Console.WriteLine(valoreUno + valoreDue);       //1
            //Console.WriteLine(valoreUno + valoreDue);       //1
            //Console.WriteLine(valoreUno + valoreDue);       //1
            //Console.WriteLine(valoreUno + valoreDue);       //1

            //-------------------------------------------------
            //int valoreUno = 8;
            //int valoreDue = 5;
            //int somma = valoreUno + valoreDue;              //2

            //Console.WriteLine(somma);
            //Console.WriteLine(somma);
            //Console.WriteLine(somma);
            //Console.WriteLine(somma);

            //----------------------------------------------------

            //Operazione complessa
            //Console.WriteLine( 15 + 16.7f + 22.8d ); //Restituirà un valore double

            //------------------------------------

            //int numero = 5;

            //numero = numero + 1;

            //numero = numero + 4;

            //Console.WriteLine(numero);

            //numero += 1;
            //numero += 4;
            //numero -= 2;

            //Console.WriteLine(numero);

            //----------------------------------------------

            //int num = 0;

            //num++;              // num += 1;
            //num++;

            //Console.WriteLine(num);

            //num--;

            //Console.WriteLine(num);

            //------------------------------------------------

            //int valUno = 15;
            //float valDue = 2.3f;

            //float rapporto = valUno / valDue;

            //Console.WriteLine((int)rapporto);           //CASTING

            //---------------------------------------------------------

            int ciccio = 1;
            int risultato = 2147483647 + ciccio;
            Console.WriteLine(risultato); //Restituirà un numero negativo

        }
    }
}