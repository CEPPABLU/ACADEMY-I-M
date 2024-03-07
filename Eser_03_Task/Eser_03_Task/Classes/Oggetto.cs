using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eser_03_Task.Classes
{
    internal class Oggetto
    {
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public string? ValoreOggetto { get; set; }

        public Oggetto(string? nome, string? descrizione, string? valoreoggetto)
        {
            Nome = nome;
            Descrizione = descrizione;
            ValoreOggetto = valoreoggetto;
        }
        public virtual void stampaDettagli(string? nomeStanza)
        {
            Console.WriteLine($"{nomeStanza}:\n {Nome},\n {Descrizione},\n {ValoreOggetto}");
        }

        //public override string ToString()
        //{
        //    return $"[OGGETTO] {Nome},{Descrizione},{ValoreOggetto}";
        //}
        
    }
}
