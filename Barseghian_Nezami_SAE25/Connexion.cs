using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barseghian_Nezami_SAE25.Utils
{
    //comentaitre pour voir si je suis pas un boufon
	// Classe basée sur le pattern Singleton pour s'assurer que la connexion n'est ouverte qu'une seule fois
    internal class Connexion
    {
		// Objet Connection
        private static SQLiteConnection connec;

        // Constructeur privé pour empêcher l'instanciation directe depuis l'extérieur.
        private Connexion() { }

        // Méthode publique pour obtenir l'instance unique de la classe.
        public static SQLiteConnection Connec
        {
            get
            {
                if (connec == null)
                {
                    try
                    {
                        string dbPath = @"..\..\Database\SDIS67.db";
                        if (!File.Exists(dbPath))
                            throw new FileNotFoundException("Database file not found at " + dbPath);

                        string chaine = $"Data Source={dbPath}";
                        connec = new SQLiteConnection(chaine);
                        connec.Open();

                        Console.WriteLine("Connexion à la base de données ouverte.");
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine($"Erreur lors de l'ouverture de la connexion : {err.Message}");
                        throw;
                    }
                }
                return connec;
            }
        }
        // Méthode pour fermer proprement la connexion
        public static void FermerConnexion()
        {
            if (connec != null)
            {
                try
                {
                    connec.Close();
                    connec.Dispose();
                    connec = null; // Libération pour permettre une nouvelle connexion propre
                }
                catch (Exception err)
                {
                    Console.WriteLine($"Erreur lors de la fermeture de la connexion : {err.Message}");
                }
            }
        }
    }
}
