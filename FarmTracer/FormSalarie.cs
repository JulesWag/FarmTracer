using FarmTracer.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmTracer.API.Helper;

namespace FarmTracer
{
    public partial class FormSalarie : Form
    {
        private readonly Helper _helper;
        private Salarie selectedSalarie; // Variable pour stocker le salarié sélectionné

        public FormSalarie()
        {
            InitializeComponent();
            ConfigureDataGridView();

            _helper = new Helper();
            this.Load += async (sender, e) => await LoadSalariesAsync();
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
                // Vous pouvez choisir de masquer certaines colonnes si elles ne doivent pas être affichées
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des salariés : " + ex.Message);
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewSalaries.SelectedRows.Count > 0)
            {
                var row = dataGridViewSalaries.SelectedRows[0];
                selectedSalarie = row.DataBoundItem as Salarie;
                if (selectedSalarie != null)
                {
                    tbNom.Text = selectedSalarie.Nom;
                    tbPrenom.Text = selectedSalarie.Prenom;
                    tbTf.Text = selectedSalarie.TelephoneFixe;
                    tbTp.Text = selectedSalarie.TelephonePortable;
                    tbEmail.Text = selectedSalarie.Email;
                    tbService.Text = selectedSalarie.Service;
                    tbSite.Text = selectedSalarie.Site;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un salarié à modifier.");
            }
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            if (selectedSalarie != null)
            {
                if (string.IsNullOrWhiteSpace(tbNom.Text) ||
                    string.IsNullOrWhiteSpace(tbPrenom.Text) ||
                    string.IsNullOrWhiteSpace(tbTf.Text) ||
                    string.IsNullOrWhiteSpace(tbTp.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbService.Text) ||
                    string.IsNullOrWhiteSpace(tbSite.Text))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                selectedSalarie.Nom = tbNom.Text;
                selectedSalarie.Prenom = tbPrenom.Text;
                selectedSalarie.TelephoneFixe = tbTf.Text;
                selectedSalarie.TelephonePortable = tbTp.Text;
                selectedSalarie.Email = tbEmail.Text;
                selectedSalarie.Service = tbService.Text;
                selectedSalarie.Site = tbSite.Text;

                try
                {
                    await _helper.UpdateSalarie(selectedSalarie); // Envoyer la mise à jour via l'API
                    await LoadSalariesAsync(); // Recharger les données dans le DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour du salarié : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Aucun salarié n'a été sélectionné pour la modification.");
            }
        }

        private async void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifiez qu'une ligne est bien sélectionnée avant de tenter de supprimer un salarié
            if (dataGridViewSalaries.SelectedRows.Count > 0)
            {
                var row = dataGridViewSalaries.SelectedRows[0];
                selectedSalarie = row.DataBoundItem as Salarie;
                if (selectedSalarie != null)
                {
                    // Demandez confirmation avant de supprimer
                    var confirmResult = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer ce salarié : {selectedSalarie.Nom} {selectedSalarie.Prenom} ?",
                                                        "Confirmer la suppression",
                                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            await _helper.DeleteSalarie(selectedSalarie.Id); // Assurez-vous que cette méthode existe dans votre Helper
                            await LoadSalariesAsync(); // Recharger les données dans le DataGridView
                            MessageBox.Show("Le salarié a été supprimé avec succès.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la suppression du salarié : " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un salarié à supprimer.");
            }

        }

        private async void btnRechercher_Click(object sender, EventArgs e)
        {
            string searchTerm = tbRecherche.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var allSalaries = await _helper.GetAllSalaries();
                var filteredSalaries = allSalaries.Where(s =>
                    (s.Nom.ToLower().Contains(searchTerm) ||
                     s.Prenom.ToLower().Contains(searchTerm))
                ).ToList();

                dataGridViewSalaries.DataSource = new BindingList<Salarie>(filteredSalaries);
            }
            else
            {
                await LoadSalariesAsync(); // Si la barre de recherche est vide, rechargez tous les salariés
            }
        }
    }
}
