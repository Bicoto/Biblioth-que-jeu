using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string mdp = txtPassword.Text;
            string connectionString = "Server=localhost;Database=bibliotheque;User ID=root;Password='';";

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT role FROM utilisateurs WHERE nom_utilisateur = @user AND mot_de_passe = @mdp";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@mdp", mdp);
                string role = cmd.ExecuteScalar()?.ToString();

                if (role != null)
                {
                    if (role == "administrateur")
                    {
                        ViewUser viewUser = new ViewUser(conn);
                        viewUser.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserView userView = new UserView(conn);
                        userView.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code à exécuter lors du chargement du formulaire
        }
    }
}
