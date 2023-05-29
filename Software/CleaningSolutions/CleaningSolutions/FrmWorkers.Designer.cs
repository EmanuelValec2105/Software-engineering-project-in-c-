
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(10, 226);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowHeadersWidth = 51;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.Size = new System.Drawing.Size(977, 482);
            this.dgvWorkers.TabIndex = 0;
            // 
            // btnNewWorker
            // 
            this.btnNewWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewWorker.Location = new System.Drawing.Point(10, 732);
            this.btnNewWorker.Name = "btnNewWorker";
            this.btnNewWorker.Size = new System.Drawing.Size(230, 60);
            this.btnNewWorker.TabIndex = 1;
            this.btnNewWorker.Text = "Dodaj zaposlenika";
            this.btnNewWorker.UseVisualStyleBackColor = true;
            this.btnNewWorker.Click += new System.EventHandler(this.btnNewWorker_Click);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteWorker.Location = new System.Drawing.Point(401, 732);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(231, 60);
            this.btnDeleteWorker.TabIndex = 2;
            this.btnDeleteWorker.Text = "Izbriši zaposlenika";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnUpdateWorker
            // 
            this.btnUpdateWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateWorker.Location = new System.Drawing.Point(759, 732);
            this.btnUpdateWorker.Name = "btnUpdateWorker";
            this.btnUpdateWorker.Size = new System.Drawing.Size(228, 60);
            this.btnUpdateWorker.TabIndex = 3;
            this.btnUpdateWorker.Text = "Ažuriraj zaposlenika";
            this.btnUpdateWorker.UseVisualStyleBackColor = true;
            this.btnUpdateWorker.Click += new System.EventHandler(this.btnUpdateWorker_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(10, 165);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(817, 30);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSeacrh
            // 
            this.btnSeacrh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeacrh.Location = new System.Drawing.Point(833, 157);
            this.btnSeacrh.Name = "btnSeacrh";
            this.btnSeacrh.Size = new System.Drawing.Size(144, 47);
            this.btnSeacrh.TabIndex = 5;
            this.btnSeacrh.Text = "Pretraži";
            this.btnSeacrh.UseVisualStyleBackColor = true;
            this.btnSeacrh.Click += new System.EventHandler(this.btnSeacrh_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(382, 28);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(509, 78);
            this.lblNaslov.TabIndex = 6;
            this.lblNaslov.Text = "Zaposlenici";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(10, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 10);
            this.panel1.TabIndex = 7;
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 815);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnSeacrh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdateWorker);
            this.Controls.Add(this.btnDeleteWorker);
            this.Controls.Add(this.btnNewWorker);
            this.Controls.Add(this.dgvWorkers);
            this.Name = "FrmWorkers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleaning Solutions";
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
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panel1;
    }
}