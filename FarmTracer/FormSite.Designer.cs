namespace FarmTracer
{
    partial class FormSite
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
            dataGridViewSite = new DataGridView();
            btnModifier = new Button();
            btnValider = new Button();
            btnSupprimer = new Button();
            tbNomSite = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAjouter = new Button();
            tbModif = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSite).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSite
            // 
            dataGridViewSite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSite.Location = new Point(228, 12);
            dataGridViewSite.Name = "dataGridViewSite";
            dataGridViewSite.RowHeadersWidth = 51;
            dataGridViewSite.RowTemplate.Height = 29;
            dataGridViewSite.Size = new Size(560, 426);
            dataGridViewSite.TabIndex = 0;
            dataGridViewSite.CellContentClick += dataGridViewSite_CellContentClick;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(128, 194);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 29);
            btnModifier.TabIndex = 1;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(68, 351);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 2;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(12, 409);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // tbNomSite
            // 
            tbNomSite.Location = new Point(104, 43);
            tbNomSite.Name = "tbNomSite";
            tbNomSite.Size = new Size(118, 27);
            tbNomSite.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 5;
            label1.Text = "Ajouter un Site :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 46);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 6;
            label2.Text = "Nom du site : ";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(144, 76);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(78, 29);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // tbModif
            // 
            tbModif.Location = new Point(12, 318);
            tbModif.Name = "tbModif";
            tbModif.Size = new Size(210, 27);
            tbModif.TabIndex = 8;
            tbModif.TextChanged += tbModif_TextChanged;
            // 
            // FormSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbModif);
            Controls.Add(btnAjouter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNomSite);
            Controls.Add(btnSupprimer);
            Controls.Add(btnValider);
            Controls.Add(btnModifier);
            Controls.Add(dataGridViewSite);
            Name = "FormSite";
            Text = "FormSite";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSite;
        private Button btnModifier;
        private Button btnValider;
        private Button btnSupprimer;
        private TextBox tbNomSite;
        private Label label1;
        private Label label2;
        private Button btnAjouter;
        private TextBox tbModif;
    }
}