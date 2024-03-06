using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_08_Ereditarieta.Classes
{
    internal class Studente : Persona   //Estensione in C#
    {
        public string? Matricola { get; set; }

        private Studente() 
        {

        }
        public Studente(string? nome, string? cognome, string? matricola) 
        { 
            Nome = nome;
            Cognome = cognome;  
            Matricola = matricola;
        }

        public override void stampaDettaglio() //Override grazie al virtual in Persona
        {
            Console.WriteLine($"{Nome} {Cognome} {Matricola}");
        }

    }
}
    