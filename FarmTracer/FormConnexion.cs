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

            string hardcodedUsername = "user"; // Exemple de nom d'utilisateur en dur
            string hardcodedPassword = "resu"; // Exemple de mot de passe en dur

            // V�rifiez d'abord les identifiants en dur
            if (username.Equals(hardcodedUsername, StringComparison.OrdinalIgnoreCase) && enteredPassword == hardcodedPassword)
            {
                MessageBox.Show("Connexion r�ussie avec les identifiants en dur!", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide();
                return; // Pour �viter de poursuivre avec la v�rification de l'API
            }
        }
    }
}
