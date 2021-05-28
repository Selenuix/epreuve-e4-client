using System;
using System.Windows.Forms;

namespace JO2012
{
    public partial class frmVins : Form
    {
        public TreeNode contactNode;
        public frmVins()
        {
            InitializeComponent();
        }

        private void frmAthletes_Load(object sender, EventArgs e)
        {
            ApiService api = new ApiService();
            api.getVins();

            /*string Lettre;
            char Alpha;
            string Nom;
            int Code;
            string Prenom;

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
            */
        }


        private void TvNom_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /* if (e.Node.Text.Length == 1)
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

                 try
                 {
                     // Récupération du drapeau
                     string PhotoPays = reader["PhotoPays"].ToString();
                     imageDrapeau.Image = Image.FromFile("drapeaux/" + PhotoPays + ".gif");
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("An error has occured: " + ex);
                     imageDrapeau.Image = Image.FromFile("drapeaux/sans.png");
                 }

                 reader.Close();


             }*/
        }

        public void Lesresultats(int code)
        {
            /* SqlCommand cmd = new SqlCommand();
            cmd.Connection = cx;
            cmd.CommandText = "Resultats";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            */
        }

        private void lblPays_Click(object sender, EventArgs e)
        {

        }
    }
}
