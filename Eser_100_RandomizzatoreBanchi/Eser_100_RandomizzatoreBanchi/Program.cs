using System;
using System.Collections.Generic;
namespace RandomizzatoreBanchi
{
    class Program
    {
        static void Main(string[] args)
        {           
            //Lista alunni
            List<string> alunni = new List<string>()
            {
                "Alunno1", "Alunno2", "Alunno3", "Alunno4", "Alunno5",
                "Alunno6", "Alunno7", "Alunno8", "Alunno9", "Alunno10",
                "Alunno11", "Alunno12", "Alunno13", "Alunno14", "Alunno15",
                "Alunno16", "Alunno17", "Alunno18", "Alunno19", "Alunno20",
                "Alunno21"
            };

            //Randomizzatore
            Random randomizzatore = new Random();

            //Lista posti assegnati
            List<string> postiAssegnati = new List<string>();

            try
            {
                while(alunni.Count > 0)
                {
                    int indice = randomizzatore.Next(alunni.Count);
                    string posto = alunni[indice];
                    postiAssegnati.Add(posto);
                    alunni.RemoveAt(indice);
                }

            }catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Indice fuori dalla portata della lista");
            }

            //Stampare posti assegnati
            Console.WriteLine("Posti assegnti:");
            for(int i = 0; i < postiAssegnati.Count; i++)
            {
                Console.WriteLine($"Banco{i + 1}: {postiAssegnati[i]}");
            }

        }
    }
}