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
            dataGridView1 = new DataGridView();
            btnAjouterSite = new Button();
            btnValider = new Button();
            btnSupprimer = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(560, 426);
            dataGridView1.TabIndex = 0;
            // 
            // btnAjouterSite
            // 
            btnAjouterSite.Location = new Point(12, 373);
            btnAjouterSite.Name = "btnAjouterSite";
            btnAjouterSite.Size = new Size(94, 29);
            btnAjouterSite.TabIndex = 1;
            btnAjouterSite.Text = "Modifier";
            btnAjouterSite.UseVisualStyleBackColor = true;
            btnAjouterSite.Click += button1_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(128, 373);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 2;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(68, 408);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            
            // 
            // FormSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnSupprimer);
            Controls.Add(btnValider);
            Controls.Add(btnAjouterSite);
            Controls.Add(dataGridView1);
            Name = "FormSite";
            Text = "FormSite";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAjouterSite;
        private Button btnValider;
        private Button btnSupprimer;
        private TextBox textBox1;
    }
}