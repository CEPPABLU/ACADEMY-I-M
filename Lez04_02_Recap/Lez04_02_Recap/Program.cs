namespace Lez04_02_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stuUno = { "Giovanni Pace", "12345", "PCAGNN" };
            //string[] stuDue = { "Valeria Verdi", "12346", "VLRVRD" };
            //string[] stuTre = { "Mario Rossi", "12347", "MRRRSS" };

            //string[][] elenco = { stuUno, stuDue, stuTre };

            Studente uno = new Studente("Giovanni Pace", 12345, "PCAGNN");
            Studente due = new Studente("Valeria Verdi", 12345, "VLRVRD");
            Studente tre = new Studente("Mario Rossi", 12345, "MRRRSS");

            Studente sei = new Studente("Mario Rossi", "MRRRSS");

            Studente[] elenco = { uno, due, tre, sei };

            Console.WriteLine(elenco[0]);
        }
    }
}
