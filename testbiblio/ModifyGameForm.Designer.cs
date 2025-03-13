namespace $safeprojectname$
{
    partial class ModifyGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNombreJoueurs;
        private System.Windows.Forms.TextBox txtNombreCartes;
        private System.Windows.Forms.TextBox txtNombreJoueursMax;
        private System.Windows.Forms.Button btnEnregistrer;

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
            txtNom = new TextBox();
            txtDescription = new TextBox();
            txtNombreJoueurs = new TextBox();
            txtNombreCartes = new TextBox();
            txtNombreJoueursMax = new TextBox();
            btnEnregistrer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(84, 54);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(200, 27);
            txtNom.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(84, 130);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 27);
            txtDescription.TabIndex = 3;
            // 
            // txtNombreJoueurs
            // 
            txtNombreJoueurs.Location = new Point(84, 208);
            txtNombreJoueurs.Name = "txtNombreJoueurs";
            txtNombreJoueurs.Size = new Size(200, 27);
            txtNombreJoueurs.TabIndex = 5;
            // 
            // txtNombreCartes
            // 
            txtNombreCartes.Location = new Point(84, 274);
            txtNombreCartes.Name = "txtNombreCartes";
            txtNombreCartes.Size = new Size(200, 27);
            txtNombreCartes.TabIndex = 7;
            // 
            // txtNombreJoueursMax
            // 
            txtNombreJoueursMax.Location = new Point(84, 344);
            txtNombreJoueursMax.Name = "txtNombreJoueursMax";
            txtNombreJoueursMax.Size = new Size(200, 27);
            txtNombreJoueursMax.TabIndex = 9;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.MintCream;
            btnEnregistrer.Location = new Point(125, 400);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(86, 30);
            btnEnregistrer.TabIndex = 10;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 32);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 11;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 12;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 186);
            label3.Name = "label3";
            label3.Size = new Size(127, 19);
            label3.TabIndex = 13;
            label3.Text = "Nombre de Joueur ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MintCream;
            label4.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 252);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 14;
            label4.Text = "Nombre de Carte";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MintCream;
            label5.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 322);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 15;
            label5.Text = "Nombre de Joueur Max";
            // 
            // ModifyGameForm
            // 
            BackColor = Color.MintCream;
            ClientSize = new Size(331, 474);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNom);
            Controls.Add(txtDescription);
            Controls.Add(txtNombreJoueurs);
            Controls.Add(txtNombreCartes);
            Controls.Add(txtNombreJoueursMax);
            Controls.Add(btnEnregistrer);
            Name = "ModifyGameForm";
            Text = "Modifier le Jeu";
            Load += ModifyGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
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

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
