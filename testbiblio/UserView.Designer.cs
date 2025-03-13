namespace $safeprojectname$
{
    partial class UserView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblTitre;

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
            txtRecherche = new TextBox();
            btnRechercher = new Button();
            lblTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 350);
            dataGridView1.TabIndex = 0;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(33, 95);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(500, 27);
            txtRecherche.TabIndex = 1;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(582, 95);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(100, 30);
            btnRechercher.TabIndex = 2;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(250, 10);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(377, 48);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Bibliothèque de Jeux";
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(892, 534);
            Controls.Add(lblTitre);
            Controls.Add(btnRechercher);
            Controls.Add(txtRecherche);
            Controls.Add(dataGridView1);
            Name = "UserView";
            Text = "Vue Utilisateur";
            Load += UserView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
