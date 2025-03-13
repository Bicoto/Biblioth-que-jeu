using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class ViewUser : Form
    {
        private MySqlConnection conn;

        public ViewUser(MySqlConnection conn)
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Ouvrir un nouveau formulaire pour ajouter un jeu
            AddGameForm addGameForm = new AddGameForm();
            if (addGameForm.ShowDialog() == DialogResult.OK)
            {
                // Récupérer les détails du jeu depuis le formulaire
                string nom = addGameForm.Nom;
                string description = addGameForm.Description;
                int nombre_joueurs = addGameForm.NombreJoueurs;
                int nombre_cartes = addGameForm.NombreCartes;
                int nombre_joueurs_max = addGameForm.NombreJoueursMax;

                // Insérer le jeu dans la base de données
                string query = "INSERT INTO jeux (nom, description, nombre_joueurs, nombre_cartes, nombre_joueurs_max) VALUES (@nom, @description, @nombre_joueurs, @nombre_cartes, @nombre_joueurs_max)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@nombre_joueurs", nombre_joueurs);
                cmd.Parameters.AddWithValue("@nombre_cartes", nombre_cartes);
                cmd.Parameters.AddWithValue("@nombre_joueurs_max", nombre_joueurs_max);
                cmd.ExecuteNonQuery();

                // Recharger les données
                LoadData();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Logique pour supprimer un jeu sélectionné
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                string query = "DELETE FROM jeux WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un jeu à supprimer.");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Logique pour modifier un jeu sélectionné
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                string nom = dataGridView1.SelectedRows[0].Cells["nom"].Value.ToString();
                string description = dataGridView1.SelectedRows[0].Cells["description"].Value.ToString();
                int nombre_joueurs = int.Parse(dataGridView1.SelectedRows[0].Cells["nombre_joueurs"].Value.ToString());
                int nombre_cartes = int.Parse(dataGridView1.SelectedRows[0].Cells["nombre_cartes"].Value.ToString());
                int nombre_joueurs_max = int.Parse(dataGridView1.SelectedRows[0].Cells["nombre_joueurs_max"].Value.ToString());

                // Ouvrir un formulaire pour modifier le jeu
                ModifyGameForm modifyGameForm = new ModifyGameForm(id, nom, description, nombre_joueurs, nombre_cartes, nombre_joueurs_max);
                if (modifyGameForm.ShowDialog() == DialogResult.OK)
                {
                    // Récupérer les détails modifiés du jeu
                    nom = modifyGameForm.Nom;
                    description = modifyGameForm.Description;
                    nombre_joueurs = modifyGameForm.NombreJoueurs;
                    nombre_cartes = modifyGameForm.NombreCartes;
                    nombre_joueurs_max = modifyGameForm.NombreJoueursMax;

                    // Mettre à jour le jeu dans la base de données
                    string query = "UPDATE jeux SET nom = @nom, description = @description, nombre_joueurs = @nombre_joueurs, nombre_cartes = @nombre_cartes, nombre_joueurs_max = @nombre_joueurs_max WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@nombre_joueurs", nombre_joueurs);
                    cmd.Parameters.AddWithValue("@nombre_cartes", nombre_cartes);
                    cmd.Parameters.AddWithValue("@nombre_joueurs_max", nombre_joueurs_max);
                    cmd.ExecuteNonQuery();

                    // Recharger les données
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un jeu à modifier.");
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string searchText = txtRecherche.Text;
            LoadData(searchText);
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtRecherche.Text;
            LoadData(searchText);
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            // Code à exécuter lors du chargement du formulaire
        }
    }
}
