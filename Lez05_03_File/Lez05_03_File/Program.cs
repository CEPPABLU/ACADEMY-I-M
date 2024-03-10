namespace Lez05_03_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string path = "C:\\Users\\utente\\Desktop\\test.txt";   //Il doppio \\ rimuove il parser

            string contenuto = "Ciao Mario Rossi";

            //Scrittura
            //try
            //{
            //    if (path is not null)
            //        using (StreamWriter sw = new StreamWriter(path))
            //        {
            //            sw.WriteLine(contenuto);
            //            sw.WriteLine("CIAO");
            //            sw.WriteLine("CiAO");

            //            sw.Close();
            //        }
            //    Console.WriteLine("Tutto ok!");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //LETTURA
            //try
            //{
            //    using (StreamReader sr = new StreamReader(path))
            //    {
            //        string? line;

            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Console.ReadLine();
        }
    }
}
