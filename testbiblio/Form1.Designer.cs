
namespace $safeprojectname$
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;

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
            btnConnexion = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblTitre = new Label();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.MintCream;
            btnConnexion.Location = new Point(634, 448);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 0;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(599, 268);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(164, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(599, 393);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(599, 245);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Identifiant";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(599, 370);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mot de passe";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.BackColor = Color.MintCream;
            lblTitre.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(527, 123);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(302, 75);
            lblTitre.TabIndex = 5;
            lblTitre.Text = "Connexion";
            lblTitre.Click += lblTitre_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1406, 797);
            Controls.Add(lblTitre);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnConnexion);
            Name = "Form1";
            Text = "Connexion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private Label lblTitre;
    }
}
