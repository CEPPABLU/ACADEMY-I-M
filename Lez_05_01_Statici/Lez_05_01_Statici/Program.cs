using Lez_05_01_Statici.Clsses;

namespace Lez_05_01_Statici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Automobile.stampaContatore();
            //Console.WriteLine(Automobile.Contatore);
            Automobile autoUno = new Automobile("Franco");
            Automobile autoDue = new Automobile("Franco");

            Automobile.stampaContatore();
            //Console.WriteLine(Automobile.Contatore);
            #endregion
            //Automobile.Contatore = -23        //Non permesso
        }
    }
}
