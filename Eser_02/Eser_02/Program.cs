namespace Eser_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Creare un sistema in grado di immagazinare i dati relativi ad una persona.
             * Inoltre, sarà necessario immagazinare, all'interno di una persona, i dati
             * relativi a:
             * - Codice Fiscale
             * |- CODICE
             * |_ Data di scadenza
             *
             * - Carta di Identita:
             * |- CODICE
             * |- Data di Emissione
             * |- Data di Scadenza
             * |_ Emissione (comune || zecca dello stato)
             */

            //Console.WriteLine("Inserire Nome:");
            //string? inputNome = Console.ReadLine();

            //Console.WriteLine("Inserire Cognome:");
            //string? inputCognome = Console.ReadLine();

            //Console.WriteLine("Inserire CODICE:");
            //string? inputCodice = Console.ReadLine();

            //Console.WriteLine("Inserire Data di scadenza:");
            //string? inputDat = Console.ReadLine();

            //Console.WriteLine("Inserire Codice CI:");
            //string? inputCod = Console.ReadLine();

            //Console.WriteLine("Inserire Data Emissione:");
            //string? inputDatEm = Console.ReadLine();

            //Console.WriteLine("Inserire Data di scadenza:");
            //string? inputDatScad = Console.ReadLine();

            //Console.WriteLine("Inserire Emissione:");
            //string? inputEm = Console.ReadLine();

            Persona p1 = new Persona()
            {
                Nome = "Pippo",
                Cognome = "Franco",
                CodiceFiscale = new CodiceFiscale()
                {
                    Codice = "GSFASF",
                    DataDiScadenza = "33/03/1999"
                },

                CartaIdentita = new CartaIdentita()
                {
                    Codice = "AXouoi",
                    DataDiEmissione = "33/32/1999",
                    DataDiScadenza = "33/33/1999",
                    Emissione = "sdggsdg"
                }
            };

            Console.WriteLine(p1);

        }
    }
}
