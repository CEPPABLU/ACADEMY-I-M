using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_02_Recap
{
    internal class Studente
    {
        private string v1;
        private string v2;

        public string? Nome { get; set; }

        public int? Matricola { get; set; }

        public string? Cognome { get; set; }

        private Studente() 
        { 

        }
        public Studente(string? nome, int matricola, string?  cognome)
        {
            Nome = nome;
            Matricola = matricola;
            Cognome = cognome;
        }

        public Studente(string? nome, string? cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
    }
}
