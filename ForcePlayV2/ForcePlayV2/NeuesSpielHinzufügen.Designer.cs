﻿namespace ForcePlayV2
{
    partial class NeuesSpielHinzufügen
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
            this.SpielHinzufügenButton = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.TextBox();
            this.Installationsdatum = new System.Windows.Forms.TextBox();
            this.zuletztGespielt = new System.Windows.Forms.TextBox();
            this.installationspfad = new System.Windows.Forms.TextBox();
            this.kategorie = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.usk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SpielHinzufügenButton
            // 
            this.SpielHinzufügenButton.Location = new System.Drawing.Point(12, 307);
            this.SpielHinzufügenButton.Name = "SpielHinzufügenButton";
            this.SpielHinzufügenButton.Size = new System.Drawing.Size(210, 97);
            this.SpielHinzufügenButton.TabIndex = 0;
            this.SpielHinzufügenButton.Text = "Submit";
            this.SpielHinzufügenButton.UseVisualStyleBackColor = true;
            this.SpielHinzufügenButton.UseWaitCursor = true;
            // 
            // titel
            // 
            this.titel.Location = new System.Drawing.Point(12, 12);
            this.titel.Name = "titel";
            this.titel.PlaceholderText = "Titel";
            this.titel.Size = new System.Drawing.Size(210, 23);
            this.titel.TabIndex = 1;
            this.titel.UseWaitCursor = true;
            this.titel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Installationsdatum
            // 
            this.Installationsdatum.Location = new System.Drawing.Point(12, 52);
            this.Installationsdatum.Name = "Installationsdatum";
            this.Installationsdatum.PlaceholderText = "Installationsdatum";
            this.Installationsdatum.Size = new System.Drawing.Size(210, 23);
            this.Installationsdatum.TabIndex = 2;
            this.Installationsdatum.UseWaitCursor = true;
            // 
            // zuletztGespielt
            // 
            this.zuletztGespielt.Location = new System.Drawing.Point(12, 94);
            this.zuletztGespielt.Name = "zuletztGespielt";
            this.zuletztGespielt.PlaceholderText = "Zuletzt gespielt";
            this.zuletztGespielt.Size = new System.Drawing.Size(210, 23);
            this.zuletztGespielt.TabIndex = 3;
            this.zuletztGespielt.UseWaitCursor = true;
            // 
            // installationspfad
            // 
            this.installationspfad.Location = new System.Drawing.Point(12, 137);
            this.installationspfad.Name = "installationspfad";
            this.installationspfad.PlaceholderText = "Installationspfad";
            this.installationspfad.Size = new System.Drawing.Size(210, 23);
            this.installationspfad.TabIndex = 4;
            this.installationspfad.UseWaitCursor = true;
            // 
            // kategorie
            // 
            this.kategorie.Location = new System.Drawing.Point(12, 175);
            this.kategorie.Name = "kategorie";
            this.kategorie.PlaceholderText = "Kategorie";
            this.kategorie.Size = new System.Drawing.Size(210, 23);
            this.kategorie.TabIndex = 5;
            this.kategorie.UseWaitCursor = true;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(12, 213);
            this.publisher.Name = "publisher";
            this.publisher.PlaceholderText = "Publisher";
            this.publisher.Size = new System.Drawing.Size(210, 23);
            this.publisher.TabIndex = 6;
            this.publisher.UseWaitCursor = true;
            // 
            // usk
            // 
            this.usk.FormattingEnabled = true;
            this.usk.Location = new System.Drawing.Point(12, 254);
            this.usk.Name = "usk";
            this.usk.Size = new System.Drawing.Size(210, 23);
            this.usk.TabIndex = 7;
            // 
            // NeuesSpielHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(245, 416);
            this.ControlBox = false;
            this.Controls.Add(this.usk);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.kategorie);
            this.Controls.Add(this.installationspfad);
            this.Controls.Add(this.zuletztGespielt);
            this.Controls.Add(this.Installationsdatum);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.SpielHinzufügenButton);
            this.Name = "NeuesSpielHinzufügen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.NeuesSpielHinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SpielHinzufügenButton;
        private TextBox titel;
        private TextBox Installationsdatum;
        private TextBox zuletztGespielt;
        private TextBox installationspfad;
        private TextBox kategorie;
        private TextBox publisher;
        private ComboBox usk;
    }
}