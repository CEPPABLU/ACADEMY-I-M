using Lez05_02_StaticiEreditari.CLasses;

namespace Lez05_02_StaticiEreditari
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Giocattolo autoUno = new Automobile();
            Giocattolo autoDue = new Automobile();
            Giocattolo trenino = new Trenino();

            List<Giocattolo> elenco = new List<Giocattolo>();
            elenco.Add(autoUno);
            elenco.Add(autoDue);
            elenco.Add(trenino);

            foreach(Giocattolo g in elenco)
            {
                if(g.GetType() == typeof(Trenino))
                {
                    Trenino temp = (Trenino)g;
                    temp.rumoreTrenino();
                }
            }

           //Console.WriteLine(Giocattolo.Contatore);
        }
    }
}
