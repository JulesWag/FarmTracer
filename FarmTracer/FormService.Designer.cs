namespace FarmTracer
{
    partial class FormService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));
            gridService = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbAjout = new TextBox();
            btnAjout = new Button();
            btnModifier = new Button();
            tbModifier = new TextBox();
            btnValider = new Button();
            btnSupprimer = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gridService
            // 
            gridService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridService.Location = new Point(248, 12);
            gridService.Name = "gridService";
            gridService.RowHeadersWidth = 51;
            gridService.RowTemplate.Height = 29;
            gridService.Size = new Size(540, 426);
            gridService.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 10;
            label1.Text = "Ajouter un Service ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 11;
            label2.Text = "Nom du Service :";
            // 
            // tbAjout
            // 
            tbAjout.Location = new Point(12, 63);
            tbAjout.Name = "tbAjout";
            tbAjout.Size = new Size(230, 27);
            tbAjout.TabIndex = 12;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(148, 96);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(94, 29);
            btnAjout.TabIndex = 13;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(148, 219);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 29);
            btnModifier.TabIndex = 14;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // tbModifier
            // 
            tbModifier.Location = new Point(12, 254);
            tbModifier.Name = "tbModifier";
            tbModifier.Size = new Size(230, 27);
            tbModifier.TabIndex = 15;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(148, 287);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 16;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(148, 409);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 17;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 397);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSupprimer);
            Controls.Add(btnValider);
            Controls.Add(tbModifier);
            Controls.Add(btnModifier);
            Controls.Add(btnAjout);
            Controls.Add(tbAjout);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridService);
            Name = "FormService";
            Text = "FormService";
            ((System.ComponentModel.ISupportInitialize)gridService).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridService;
        private Label label1;
        private Label label2;
        private TextBox tbAjout;
        private Button btnAjout;
        private Button btnModifier;
        private TextBox tbModifier;
        private Button btnValider;
        private Button btnSupprimer;
        private PictureBox pictureBox1;
    }
}