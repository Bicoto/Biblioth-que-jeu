using System.Drawing;
using System.Windows.Forms;

namespace $safeprojectname$
{
    partial class ViewUser
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier; // Nouveau bouton Modifier
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRechercher;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAjouter = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            lblTitre = new Label();
            txtRecherche = new TextBox();
            btnRechercher = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(450, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 527);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.LightBlue;
            btnAjouter.Location = new Point(1251, 207);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(87, 35);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Red;
            btnSupprimer.Location = new Point(1251, 280);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(87, 35);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.LightGreen;
            btnModifier.Location = new Point(1251, 345);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(87, 35);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.BackColor = Color.MintCream;
            lblTitre.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(558, 37);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(571, 75);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "BIBLIOTHÈQUE DE JEUX";
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(450, 154);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(285, 27);
            txtRecherche.TabIndex = 4;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(771, 154);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(100, 30);
            btnRechercher.TabIndex = 6;
            btnRechercher.Text = "Rechercher";
            btnRechercher.Click += btnRechercher_Click;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1804, 746);
            Controls.Add(dataGridView1);
            Controls.Add(btnAjouter);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(lblTitre);
            Controls.Add(txtRecherche);
            Controls.Add(btnRechercher);
            Name = "ViewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualisation des Jeux";
            WindowState = FormWindowState.Maximized;
            Load += ViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                // Dans votre méthode LoadData ou InitializeComponent
    dataGridView1.Columns["id"].ReadOnly = true;
    
    dataGridView1.Columns["nom"].ReadOnly = true;

    dataGridView1.Columns["description"].ReadOnly = true;

    dataGridView1.Columns["nombre_joueurs"].ReadOnly = true;

    dataGridView1.Columns["nombre_cartes"].ReadOnly = true;
   
    dataGridView1.Columns["nombre_joueurs_max"].ReadOnly = true;

        }
         private Button button1;
    }
}
