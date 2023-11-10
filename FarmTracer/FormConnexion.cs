using FarmTracer.API;
using System;
using System.Windows.Forms;
using static FarmTracer.API.Helper;


namespace FarmTracer
{
    public partial class FormConnexion : Form
    {
        private readonly Helper _apiHelper = new Helper();

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVisiteur_Click_1(object sender, EventArgs e)
        {
            FormAccueilVisiteur formVisiteur = new FormAccueilVisiteur();
            formVisiteur.Show();
            this.Hide();
        }

        private async void btnConnexion_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string enteredPassword = tbPassword.Text;

            Helper apiHelper = new Helper();
            Admin admin = await apiHelper.GetAdminByUsername(username);

            if (admin != null)
            {
                if (apiHelper.IsPasswordValid(enteredPassword, admin.PasswordHash, admin.Salt))
                {
                    MessageBox.Show("Connexion réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
