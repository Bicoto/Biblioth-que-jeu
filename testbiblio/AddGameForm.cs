using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class AddGameForm : Form
    {
        public string Nom { get; private set; }
        public string Description { get; private set; }
        public int NombreJoueurs { get; private set; }
        public int NombreCartes { get; private set; }
        public int NombreJoueursMax { get; private set; }

        public AddGameForm()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Nom = txtNom.Text;
            Description = txtDescription.Text;
            NombreJoueurs = int.Parse(txtNombreJoueurs.Text);
            NombreCartes = int.Parse(txtNombreCartes.Text);
            NombreJoueursMax = int.Parse(txtNombreJoueursMax.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}

