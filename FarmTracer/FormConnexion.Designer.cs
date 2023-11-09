namespace FarmTracer
{
    partial class FormConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUser = new Label();
            lbPassword = new Label();
            btnConnexion = new Button();
            btnVisiteur = new Button();
            tbPassword = new TextBox();
            tbUser = new TextBox();
            SuspendLayout();
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(12, 88);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(123, 20);
            lbUser.TabIndex = 0;
            lbUser.Text = "Nom d'utilisateur";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(690, 88);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(98, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Mot de passe";
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(694, 409);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 2;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnVisiteur
            // 
            btnVisiteur.Location = new Point(12, 409);
            btnVisiteur.Name = "btnVisiteur";
            btnVisiteur.Size = new Size(141, 29);
            btnVisiteur.TabIndex = 3;
            btnVisiteur.Text = "Mode Visiteur";
            btnVisiteur.UseVisualStyleBackColor = true;
            btnVisiteur.Click += btnVisiteur_Click_1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(663, 111);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(12, 111);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(125, 27);
            tbUser.TabIndex = 5;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 461);
            Controls.Add(tbUser);
            Controls.Add(tbPassword);
            Controls.Add(btnVisiteur);
            Controls.Add(btnConnexion);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Name = "FormConnexion";
            Text = "Connexion FarmTracer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUser;
        private Label lbPassword;
        private Button btnConnexion;
        private Button btnVisiteur;
        private TextBox tbPassword;
        private TextBox tbUser;
    }
}