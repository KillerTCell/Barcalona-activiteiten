﻿namespace Barcelona
{
    partial class VoegBegeleiderToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoegBegeleiderToe));
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGsmNummer = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.lstBegeleiders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(187, 20);
            this.txtVoornaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(195, 22);
            this.txtVoornaam.TabIndex = 1;
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(236, 123);
            this.btnBevestigen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(147, 70);
            this.btnBevestigen.TabIndex = 4;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gsm nummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Achternaam";
            // 
            // txtGsmNummer
            // 
            this.txtGsmNummer.Location = new System.Drawing.Point(187, 84);
            this.txtGsmNummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtGsmNummer.Name = "txtGsmNummer";
            this.txtGsmNummer.Size = new System.Drawing.Size(195, 22);
            this.txtGsmNummer.TabIndex = 3;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(187, 52);
            this.txtAchternaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(195, 22);
            this.txtAchternaam.TabIndex = 2;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(16, 123);
            this.btnAnnuleren.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(147, 70);
            this.btnAnnuleren.TabIndex = 5;
            this.btnAnnuleren.Text = "Terug naar administator";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // lstBegeleiders
            // 
            this.lstBegeleiders.FormattingEnabled = true;
            this.lstBegeleiders.ItemHeight = 16;
            this.lstBegeleiders.Location = new System.Drawing.Point(16, 207);
            this.lstBegeleiders.Margin = new System.Windows.Forms.Padding(4);
            this.lstBegeleiders.Name = "lstBegeleiders";
            this.lstBegeleiders.Size = new System.Drawing.Size(365, 164);
            this.lstBegeleiders.TabIndex = 11;
            this.lstBegeleiders.SelectedIndexChanged += new System.EventHandler(this.lstBegeleiders_SelectedIndexChanged);
            // 
            // VoegBegeleiderToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(399, 386);
            this.Controls.Add(this.lstBegeleiders);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtGsmNummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VoegBegeleiderToe";
            this.Text = "Voeg een begeleider toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VoegBegeleiderToe_FormClosed);
            this.Load += new System.EventHandler(this.VoegLeerkrachtToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGsmNummer;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.ListBox lstBegeleiders;
    }
}