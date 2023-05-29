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

            txtUpdateFirstName.Text = selectedWorker.FirstName;
            txtUpdateLastName.Text = selectedWorker.LastName;
            txtUpdatePhoneNumber.Text = selectedWorker.PhoneNumber;
        }

        private void btnSaveUpdated_Click(object sender, EventArgs e)
        {
            string updatedFirstName = txtUpdateFirstName.Text;
            string updatedLastName = txtUpdateLastName.Text;
            string updatedPhoneNumber = txtUpdatePhoneNumber.Text;

            if (string.IsNullOrWhiteSpace(updatedFirstName) || string.IsNullOrWhiteSpace(updatedLastName) || string.IsNullOrWhiteSpace(updatedPhoneNumber))
            {
                MessageBox.Show("Molimo unesite sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Models.WorkerRepository.UpdateWorker(selectedWorker.Id, updatedFirstName, updatedLastName, updatedPhoneNumber);

            this.Close();
        }
    }
}
