using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Edicola.Classes
{
    internal abstract class Pubblicazioni
    {
        //protected string? Codice { get; private set; }
        //protected int? Stock { get; private set; }
        //protected int? Vendite { get; private set; }
        protected string? codice;
        protected int? stock;
        protected int? vendite;

        public string? Codice
        {
            get { return codice; }
            set { codice = value; }
        }


        public int? Vendite
        {
            get { return vendite; }
            set { vendite = value; }
        }

        public int? Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        //public static int contatore { get; private set; } = 0;

        //public static int Contatore
        //{
        //    get { return contatore; }
        //}
        public abstract void stampaDettagli();
    }
}
