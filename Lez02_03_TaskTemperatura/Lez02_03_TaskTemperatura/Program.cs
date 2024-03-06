namespace Lez02_03_TaskTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di controllo accessi al ristorante, in input (sotto forma di variabile) ci sarà la temperatura
             * 
             * Se la temperatura è maggiore o uguale a 37.5°C allora non permettere l'ingresso al ristorante.
             * 
             * ATTENZIONE: non ci vuole un medico per stabilire che al di soto dei 35° abbiamo qualche problema o al di sopra dei 42
             * eviterei l'ingresso al ristorante
             */
            Console.WriteLine("Inserisci la tua età");

            try
            {
                string? pipput = Console.ReadLine();
                double input = Convert.ToDouble(pipput);

                if (input >= 35.9f && input <= 42.0f)

                    if (input < 37.5f)
                        Console.WriteLine("Puoi entrare");
                    else
                        Console.WriteLine("Non puoi entrare");
                else
            
                    Console.WriteLine("Errore di validazione");
            } catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Programma terminato");
            }
            
        }
    }
}
