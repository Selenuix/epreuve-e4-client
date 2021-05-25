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
    public partial class FrmTest : Form
    {
        public SqlConnection cx;

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

        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            cx = new SqlConnection();

            if (connecter() == false)
            {
                return;
            }

            MessageBox.Show("Connexion réussie");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Athlete", cx);

            int nb = (int)cmd.ExecuteScalar();
            MessageBox.Show("Il y a " + nb + " athlètes enregistrés");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(DateEntree) FROM Sport", cx);

            String dateDernierSport = (String)cmd.ExecuteScalar();
            MessageBox.Show("La date d'entrée du sport le plus récent est " + dateDernierSport);
        }

        private void btnSuperAthlete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Athlete VALUES ('6', 'CISZEK', 'Anthony', 'FRA')", cx);
            cmd.ExecuteNonQuery();
        }

        private void btnLesAthletes_Click(object sender, EventArgs e)
        {
            frmAthletes athletes = new frmAthletes();
            athletes.Show();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void btnFermerConnectionSql_Click(object sender, EventArgs e)
        {
            cx.Close();
        }
    }
}
