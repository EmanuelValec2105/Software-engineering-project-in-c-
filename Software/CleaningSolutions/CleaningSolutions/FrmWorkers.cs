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
    public partial class FrmWorkers : Form
    {
        public FrmWorkers()
        {
            InitializeComponent();
        }

        private void FrmWorkers_Load(object sender, EventArgs e)
        {
            ShowWorkers();
        }

        public void ShowWorkers()
        {
            List<Models.Worker> workers = Models.WorkerRepository.GetWorkers();
            dgvWorkers.DataSource = workers;
            dgvWorkers.Columns["Id"].Visible = false;
            dgvWorkers.Columns["FirstName"].DisplayIndex = 0;
            dgvWorkers.Columns["LastName"].DisplayIndex = 1;
            dgvWorkers.Columns["PhoneNumber"].DisplayIndex = 2;

        }

        private void btnNewWorker_Click(object sender, EventArgs e)
        {
            FrmNewWorker frmNewWorker = new FrmNewWorker();
            frmNewWorker.Show();
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (dgvWorkers.SelectedRows.Count > 0)
            {
                // Dohvati ID odabranog radnika
                int selectedWorkerId = (int)dgvWorkers.SelectedRows[0].Cells["Id"].Value;

                // Izvrši SQL naredbu za brisanje radnika iz baze podataka
                Models.WorkerRepository.DeleteWorker(selectedWorkerId);

                // Osvježi prikaz DataGridView-a
                ShowWorkers();
            }
        }

        private void btnUpdateWorker_Click(object sender, EventArgs e)
        {
            if (dgvWorkers.SelectedRows.Count > 0)
            {
                // Dohvati odabrani radnik
                Models.Worker selectedWorker = (Models.Worker)dgvWorkers.SelectedRows[0].DataBoundItem;

                // Otvaranje forme za ažuriranje radnika
                FrmUpdateWorker frmUpdateWorker = new FrmUpdateWorker(selectedWorker);
                frmUpdateWorker.ShowDialog();

                // Osvježi prikaz DataGridView-a
                ShowWorkers();
            }
        }

        private void btnSeacrh_Click(object sender, EventArgs e)
        {
            string searchCriteria = txtSearch.Text;

            // Pozovite metodu za prikaz radnika s primijenjenim pretraživanjem
            ShowWorkers(searchCriteria);
        }
        private void ShowWorkers(string searchCriteria = null)
        {
            List<Models.Worker> workers = Models.WorkerRepository.GetWorkers();

            // Primijeni filtriranje na temelju kriterija pretraživanja, ako je dostupan
            if (!string.IsNullOrEmpty(searchCriteria))
            {
                workers = workers.Where(w => w.FirstName.Contains(searchCriteria) || w.LastName.Contains(searchCriteria)).ToList();
            }

            dgvWorkers.DataSource = workers;
            dgvWorkers.Columns["Id"].Visible = false;
            dgvWorkers.Columns["FirstName"].DisplayIndex = 0;
            dgvWorkers.Columns["LastName"].DisplayIndex = 1;
            dgvWorkers.Columns["PhoneNumber"].DisplayIndex = 2;
        }
    }
}
