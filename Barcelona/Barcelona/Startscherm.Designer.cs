﻿namespace Barcelona
{
    partial class frmStartscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartscherm));
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnGebruiker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrator.Location = new System.Drawing.Point(409, 309);
            this.btnAdministrator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(201, 79);
            this.btnAdministrator.TabIndex = 0;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnGebruiker
            // 
            this.btnGebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGebruiker.Location = new System.Drawing.Point(139, 309);
            this.btnGebruiker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGebruiker.Name = "btnGebruiker";
            this.btnGebruiker.Size = new System.Drawing.Size(201, 79);
            this.btnGebruiker.TabIndex = 1;
            this.btnGebruiker.Text = "Gebruiker";
            this.btnGebruiker.UseVisualStyleBackColor = true;
            this.btnGebruiker.Click += new System.EventHandler(this.btnGebruiker_Click);
            // 
            // frmStartscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::Barcelona.Properties.Resources.Barcelona;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(735, 405);
            this.Controls.Add(this.btnGebruiker);
            this.Controls.Add(this.btnAdministrator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(753, 452);
            this.MinimumSize = new System.Drawing.Size(753, 452);
            this.Name = "frmStartscherm";
            this.Text = "Activiteiten Barcelona";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStartscherm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStartscherm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnGebruiker;
    }
}