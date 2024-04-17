using asp_lez02_EF_libreria.Models;
using System.Collections.Generic;

namespace asp_lez02_EF_libreria.Repositories
{
    public class LibroRepo : IRepo<Libro>
    {
        private static LibroRepo? istanza;
        public static LibroRepo getIstanza()
        {
            if (istanza == null)
            {
                istanza = new LibroRepo();
            }
            return istanza;
        }
        private LibroRepo() { }
        public List<Libro> GetAll()
        {
            List<Libro> elenco = new List<Libro>();

            using(var ctx = new AccLez23LibreriaContext())
            {
                elenco = ctx.Libros.ToList();
            }
            return elenco;
        }

        public Libro? GetById(int id)
        {
            Libro? lib = null;

            using (var ctx = new AccLez23LibreriaContext())

                lib = ctx.Libros.FirstOrDefault(l => l.LibroId == id);


            return lib;
        }

        public bool insert(Libro t)
        {
            bool risultato = false;
            using(var ctx = new AccLez23LibreriaContext())
            {
                try
                {
                    ctx.Libros.Add(t);
                    ctx.SaveChanges();
                    risultato = true;
                }
                catch(Exception ex) {
                
                    Console.WriteLine(ex.Message);
                }
                return risultato;
            }
        }

        public bool update(Libro t)
        {
            bool risultato = false;
            using(var ctx = new AccLez23LibreriaContext())
            {
                try
                {
                    Libro? temp = ctx.Libros.Single(l => l.Codice == t.Codice);

                    ctx.Entry(temp).CurrentValues.SetValues(t);
                    ctx.SaveChanges();
                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return risultato;
        }

        public bool delete(int id)
        {
            bool risultato = false;
            using(var ctx = new AccLez23LibreriaContext())
            {
                try
                {

                    Libro lib = ctx.Libros.Single(c => c.LibroId == id);
                    ctx.Libros.Remove(lib);
                    ctx.SaveChanges();

                    risultato = true;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return risultato;
            }
        }

        public Libro? GetByCodice(string codice)
        {
            Libro? lib = null;

            using (var ctx = new AccLez23LibreriaContext())

                   lib = ctx.Libros.FirstOrDefault(l => l.Codice == codice);
            

            return lib;
        }

        public bool delete(Libro t)
        {
            return false;
        }
    }
}
