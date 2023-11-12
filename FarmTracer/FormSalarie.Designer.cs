namespace FarmTracer
{
    partial class FormSalarie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalarie));
            tbID = new TextBox();
            tbNom = new TextBox();
            tbPrenom = new TextBox();
            tbTf = new TextBox();
            tbTp = new TextBox();
            tbEmail = new TextBox();
            tbService = new TextBox();
            tbSite = new TextBox();
            lbId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnValider = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            btnRechercher = new Button();
            dataGridViewSalaries = new DataGridView();
            tbRecherche = new TextBox();
            btnAjouter = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalaries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbID
            // 
            tbID.Location = new Point(12, 12);
            tbID.Name = "tbID";
            tbID.Size = new Size(173, 27);
            tbID.TabIndex = 0;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(12, 45);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(173, 27);
            tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(12, 78);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(173, 27);
            tbPrenom.TabIndex = 2;
            // 
            // tbTf
            // 
            tbTf.Location = new Point(12, 111);
            tbTf.Name = "tbTf";
            tbTf.Size = new Size(173, 27);
            tbTf.TabIndex = 3;
            // 
            // tbTp
            // 
            tbTp.Location = new Point(12, 144);
            tbTp.Name = "tbTp";
            tbTp.Size = new Size(173, 27);
            tbTp.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 177);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(173, 27);
            tbEmail.TabIndex = 5;
            // 
            // tbService
            // 
            tbService.Location = new Point(12, 210);
            tbService.Name = "tbService";
            tbService.Size = new Size(173, 27);
            tbService.TabIndex = 6;
            // 
            // tbSite
            // 
            tbSite.Location = new Point(12, 243);
            tbSite.Name = "tbSite";
            tbSite.Size = new Size(173, 27);
            tbSite.TabIndex = 7;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(191, 15);
            lbId.Name = "lbId";
            lbId.Size = new Size(24, 20);
            lbId.TabIndex = 8;
            lbId.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 246);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 9;
            label2.Text = "Site";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 213);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 10;
            label3.Text = "Service";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 180);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 147);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 12;
            label5.Text = "Téléphone Portable";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 114);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 13;
            label6.Text = "Téléphone Fixe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 81);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 14;
            label7.Text = "Prénom";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(191, 48);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 15;
            label8.Text = "Nom";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(143, 409);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 16;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(38, 409);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 29);
            btnModifier.TabIndex = 17;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(334, 409);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 18;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(234, 325);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(94, 29);
            btnRechercher.TabIndex = 19;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // dataGridViewSalaries
            // 
            dataGridViewSalaries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalaries.Location = new Point(334, 12);
            dataGridViewSalaries.Name = "dataGridViewSalaries";
            dataGridViewSalaries.RowHeadersWidth = 51;
            dataGridViewSalaries.RowTemplate.Height = 29;
            dataGridViewSalaries.Size = new Size(454, 391);
            dataGridViewSalaries.TabIndex = 20;
            // 
            // tbRecherche
            // 
            tbRecherche.Location = new Point(69, 327);
            tbRecherche.Name = "tbRecherche";
            tbRecherche.Size = new Size(159, 27);
            tbRecherche.TabIndex = 21;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 276);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 22;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(730, 409);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormSalarie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnAjouter);
            Controls.Add(tbRecherche);
            Controls.Add(dataGridViewSalaries);
            Controls.Add(btnRechercher);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnValider);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbId);
            Controls.Add(tbSite);
            Controls.Add(tbService);
            Controls.Add(tbEmail);
            Controls.Add(tbTp);
            Controls.Add(tbTf);
            Controls.Add(tbPrenom);
            Controls.Add(tbNom);
            Controls.Add(tbID);
            Name = "FormSalarie";
            Text = "FormSalarie";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalaries).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbID;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private TextBox tbTf;
        private TextBox tbTp;
        private TextBox tbEmail;
        private TextBox tbService;
        private TextBox tbSite;
        private Label lbId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnValider;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnRechercher;
        private DataGridView dataGridViewSalaries;
        private TextBox tbRecherche;
        private Button btnAjouter;
        private PictureBox pictureBox1;
    }
}