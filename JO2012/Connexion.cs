using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO2012
{
    class Connexion
    {
        // Déclaration des attributs
        private static SqlConnection c;

        // Constructeur privé et vide
        private Connexion() { }

        // Accesseurs
        public static SqlConnection GetInstance()
        {
            if (c == null)
            {
                string chaineDeConnexion;

                chaineDeConnexion = "Data Source=SRV-APP-2\\SQLSERVERSIO;" + "Initial Catalog=jo2012;" + "Integrated Security=True";

                try
                {
                    c = new SqlConnection(chaineDeConnexion);
                    c.Open();
                    Console.WriteLine("****************\n\n Connecté à " + c.Database + "\n\n****************");
                } catch (Exception ex)
                {
                    Console.WriteLine("Erreur de connexion : " + ex.Message);
                }
            }

            return c;
        }

    }
}
