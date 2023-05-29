
namespace CleaningSolutions
{
    partial class FrmUpdateWorker
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
            this.components = new System.ComponentModel.Container();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.txtUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.lblUpdatePhone = new System.Windows.Forms.Label();
            this.btnSaveUpdated = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(49, 65);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(174, 22);
            this.txtUpdateFirstName.TabIndex = 0;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(49, 150);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(174, 22);
            this.txtUpdateLastName.TabIndex = 1;
            // 
            // txtUpdatePhoneNumber
            // 
            this.txtUpdatePhoneNumber.Location = new System.Drawing.Point(49, 232);
            this.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            this.txtUpdatePhoneNumber.Size = new System.Drawing.Size(174, 22);
            this.txtUpdatePhoneNumber.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpdateFirstName.Location = new System.Drawing.Point(44, 37);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(44, 25);
            this.lblUpdateFirstName.TabIndex = 4;
            this.lblUpdateFirstName.Text = "Ime";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpdateLastName.Location = new System.Drawing.Point(44, 122);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(83, 25);
            this.lblUpdateLastName.TabIndex = 5;
            this.lblUpdateLastName.Text = "Prezime";
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.AutoSize = true;
            this.lblUpdatePhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpdatePhone.Location = new System.Drawing.Point(44, 204);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(124, 25);
            this.lblUpdatePhone.TabIndex = 6;
            this.lblUpdatePhone.Text = "Broj mobitela";
            // 
            // btnSaveUpdated
            // 
            this.btnSaveUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveUpdated.Location = new System.Drawing.Point(49, 320);
            this.btnSaveUpdated.Name = "btnSaveUpdated";
            this.btnSaveUpdated.Size = new System.Drawing.Size(174, 41);
            this.btnSaveUpdated.TabIndex = 7;
            this.btnSaveUpdated.Text = "Spremi";
            this.btnSaveUpdated.UseVisualStyleBackColor = true;
            this.btnSaveUpdated.Click += new System.EventHandler(this.btnSaveUpdated_Click);
            // 
            // FrmUpdateWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 402);
            this.Controls.Add(this.btnSaveUpdated);
            this.Controls.Add(this.lblUpdatePhone);
            this.Controls.Add(this.lblUpdateLastName);
            this.Controls.Add(this.lblUpdateFirstName);
            this.Controls.Add(this.txtUpdatePhoneNumber);
            this.Controls.Add(this.txtUpdateLastName);
            this.Controls.Add(this.txtUpdateFirstName);
            this.Name = "FrmUpdateWorker";
            this.Text = "FrmUpdateWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.TextBox txtUpdatePhoneNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.Label lblUpdatePhone;
        private System.Windows.Forms.Button btnSaveUpdated;
    }
}