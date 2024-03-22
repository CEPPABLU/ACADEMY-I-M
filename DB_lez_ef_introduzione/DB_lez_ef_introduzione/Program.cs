using DB_lez_ef_introduzione.Models;
using Microsoft.Identity.Client;

namespace DB_lez_ef_introduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Persona osv = new Persona()
            //{
            //    Nome = "Osvaldo",
            //    Cognome = "Bevilacqua",
            //    Email = "osv@wat.com"
            //};

            //Cartum cartUno = new Cartum()
            //{
            //    Codice = "GG123",
            //    Negozio = "Sma",
            //    PersonaRifNavigation = osv,
            //};

            //Cartum cartDue = new Cartum()
            //{
            //    Codice = "TT009",
            //    Negozio = "Tigotà",
            //    PersonaRifNavigation = osv,
            //};

            //using (var ctx = new AccLez07OtmCartaContext())
            //{
            //    try
            //    {
            //        ctx.Personas.Add(osv);
            //        ctx.Carta.Add(cartUno);
            //        ctx.Carta.Add(cartDue);
            //        ctx.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            // Sintassi LINQ method only
            ICollection<Persona> elenco = new List<Persona>();

            using (var ctx = new AccLez07OtmCartaContext())
            {
                ICollection<Persona> elencoPer = ctx.Personas.ToList();
                try
                {
                    Persona perTemp = ctx.Personas.Single(p => p.PersonaId == 4);
                    Console.WriteLine(perTemp.Cognome);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                ICollection<Cartum> ricercaCarta = ctx.Carta.Where(c => c.Negozio == "Coop").ToList();
            }
        }
    }
}
