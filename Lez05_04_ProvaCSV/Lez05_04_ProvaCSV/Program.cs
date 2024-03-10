using Lez05_04_ProvaCSV.Classes;

namespace Lez05_04_ProvaCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gio = new Persona("Pippo", "Franco", "PDFGS");
            Persona val = new Persona("Luigi", "Lillo", "LLOPED");
            Persona mar = new Persona("Filippo", "Frattelli", "LODSOE");

            string path = "C:\\Users\\utente\\Desktop\\persone.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(gio.esportaCsv());
                    sw.WriteLine(val.esportaCsv());
                    sw.WriteLine(mar.esportaCsv());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
