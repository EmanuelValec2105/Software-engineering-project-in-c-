﻿
namespace CleaningSolutions
{
    partial class FrmNewWorker
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
            this.lblNewFirstName = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.lblNewPhone = new System.Windows.Forms.Label();
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewFirstName
            // 
            this.lblNewFirstName.AutoSize = true;
            this.lblNewFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewFirstName.Location = new System.Drawing.Point(53, 43);
            this.lblNewFirstName.Name = "lblNewFirstName";
            this.lblNewFirstName.Size = new System.Drawing.Size(44, 25);
            this.lblNewFirstName.TabIndex = 0;
            this.lblNewFirstName.Text = "Ime";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewLastName.Location = new System.Drawing.Point(53, 129);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(83, 25);
            this.lblNewLastName.TabIndex = 1;
            this.lblNewLastName.Text = "Prezime";
            // 
            // lblNewPhone
            // 
            this.lblNewPhone.AutoSize = true;
            this.lblNewPhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNewPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPhone.Location = new System.Drawing.Point(53, 215);
            this.lblNewPhone.Name = "lblNewPhone";
            this.lblNewPhone.Size = new System.Drawing.Size(124, 25);
            this.lblNewPhone.TabIndex = 2;
            this.lblNewPhone.Text = "Broj mobitela";
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.Location = new System.Drawing.Point(58, 71);
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(160, 22);
            this.txtNewFirstName.TabIndex = 3;
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(58, 157);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(160, 22);
            this.txtNewLastName.TabIndex = 4;
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(58, 243);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(160, 22);
            this.txtNewPhone.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(58, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSaveChanges);
            // 
            // FrmNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNewPhone);
            this.Controls.Add(this.txtNewLastName);
            this.Controls.Add(this.txtNewFirstName);
            this.Controls.Add(this.lblNewPhone);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblNewFirstName);
            this.Name = "FrmNewWorker";
            this.Text = "Novi zaposlenik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewFirstName;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.Label lblNewPhone;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtNewFirstName;
        public System.Windows.Forms.TextBox txtNewLastName;
        public System.Windows.Forms.TextBox txtNewPhone;
    }
}