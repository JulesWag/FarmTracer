namespace FarmTracer
{
    partial class FormAccueilVisiteur
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
            dataGridViewSalaries = new DataGridView();
            textBoxSearch = new TextBox();
            comboBoxFilterType = new ComboBox();
            buttonSearch = new Button();
            lbFiltre = new Label();
            btnAddRandomSalarie = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalaries).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSalaries
            // 
            dataGridViewSalaries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalaries.Location = new Point(175, 12);
            dataGridViewSalaries.Name = "dataGridViewSalaries";
            dataGridViewSalaries.RowHeadersWidth = 51;
            dataGridViewSalaries.RowTemplate.Height = 29;
            dataGridViewSalaries.Size = new Size(613, 426);
            dataGridViewSalaries.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 217);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(151, 27);
            textBoxSearch.TabIndex = 1;
            // 
            // comboBoxFilterType
            // 
            comboBoxFilterType.FormattingEnabled = true;
            comboBoxFilterType.Location = new Point(12, 75);
            comboBoxFilterType.Name = "comboBoxFilterType";
            comboBoxFilterType.Size = new Size(151, 28);
            comboBoxFilterType.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(36, 278);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Recherche";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // lbFiltre
            // 
            lbFiltre.AutoSize = true;
            lbFiltre.Location = new Point(12, 43);
            lbFiltre.Name = "lbFiltre";
            lbFiltre.Size = new Size(42, 20);
            lbFiltre.TabIndex = 4;
            lbFiltre.Text = "Filtre";
            // 
            // btnAddRandomSalarie
            // 
            btnAddRandomSalarie.Location = new Point(36, 344);
            btnAddRandomSalarie.Name = "btnAddRandomSalarie";
            btnAddRandomSalarie.Size = new Size(94, 29);
            btnAddRandomSalarie.TabIndex = 5;
            btnAddRandomSalarie.Text = "Add";
            btnAddRandomSalarie.UseVisualStyleBackColor = true;
            btnAddRandomSalarie.Click += btnAddRandomSalarie_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(12, 409);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(71, 29);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quitter";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // FormAccueilVisiteur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnAddRandomSalarie);
            Controls.Add(lbFiltre);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxFilterType);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewSalaries);
            Name = "FormAccueilVisiteur";
            Text = "Visiteur";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalaries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSalaries;
        private TextBox textBoxSearch;
        private ComboBox comboBoxFilterType;
        private Button buttonSearch;
        private Label lbFiltre;
        private Button btnAddRandomSalarie;
        private Button btnQuit;
    }
}