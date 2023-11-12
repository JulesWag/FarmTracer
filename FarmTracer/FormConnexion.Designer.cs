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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            lbUser = new Label();
            lbPassword = new Label();
            btnConnexion = new Button();
            btnVisiteur = new Button();
            tbPassword = new TextBox();
            tbUser = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(202, 12);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(123, 20);
            lbUser.TabIndex = 0;
            lbUser.Text = "Nom d'utilisateur";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(202, 80);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(98, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Mot de passe";
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(202, 139);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 2;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnVisiteur
            // 
            btnVisiteur.BackColor = Color.SkyBlue;
            btnVisiteur.Location = new Point(406, 35);
            btnVisiteur.Name = "btnVisiteur";
            btnVisiteur.Size = new Size(362, 84);
            btnVisiteur.TabIndex = 3;
            btnVisiteur.Text = "Mode Visiteur";
            btnVisiteur.UseVisualStyleBackColor = false;
            btnVisiteur.Click += btnVisiteur_Click_1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(202, 103);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(202, 35);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(125, 27);
            tbUser.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(821, 285);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(812, 461);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tbUser);
            Controls.Add(tbPassword);
            Controls.Add(btnVisiteur);
            Controls.Add(btnConnexion);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Name = "FormConnexion";
            Text = "Connexion FarmTracer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}