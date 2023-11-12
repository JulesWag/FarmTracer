namespace FarmTracer
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            lbSalarie = new Label();
            btnSalarie = new Button();
            lbSite = new Label();
            btnSite = new Button();
            btnService = new Button();
            lbService = new Label();
            btnDeco = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbSalarie
            // 
            lbSalarie.AutoSize = true;
            lbSalarie.Location = new Point(534, 243);
            lbSalarie.Name = "lbSalarie";
            lbSalarie.Size = new Size(67, 20);
            lbSalarie.TabIndex = 0;
            lbSalarie.Text = "Salariés :";
            // 
            // btnSalarie
            // 
            btnSalarie.Location = new Point(614, 239);
            btnSalarie.Name = "btnSalarie";
            btnSalarie.Size = new Size(94, 29);
            btnSalarie.TabIndex = 1;
            btnSalarie.Text = "Modifier";
            btnSalarie.UseVisualStyleBackColor = true;
            btnSalarie.Click += btnSalarie_Click;
            // 
            // lbSite
            // 
            lbSite.AutoSize = true;
            lbSite.Location = new Point(534, 115);
            lbSite.Name = "lbSite";
            lbSite.Size = new Size(47, 20);
            lbSite.TabIndex = 2;
            lbSite.Text = "Sites :";
            // 
            // btnSite
            // 
            btnSite.Location = new Point(614, 111);
            btnSite.Name = "btnSite";
            btnSite.Size = new Size(94, 29);
            btnSite.TabIndex = 3;
            btnSite.Text = "Modifier";
            btnSite.UseVisualStyleBackColor = true;
            btnSite.Click += btnSite_Click;
            // 
            // btnService
            // 
            btnService.Location = new Point(614, 172);
            btnService.Name = "btnService";
            btnService.Size = new Size(94, 29);
            btnService.TabIndex = 4;
            btnService.Text = "Modifier";
            btnService.UseVisualStyleBackColor = true;
            btnService.Click += btnService_Click;
            // 
            // lbService
            // 
            lbService.AutoSize = true;
            lbService.Location = new Point(532, 176);
            lbService.Name = "lbService";
            lbService.Size = new Size(73, 20);
            lbService.TabIndex = 5;
            lbService.Text = "Services : ";
            // 
            // btnDeco
            // 
            btnDeco.Location = new Point(665, 409);
            btnDeco.Name = "btnDeco";
            btnDeco.Size = new Size(123, 29);
            btnDeco.TabIndex = 6;
            btnDeco.Text = "Déconnection";
            btnDeco.UseVisualStyleBackColor = true;
            btnDeco.Click += btnDeco_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnDeco);
            Controls.Add(lbService);
            Controls.Add(btnService);
            Controls.Add(btnSite);
            Controls.Add(lbSite);
            Controls.Add(btnSalarie);
            Controls.Add(lbSalarie);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSalarie;
        private Button btnSalarie;
        private Label lbSite;
        private Button btnSite;
        private Button btnService;
        private Label lbService;
        private Button btnDeco;
        private PictureBox pictureBox1;
    }
}