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

        private void ShowWorkers()
        {
            List<Models.Worker> workers = Models.WorkerRepository.GetWorkers();
            dgvWorkers.DataSource = workers;
            dgvWorkers.Columns["Id"].DisplayIndex = 0; 
            dgvWorkers.Columns["FirstName"].DisplayIndex = 1;
            dgvWorkers.Columns["LastName"].DisplayIndex = 2;
            dgvWorkers.Columns["PhoneNumber"].DisplayIndex = 3;

        }
    }
}
