using FarmTracer.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmTracer.API.Helper;

namespace FarmTracer
{
    public partial class FormAccueilVisiteur : Form
    {
        private readonly Helper _helper;

        public FormAccueilVisiteur()
        {
            InitializeComponent();
            ConfigureDataGridView();

            _helper = new Helper();
            buttonSearch.Click += buttonSearch_Click;
            this.Load += async (sender, e) => await LoadSalariesAsync();

            comboBoxFilterType.Items.Add("Nom");
            comboBoxFilterType.Items.Add("Prénom");
            comboBoxFilterType.Items.Add("Site");
            comboBoxFilterType.Items.Add("Service");
            comboBoxFilterType.SelectedIndex = 0; // Sélectionnez "Nom" par défaut
        }

        private void ConfigureDataGridView()
        {
            dataGridViewSalaries.AutoGenerateColumns = true;
        }

        private async Task LoadSalariesAsync()
        {
            try
            {
                var salaries = await _helper.GetAllSalaries();
                dataGridViewSalaries.DataSource = salaries;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des salariés : " + ex.Message);
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            string filterType = comboBoxFilterType.SelectedItem.ToString();

            dataGridViewSalaries.DataSource = await FilterSalaries(searchTerm, filterType);
        }

        private async Task<List<Salarie>> FilterSalaries(string searchTerm, string filterType)
        {
            var allSalaries = await _helper.GetAllSalaries();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return allSalaries;
            }

            searchTerm = searchTerm.ToLower();
            switch (filterType)
            {
                case "Nom":
                    return allSalaries.Where(s => s.Nom.ToLower().Contains(searchTerm)).ToList();
                case "Prénom":
                    return allSalaries.Where(s => s.Prenom.ToLower().Contains(searchTerm)).ToList();
                case "Site":
                    return allSalaries.Where(s => s.Site.ToLower().Contains(searchTerm)).ToList();
                case "Service":
                    return allSalaries.Where(s => s.Service.ToLower().Contains(searchTerm)).ToList();
                default:
                    return allSalaries;
            }
        }

        private async void btnAddRandomSalarie_Click(object sender, EventArgs e)
        {
            await AddRandomSalarieAsync();
        }

        private async Task AddRandomSalarieAsync()
        {
            try
            {
                var random = new Random();

                // Créez une liste pour stocker temporairement les nouveaux salariés
                List<Salarie> newSalaries = new List<Salarie>();

                for (int i = 0; i < 200; i++) // Boucle pour créer 200 salariés
                {
                    var newSalarie = new Salarie
                    {
                        Nom = "Nom" + random.Next(1000, 9999),
                        Prenom = "Prenom" + random.Next(1000, 9999),
                        TelephoneFixe = "02" + random.Next(10000000, 99999999),
                        TelephonePortable = "06" + random.Next(10000000, 99999999),
                        Email = $"email{random.Next(1000, 9999)}@entreprise.com",
                        Service = new[] { "Ressources Humaines", "Comptabilité", "SAV", "Accueil", "Commercial", "Informatique", "Juridique" }[random.Next(7)],
                        Site = new[] { "Paris", "Nantes", "Toulouse", "Nice", "Lille" }[random.Next(5)]
                    };
                    newSalaries.Add(newSalarie);
                }

                // Ajouter tous les salariés en une seule fois si votre API le permet
                // Sinon, vous pouvez boucler sur chaque salarié et l'ajouter individuellement
                foreach (var salarie in newSalaries)
                {
                    await _helper.AddSalarie(salarie);
                }

                await LoadSalariesAsync(); // Mise à jour de l'affichage
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de salariés aléatoires : " + ex.Message);
            }
    }
            private void btnQuit_Click(object sender, EventArgs e)
        {

            var FormConnexion   = new FormConnexion();
            FormConnexion.Show();
            this.Hide();
        }
    }
}
