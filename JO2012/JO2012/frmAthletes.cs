using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JO2012
{
    public partial class frmAthletes : Form
    {
        public SqlCommand cmd;
        public TreeNode contactNode;
        public SqlDataReader reader;
        public SqlConnection cx;
        public frmAthletes()
        {
            InitializeComponent();
        }

        public Boolean connecter()
        {
            Boolean ok = true;

            cx.ConnectionString = "Data Source=SRV-APP-2\\SQLSERVERSIO;Initial Catalog=jo2012;Integrated Security=True";

            try
            {
                cx.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ok = false;
            }

            return ok;
        }

        private void frmAthletes_Load(object sender, EventArgs e)
        {
            string Lettre;
            char Alpha;
            string Nom;
            int Code;
            string Prenom;

            cx = new SqlConnection();

            if (connecter() == false)
            {
                return;
            }

            lblNbrAthletes.Text = "Il y a " + getNombreAthlete() + " athlètes enregistrés";

            cmd = new SqlCommand("SELECT * FROM Athlete ORDER BY NomAthlete", cx);
            reader = cmd.ExecuteReader();

            TvNom.Nodes.Clear();

            Alpha = 'A';
            contactNode = TvNom.Nodes.Add(Alpha.ToString());

            while (reader.Read())
            {
                Nom = reader["NomAthlete"].ToString();
                Prenom = reader["PrenomAthlete"].ToString();

                Lettre = Nom.Substring(0, 1).ToUpper();

                while (Lettre.Equals(Alpha.ToString()) == false)
                {
                    Alpha++;
                    contactNode = TvNom.Nodes.Add(Alpha.ToString());
                }

                Code = (int)reader["CodeAthlete"];
                contactNode.Nodes.Add(Code.ToString(), Nom + ", " + Prenom);
            }
                
            while (Alpha < 'Z')
            {
                Alpha++;
                contactNode = TvNom.Nodes.Add(Alpha.ToString());
            }
            
            reader.Close();
        }

        public int getNombreAthlete()
        {
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Athlete", cx);

            int nb = (int)cmd.ExecuteScalar();

            return nb;
        }

        private void TvNom_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.Length == 1)
            {
                return;
            } else
            {
                int code = Int32.Parse(e.Node.Name);
                Lesresultats(code);

                cmd = new SqlCommand("SELECT A.NomAthlete, A.PrenomAthlete, P.NomPays, P.PhotoPays FROM Athlete A " +
                    "INNER JOIN Pays P ON P.CodePays = A.CodePays " +
                    "WHERE CodeAthlete = " + code, cx);
                reader = cmd.ExecuteReader();
                reader.Read();

                // Récupération du nom de l'athlète
                string Nom = reader["NomAthlete"].ToString();
                lblNomShow.Text = Nom;

                // Récupération du prénom de l'athlète
                string Prenom = reader["PrenomAthlete"].ToString();
                lblPrenomShow.Text = Prenom;

                // Récupération du pays de l'athlète
                string Pays = reader["NomPays"].ToString();
                lblPaysShow.Text = Pays;

                // Récupération du drapeau
                string PhotoPays = reader["PhotoPays"].ToString();
                imageDrapeau.Image = Image.FromFile("drapeaux/" + PhotoPays + ".gif");

                reader.Close();

            }
        }

        public void Lesresultats(int code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cx;
            cmd.CommandText = "Resultats";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }
    }
}
