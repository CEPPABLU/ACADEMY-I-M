using Eser_Mod_Citta.Classes;

namespace Eser_Mod_Citta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string credenziali = "Server=ACADEMY2024-03\\SQLEXPRESS;Database=ese_gestione_paninoteca;User " +
                "Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

            GestisciPaninoteca ges = new GestisciPaninoteca();

            ges.insert(Panino p);
           

        };
    }
}
