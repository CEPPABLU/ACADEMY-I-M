using Es_01_GestioneVeicolo.Classes;

namespace Es_01_GestioneVeicolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci 1 per Automobile o 2 per Moto");
            int scelta = Convert.ToInt32(Console.ReadLine());

            //Moto moto1 = new Moto();
            Macchina mach1 = new Macchina();
            Moto moto1 = new Moto();
            if(scelta == 1)
            {
                Console.WriteLine("Inserisci marca");
                moto1.Marca = Console.ReadLine();
                Console.WriteLine("Inserisci cilindrata");
                moto1.Cilindrata = Convert.ToInt32(Console.ReadLine());
                moto1.stampaDettagli();

            }
            else
            {
                Console.WriteLine("Inserisci marca");
                mach1.Marca = Console.ReadLine();
                Console.WriteLine("Inserisci cilindrata");
                mach1.Cilindrata = Convert.ToInt32(Console.ReadLine());
                mach1.stampaDettagli();
            }

            //switch (scelta)
            //{
            //    case 1:
            //        Console.WriteLine("Inserisci la marca");
            //        break;
            //}

            //moto1.Cilindrata = 750;
            //moto1.Marca = "Suzuki";

            //mach1.Marca = "Fiat";
            //mach1.Cilindrata = 800;

            //moto1.stampaDettagli();
            //mach1.stampaDettagli();






        }
    }
}
