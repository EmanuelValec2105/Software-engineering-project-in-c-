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
    public partial class FrmUpdateWorker : Form
    {
        private Models.Worker selectedWorker;

        public FrmUpdateWorker(Models.Worker worker)
        {
            InitializeComponent();
            selectedWorker = worker;

            // Postavi vrijednosti text box-ova na temelju podataka odabranog radnika
            txtUpdateFirstName.Text = selectedWorker.FirstName;
            txtUpdateLastName.Text = selectedWorker.LastName;
            txtUpdatePhoneNumber.Text = selectedWorker.PhoneNumber;
        }

        private void btnSaveUpdated_Click(object sender, EventArgs e)
        {
            string updatedFirstName = txtUpdateFirstName.Text;
            string updatedLastName = txtUpdateLastName.Text;
            string updatedPhoneNumber = txtUpdatePhoneNumber.Text;

            // Provjeri jesu li uneseni podaci valjani
            if (string.IsNullOrWhiteSpace(updatedFirstName) || string.IsNullOrWhiteSpace(updatedLastName) || string.IsNullOrWhiteSpace(updatedPhoneNumber))
            {
                MessageBox.Show("Molimo unesite sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ažuriraj podatke radnika u bazi podataka
            Models.WorkerRepository.UpdateWorker(selectedWorker.Id, updatedFirstName, updatedLastName, updatedPhoneNumber);

            // Zatvori formu
            this.Close();
        }
    }
}
