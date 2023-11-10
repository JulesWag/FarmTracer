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
            lbSalarie = new Label();
            btnSalarie = new Button();
            lbSite = new Label();
            btnSite = new Button();
            btnService = new Button();
            lbService = new Label();
            SuspendLayout();
            // 
            // lbSalarie
            // 
            lbSalarie.AutoSize = true;
            lbSalarie.Location = new Point(75, 93);
            lbSalarie.Name = "lbSalarie";
            lbSalarie.Size = new Size(60, 20);
            lbSalarie.TabIndex = 0;
            lbSalarie.Text = "Salariés";
            // 
            // btnSalarie
            // 
            btnSalarie.Location = new Point(63, 116);
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
            lbSite.Location = new Point(312, 93);
            lbSite.Name = "lbSite";
            lbSite.Size = new Size(40, 20);
            lbSite.TabIndex = 2;
            lbSite.Text = "Sites";
            // 
            // btnSite
            // 
            btnSite.Location = new Point(287, 116);
            btnSite.Name = "btnSite";
            btnSite.Size = new Size(94, 29);
            btnSite.TabIndex = 3;
            btnSite.Text = "Modifier";
            btnSite.UseVisualStyleBackColor = true;
            btnSite.Click += btnSite_Click;
            // 
            // btnService
            // 
            btnService.Location = new Point(505, 116);
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
            lbService.Location = new Point(523, 93);
            lbService.Name = "lbService";
            lbService.Size = new Size(62, 20);
            lbService.TabIndex = 5;
            lbService.Text = "Services";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbService);
            Controls.Add(btnService);
            Controls.Add(btnSite);
            Controls.Add(lbSite);
            Controls.Add(btnSalarie);
            Controls.Add(lbSalarie);
            Name = "FormAdmin";
            Text = "FormAdmin";
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
    }
}