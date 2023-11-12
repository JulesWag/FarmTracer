using FarmTracer.API;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FarmTracer
{
    public partial class FormSite : Form
    {
        private HelperSite _helperSite = new HelperSite();
        private HelperSite.Site selectedSite;

        public FormSite()
        {
            InitializeComponent();
            this.Load += async (sender, e) => await LoadSitesAsync();
        }

        private async Task LoadSitesAsync()
        {
            var sites = await _helperSite.GetAllSites();
            dataGridViewSite.DataSource = new BindingList<HelperSite.Site>(sites);
        }

        private async void btnAjouter_Click(object sender, EventArgs e)
        {
            string nomSite = tbNomSite.Text;
            if (!string.IsNullOrWhiteSpace(nomSite))
            {
                var site = new HelperSite.Site { Nom = nomSite };
                await _helperSite.AddSite(site);
                await LoadSitesAsync();
                tbNomSite.Clear(); // Vide la TextBox après l'ajout
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom pour le site.");
            }
        }

        private async void btnModifier_Click(object sender, EventArgs e)
        {



            if (dataGridViewSite.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSite.SelectedRows[0];
                selectedSite = selectedRow.DataBoundItem as HelperSite.Site;
                if (selectedSite != null)
                {
                    tbModif.Text = selectedSite.Nom;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un site à modifier.");
            }

        }

        private void tbModif_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnValider_Click(object sender, EventArgs e)
        {


            string nouveauNom = tbModif.Text.Trim();
            if (string.IsNullOrWhiteSpace(nouveauNom))
            {
                MessageBox.Show("Le nom du site ne peut pas être vide.");
                return;
            }

            // Vérifiez si le nouveau nom existe déjà
            var sites = await _helperSite.GetAllSites();
            if (sites.Any(site => site.Nom.Equals(nouveauNom, StringComparison.OrdinalIgnoreCase) && site.Id != selectedSite.Id))
            {
                MessageBox.Show("Un site avec ce nom existe déjà.");
                return;
            }

            // Mettez à jour le nom du site avec la nouvelle valeur de la TextBox
            selectedSite.Nom = nouveauNom;

            try
            {

                await _helperSite.UpdateSite(selectedSite);
                MessageBox.Show("Site mis à jour avec succès.");

                // Recharger la liste des sites pour afficher les changements
                await LoadSitesAsync();


                tbModif.Clear();

                // Réinitialiser l'objet selectedSite
                selectedSite = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour du site : {ex.Message}");
            }
            selectedSite = null;
        }

        private async void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifiez si un site est sélectionné dans le DataGridView
            if (dataGridViewSite.SelectedRows.Count > 0)
            {

                var selectedRow = dataGridViewSite.SelectedRows[0];
                selectedSite = selectedRow.DataBoundItem as HelperSite.Site;

                if (selectedSite != null)
                {
                    // Demandez confirmation avant de supprimer le site
                    var confirmResult = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le site : {selectedSite.Nom} ?",
                                                        "Confirmer la suppression", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {

                            await _helperSite.DeleteSite(selectedSite.Id);
                            MessageBox.Show("Le site a été supprimé avec succès.");

                            // Recharger la liste des sites pour afficher les changements
                            await LoadSitesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erreur lors de la suppression du site : {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un site à supprimer.");
            }
        }

        private void dataGridViewSite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            var FormAdmin = new FormAdmin();
            FormAdmin.Show();
            this.Hide();


        }
    }
}
