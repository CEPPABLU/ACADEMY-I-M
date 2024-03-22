using Eser_Join_Uni.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Eser_Join_Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICollection<Studente> elencoSt = new List<Studente>();
            ICollection<Esame> elencoEs = new List<Esame>();

            using (var ctx = new AccLez09MtmUniversitaContext())
            {
                //ICollection<Studente> elencoPer = ctx.Studentes.ToList();
                try
                {
                    Studente perTemp = ctx.Studentes.Include(e => e.EsameRifs).Single(s => s.StudenteId == 2);
          
                    Console.WriteLine(perTemp.Nominativo);

                    foreach (Esame es in perTemp.EsameRifs) 
                    {
                        Console.WriteLine(es.Titolo);                    
                    }
                                      
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //ICollection<Esame> ricercaEsame = ctx.Esames.Where(e => e.Titolo == "Analisi I").ToList();
                //Console.WriteLine(ricercaEsame);
            }

            //using (var ctxx = new AccLez09MtmUniversitaContext())
            //{
            //    ICollection<Esame> elencoPer = ctxx.Esames.ToList();
            //    try
            //    {
            //        Esame esTemp = ctxx.Esames.Single(s => s.EsameId == 1);
            //        Console.WriteLine(esTemp.Titolo);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    //ICollection<Esame> ricercaEsame = ctxx.Esames.Where(e => e.Titolo == "Analisi I").ToList();
            //    //Console.WriteLine(ricercaEsame);
            //}


        }


    }
}
