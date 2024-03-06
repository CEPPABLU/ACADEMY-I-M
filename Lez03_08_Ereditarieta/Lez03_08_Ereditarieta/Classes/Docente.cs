using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_08_Ereditarieta.Classes
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }

        public string? Materia { get; set; }

        public override void stampaDettaglio() //Override grazie al virtual in Persona
        {
            Console.WriteLine($"{Nome} {Cognome} {Materia} {Dipartimento}");
        }
    }
}