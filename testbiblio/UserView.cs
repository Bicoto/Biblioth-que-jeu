using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class UserView : Form
    {
        private MySqlConnection conn;

        public UserView(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            LoadData();
        }

        private void LoadData(string searchQuery = "")
        {
            try
            {
                string query = "SELECT id, nom, description, nombre_joueurs, nombre_cartes, nombre_joueurs_max FROM jeux WHERE nom LIKE @search";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", $"%{searchQuery}%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de base de données : " + ex.Message);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string searchText = txtRecherche.Text;
            LoadData(searchText);
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            // Code à exécuter lors du chargement du formulaire
        }
    }
}
