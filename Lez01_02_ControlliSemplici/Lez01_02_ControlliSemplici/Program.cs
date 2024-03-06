namespace Lez01_02_ControlliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabili

            //int eta = 15;
            //int eta;
            //eta = 15;

            //eta = 4;
            //Console.WriteLine(eta); 

            //string nome;
            //nome = "Pippo";

            //String cognome = null; // null non sta occupando subito la memoria rispetto al tipo primitivo
            //String? cognome = null; // con il ? si può assegnare il valore nullable (può accettare un valore null)
            //cognome = "Franco"; //Una volta assegnato un valore occupa una cella di memoria
            //Console.WriteLine(cognome);    


            /*
             Non è possibile rendere nullable un dato primitivo
             */

            //COMPARAZIONI

            /*
                >
                <
                >=
                <=
                ==
                !=
            */


            //Console.WriteLine(6 >= 5);

            /*
              if(condizione){
                  //Codice in caso positivo
              } else {
                  //Codice in caso negativo
              }
            */

            //if (6 > 5)
            //{
            //    Console.WriteLine("Sono il ramo True");
            //} else
            //{
            //    Console.WriteLine("Sono il ramo False");
            //}

            //------------------------------------------------- ESPANSIONE ORIZZONTALE//

            //int eta = 8500;

            //if (eta <= 0)
            //{
            //    Console.WriteLine("Non penso tu sia un embrione in stadio prototipale....");
            //} else
            //{
            //    if (eta >= 130)
            //    {
            //        Console.WriteLine("Te li porti veramente bene...");
            //    }
            //    else
            //    {
            //        if (eta >= 18)
            //        {
            //            Console.WriteLine("Sei maggiorenne");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sei minorenne");
            //        }
            //    }
            //if (eta >= 18)
            //{
            //    Console.WriteLine("Sei maggiorenne");
            //}
            //else
            //{
            //    Console.WriteLine("Sei minorenne");
            //}
            //}

            //if(eta >= 18)
            //{
            //    Console.WriteLine("Sei maggiorenne");
            //}
            //else
            //{
            //    Console.WriteLine("Sei minorenne");
            //}

            //---------------------------------------

            //int eta = -3000;
            //      TRUE    ||      FALSE       = TRUE
            //      1       +       0           = 1

            //int eta = 40000;
            //false || true = false;
            //0 + 1 = 1;
           
            //if ( (eta <= 0) || (eta >= 130) )
            //{
            //    Console.WriteLine("Errore di validazione");
            //}
            //else 
            //{
            //    Console.WriteLine("Procedi con la tua operazione");
            //}
        }
    }
}
