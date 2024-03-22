using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eser_Mod_Citta.Classes
{
    internal class GestisciPaninoteca
    {
        
        //List<Panino> elencoPanino = new List<Panino>() { };

        //Panino paninoUno = new Panino("Panino Mortadella", "Bono", 2.5f, false);
        //Panino paninoDue = new Panino("Panino Verza e Nutella", "Bonino", 5f, true);
        //Panino paninoTre = new Panino("Panino Salsiccia", "Bonono", 3.5f, false);
        //Panino paninoQuattro = new Panino("Panino Broccoli e Broccoli", "Bono?", 2.5f, true);

        public bool insert(Panino pann)
        {
            using (SqlConnection con = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSER INTO Panino (nome, descrizione, prezzo, vegan) VALUES (@nome," +
                    "@descrizione, @prezzo, @vegan)";

            }
                return false;
        }

        public List<Panino>? findAll()
        {
            return null;
        }


    }
}
