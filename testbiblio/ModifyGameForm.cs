using System;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class ModifyGameForm : Form
    {
        private string? description;
        private int nombre_joueurs;
        private int nombre_cartes;
        private int nombre_joueurs_max;

        public ModifyGameForm(int id)
        {
            InitializeComponent();
        }

        public ModifyGameForm(int id, string? nom, string? description, int nombre_joueurs, int nombre_cartes, int nombre_joueurs_max) : this(id)
        {
            Nom = nom;
            this.description = description;
            this.nombre_joueurs = nombre_joueurs;
            this.nombre_cartes = nombre_cartes;
            this.nombre_joueurs_max = nombre_joueurs_max;
        }

        public string? Nom { get; internal set; }
        public string? Description { get; internal set; }
        public int NombreJoueurs { get; internal set; }
        public int NombreCartes { get; internal set; }
        public int NombreJoueursMax { get; internal set; }

        private void ModifyGameForm_Load(object sender, EventArgs e)
        {
            // Charger les données actuelles dans les contrôles
            txtNom.Text = Nom;
            txtDescription.Text = Description;
            txtNombreJoueurs.Text = NombreJoueurs.ToString();
            txtNombreCartes.Text = NombreCartes.ToString();
            txtNombreJoueursMax.Text = NombreJoueursMax.ToString();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Enregistrer les modifications
            Nom = txtNom.Text;
            Description = txtDescription.Text;
            NombreJoueurs = int.Parse(txtNombreJoueurs.Text);
            NombreCartes = int.Parse(txtNombreCartes.Text);
            NombreJoueursMax = int.Parse(txtNombreJoueursMax.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
