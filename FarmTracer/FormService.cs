using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FarmTracer.API;

namespace FarmTracer
{
    public partial class FormService : Form
    {
        private readonly HelperService _helperService = new HelperService();
        private HelperService.Service selectedService;

        public FormService()
        {
            InitializeComponent();
            this.Load += async (sender, e) => await LoadServicesAsync();
        }

        private async Task LoadServicesAsync()
        {
            try
            {
                var services = await _helperService.GetAllServices();
                if (services.Count > 0)
                {
                    gridService.DataSource = new BindingList<HelperService.Service>(services);
                }
                else
                {
                    MessageBox.Show("Aucun service trouvé.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des services : {ex.Message}");
            }
        }

        private async void btnAjout_Click(object sender, EventArgs e)
        {
            string nomService = tbAjout.Text.Trim();
            if (string.IsNullOrEmpty(nomService))
            {
                MessageBox.Show("Veuillez entrer le nom du service.");
                return;
            }

            var service = new HelperService.Service { Nom = nomService };
            try
            {
                await _helperService.AddService(service);
                MessageBox.Show("Service ajouté avec succès.");
                tbAjout.Clear();
                await LoadServicesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du service : {ex.Message}");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (gridService.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un service à modifier.");
                return;
            }

            selectedService = gridService.SelectedRows[0].DataBoundItem as HelperService.Service;
            tbModifier.Text = selectedService?.Nom;
        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            if (selectedService == null)
            {
                MessageBox.Show("Veuillez sélectionner un service à modifier.");
                return;
            }

            string nomService = tbModifier.Text.Trim();
            if (string.IsNullOrEmpty(nomService))
            {
                MessageBox.Show("Le nom du service ne peut pas être vide.");
                return;
            }

            selectedService.Nom = nomService;
            try
            {
                await _helperService.UpdateService(selectedService);
                MessageBox.Show("Service mis à jour avec succès.");
                tbModifier.Clear();
                await LoadServicesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour du service : {ex.Message}");
            }
        }



        private async void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (gridService.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un service à supprimer.");
                return;
            }

            selectedService = gridService.SelectedRows[0].DataBoundItem as HelperService.Service;
            var confirmResult = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le service : {selectedService.Nom} ?", "Confirmer la suppression", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            try
            {
                await _helperService.DeleteService(selectedService.Id);
                MessageBox.Show("Service supprimé avec succès.");
                await LoadServicesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du service : {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            var FormAdmin = new FormAdmin();
            FormAdmin.Show();
            this.Hide();
        }
    }
}
