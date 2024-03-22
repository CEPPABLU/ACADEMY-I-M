using DB_lez01_introduzione.Models;
using System.Data.SqlClient;

namespace DB_lez01_introduzione
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string credenziali = "Server=ACADEMY2024-03\\SQLEXPRESS;Database=acc_lez_24_citta;User " +
                "Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";
            #region Elenco Citta
            List<Citta> elenco = new List<Citta>();
            using (SqlConnection connessione = new SqlConnection(credenziali))
            //using si utilizza per creare una connessione in modo sicuro che
            //si chiude in automatico una volta terminata l'istruzione
            {
                string query = "SELECT cittaID, nome, prov FROM Citta";
                SqlCommand comando = new SqlCommand(query, connessione);
                try
                {
                    connessione.Open();

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");

                        Citta citta = new Citta()
                        {
                            Id = Convert.ToInt32(reader[0]),
                            Nome = reader[1].ToString(),
                            Provincia = reader[2].ToString(),
                        };
                        elenco.Add(citta);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connessione.Close();
                }
            }
            foreach (Citta c in elenco)
            {
                Console.WriteLine($"{c.Nome} {c.Provincia} {c.Id}");
            }
            #endregion

            #region Inserisci Citta
            //string nome = "Pineto";
            //string prov = "PE";

            //using (SqlConnection con = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "INSERT INTO Citta(nome, prov) VALUES (@nomeCitta, @provCitta)";
            //    cmd.Parameters.AddWithValue("@nomeCitta", nome);
            //    cmd.Parameters.AddWithValue("@provCitta", prov);


            //    try
            //    {
            //        con.Open();
            //        int affRows = cmd.ExecuteNonQuery();
            //        if (affRows > 0)
            //        {
            //            Console.WriteLine("Stappo, inserimento ok!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Errore di inserimento");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Connessione chiusa");
            //        con.Close();
            //    }
            //}
            #endregion

            #region Elimina Citta
            //int idDaEliminare = 9;

            //using (SqlConnection con = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "DELETE FROM Citta WHERE cittaID = @idValue";
            //    cmd.Parameters.AddWithValue("@idValue", idDaEliminare);
            //try
            //{
            //    con.Open();

            //    int affRaws = cmd.ExecuteNonQuery();
            //    if (affRaws > 0)
            //        Console.WriteLine("Stappo");
            //    else
            //        Console.WriteLine("Errore");
            //}catch (Exception ex) 
            //{ 
            //        Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}

            //}
            #endregion

            #region Modifica della Citta

            Citta cit = new Citta()
            {
                Id = 2,
                Provincia = "PES"
            };

            using (SqlConnection con = new SqlConnection(credenziali))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Citta SET prov = @provValue WHERE cittaID = @idValue";
                cmd.Parameters.AddWithValue("@provValue", cit.Provincia);
                cmd.Parameters.AddWithValue("@provValue", cit.Id);

                try
                {
                    con.Open();

                    int affRaws = cmd.ExecuteNonQuery();
                    if (affRaws > 0)
                        Console.WriteLine("Stappo");
                    else
                        Console.WriteLine("Errore");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            #endregion
        }
    }
}
