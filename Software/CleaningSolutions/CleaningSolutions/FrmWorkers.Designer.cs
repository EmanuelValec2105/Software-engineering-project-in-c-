
namespace CleaningSolutions
{
    partial class FrmWorkers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.btnNewWorker = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnUpdateWorker = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSeacrh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(10, 73);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowHeadersWidth = 51;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.Size = new System.Drawing.Size(647, 413);
            this.dgvWorkers.TabIndex = 0;
            // 
            // btnNewWorker
            // 
            this.btnNewWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewWorker.Location = new System.Drawing.Point(10, 516);
            this.btnNewWorker.Name = "btnNewWorker";
            this.btnNewWorker.Size = new System.Drawing.Size(183, 47);
            this.btnNewWorker.TabIndex = 1;
            this.btnNewWorker.Text = "Dodaj novog zaposlenika";
            this.btnNewWorker.UseVisualStyleBackColor = true;
            this.btnNewWorker.Click += new System.EventHandler(this.btnNewWorker_Click);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteWorker.Location = new System.Drawing.Point(221, 516);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(183, 47);
            this.btnDeleteWorker.TabIndex = 2;
            this.btnDeleteWorker.Text = "Izbriši zaposlenika";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnUpdateWorker
            // 
            this.btnUpdateWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateWorker.Location = new System.Drawing.Point(429, 516);
            this.btnUpdateWorker.Name = "btnUpdateWorker";
            this.btnUpdateWorker.Size = new System.Drawing.Size(183, 47);
            this.btnUpdateWorker.TabIndex = 3;
            this.btnUpdateWorker.Text = "Ažuriraj zaposlenika";
            this.btnUpdateWorker.UseVisualStyleBackColor = true;
            this.btnUpdateWorker.Click += new System.EventHandler(this.btnUpdateWorker_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSeacrh
            // 
            this.btnSeacrh.Location = new System.Drawing.Point(294, 16);
            this.btnSeacrh.Name = "btnSeacrh";
            this.btnSeacrh.Size = new System.Drawing.Size(123, 35);
            this.btnSeacrh.TabIndex = 5;
            this.btnSeacrh.Text = "Pretraži";
            this.btnSeacrh.UseVisualStyleBackColor = true;
            this.btnSeacrh.Click += new System.EventHandler(this.btnSeacrh_Click);
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 588);
            this.Controls.Add(this.btnSeacrh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdateWorker);
            this.Controls.Add(this.btnDeleteWorker);
            this.Controls.Add(this.btnNewWorker);
            this.Controls.Add(this.dgvWorkers);
            this.Name = "FrmWorkers";
            this.Text = "FrmWorkers";
            this.Load += new System.EventHandler(this.FrmWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewWorker;
        public System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnUpdateWorker;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeacrh;
    }
}