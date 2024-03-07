using Lez03_09_Astrazione.Classes;

namespace Lez03_09_Astrazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animale animale = new Animale();  //Non posso istanziare un oggetto di una classe abstract  

            Gatto   bu = new Gatto();

            Coccodrillo coccodrillo = new Coccodrillo(); 
            
            Cane vivi = new Cane("Vivi");
            vivi.versoEmesso();
        }
    }
}
