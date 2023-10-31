namespace FarmTracer
{
    partial class Form1
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
            btnConnexion.Location = new Point(12, 409);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 2;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            // 
            // btnVisiteur
            // 
            btnVisiteur.Location = new Point(647, 409);
            btnVisiteur.Name = "btnVisiteur";
            btnVisiteur.Size = new Size(141, 29);
            btnVisiteur.TabIndex = 3;
            btnVisiteur.Text = "Mode Visiteur";
            btnVisiteur.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisiteur);
            Controls.Add(btnConnexion);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Name = "Form1";
            Text = "Connexion FarmTracer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUser;
        private Label lbPassword;
        private Button btnConnexion;
        private Button btnVisiteur;
    }
}