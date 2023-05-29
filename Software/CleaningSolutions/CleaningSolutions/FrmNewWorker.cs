using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleaningSolutions
{
    public partial class FrmNewWorker : Form
    {
        public FrmNewWorker()
        {
            InitializeComponent();
        }
        
        private void btnSaveChanges(object sender, EventArgs e)
        {
            string ime = txtNewFirstName.Text;
            string prezime = txtNewLastName.Text;
            string kontakt = txtNewPhone.Text;

            // Provjera unesenih podataka
            if (string.IsNullOrWhiteSpace(ime) || string.IsNullOrWhiteSpace(prezime) || string.IsNullOrWhiteSpace(kontakt))
            {
                MessageBox.Show("Molimo unesite sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dodavanje radnika u bazu podataka
            Models.WorkerRepository.AddWorker(ime, prezime, kontakt);

            // Osvježavanje prikaza DataGridView-a u formi "FrmWorkers"
            FrmWorkers frmWorkers = (FrmWorkers)Application.OpenForms["FrmWorkers"];
            frmWorkers.ShowWorkers();

            // Zatvaranje forme
            this.Close();
        }
    }
}
