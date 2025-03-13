namespace $safeprojectname$
{
    partial class AddGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNombreJoueurs;
        private System.Windows.Forms.TextBox txtNombreCartes;
        private System.Windows.Forms.TextBox txtNombreJoueursMax;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;

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
            btnAjouter = new Button();
            btnAnnuler = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(100, 46);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(200, 27);
            txtNom.TabIndex = 0;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 116);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtNombreJoueurs
            // 
            txtNombreJoueurs.Location = new Point(100, 197);
            txtNombreJoueurs.Name = "txtNombreJoueurs";
            txtNombreJoueurs.Size = new Size(200, 27);
            txtNombreJoueurs.TabIndex = 2;
            // 
            // txtNombreCartes
            // 
            txtNombreCartes.Location = new Point(100, 270);
            txtNombreCartes.Name = "txtNombreCartes";
            txtNombreCartes.Size = new Size(200, 27);
            txtNombreCartes.TabIndex = 3;
            // 
            // txtNombreJoueursMax
            // 
            txtNombreJoueursMax.Location = new Point(100, 361);
            txtNombreJoueursMax.Name = "txtNombreJoueursMax";
            txtNombreJoueursMax.Size = new Size(200, 27);
            txtNombreJoueursMax.TabIndex = 4;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(100, 451);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 29);
            btnAjouter.TabIndex = 5;
            btnAjouter.Text = "Ajouter";
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(225, 451);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 29);
            btnAnnuler.TabIndex = 6;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 24);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 7;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 94);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 8;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 175);
            label3.Name = "label3";
            label3.Size = new Size(127, 19);
            label3.TabIndex = 9;
            label3.Text = "Nombre de Joueur ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MintCream;
            label4.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 248);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 10;
            label4.Text = "Nombre de Carte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MintCream;
            label5.Font = new Font("Sitka Text", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 339);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 11;
            label5.Text = "Nombre de Joueur Max";
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(437, 528);
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
            Controls.Add(btnAjouter);
            Controls.Add(btnAnnuler);
            Name = "AddGameForm";
            Text = "Ajouter un Jeu";
            Load += AddGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
