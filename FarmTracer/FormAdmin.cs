using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmTracer
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnSalarie_Click(object sender, EventArgs e)
        {
            FormSalarie formSalarie = new FormSalarie();
            formSalarie.Show();
            this.Hide();
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            FormSite formSite = new FormSite();
            formSite.Show();
            this.Hide();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            FormService formService = new FormService();
            formService.Show();
            this.Hide();
        }
    }
}
