namespace Autoverleih
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbVerleihautoListe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBezeichnung = new System.Windows.Forms.TextBox();
            this.Bezeichnung = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreisKilometer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreisTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.txtGefahreneKilometer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBezahlen = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.txtKilometerstand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAendern = new System.Windows.Forms.Button();
            this.txtGemieteteTage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPreis = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbVerleihautoListe
            // 
            this.lstbVerleihautoListe.FormattingEnabled = true;
            this.lstbVerleihautoListe.ItemHeight = 16;
            this.lstbVerleihautoListe.Location = new System.Drawing.Point(31, 80);
            this.lstbVerleihautoListe.Margin = new System.Windows.Forms.Padding(4);
            this.lstbVerleihautoListe.Name = "lstbVerleihautoListe";
            this.lstbVerleihautoListe.Size = new System.Drawing.Size(188, 228);
            this.lstbVerleihautoListe.TabIndex = 0;
            this.lstbVerleihautoListe.SelectedIndexChanged += new System.EventHandler(this.lstbVerleihautoListe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leihautos:";
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Location = new System.Drawing.Point(377, 84);
            this.txtBezeichnung.Margin = new System.Windows.Forms.Padding(4);
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(160, 22);
            this.txtBezeichnung.TabIndex = 2;
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.AutoSize = true;
            this.Bezeichnung.Location = new System.Drawing.Point(377, 62);
            this.Bezeichnung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bezeichnung.Name = "Bezeichnung";
            this.Bezeichnung.Size = new System.Drawing.Size(94, 17);
            this.Bezeichnung.TabIndex = 3;
            this.Bezeichnung.Text = "Bezeichnung:";
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(377, 135);
            this.txtTyp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(159, 22);
            this.txtTyp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Typ:";
            // 
            // txtPreisKilometer
            // 
            this.txtPreisKilometer.Location = new System.Drawing.Point(377, 188);
            this.txtPreisKilometer.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreisKilometer.Name = "txtPreisKilometer";
            this.txtPreisKilometer.Size = new System.Drawing.Size(157, 22);
            this.txtPreisKilometer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preis pro Kilometer:";
            // 
            // txtPreisTag
            // 
            this.txtPreisTag.Location = new System.Drawing.Point(377, 242);
            this.txtPreisTag.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreisTag.Name = "txtPreisTag";
            this.txtPreisTag.Size = new System.Drawing.Size(156, 22);
            this.txtPreisTag.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preis pro Tag:";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(379, 335);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(155, 28);
            this.btnSpeichern.TabIndex = 10;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // txtGefahreneKilometer
            // 
            this.txtGefahreneKilometer.Location = new System.Drawing.Point(31, 378);
            this.txtGefahreneKilometer.Margin = new System.Windows.Forms.Padding(4);
            this.txtGefahreneKilometer.Name = "txtGefahreneKilometer";
            this.txtGefahreneKilometer.Size = new System.Drawing.Size(187, 22);
            this.txtGefahreneKilometer.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "gefahrene Kilometer:";
            // 
            // btnBezahlen
            // 
            this.btnBezahlen.Location = new System.Drawing.Point(380, 475);
            this.btnBezahlen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBezahlen.Name = "btnBezahlen";
            this.btnBezahlen.Size = new System.Drawing.Size(152, 31);
            this.btnBezahlen.TabIndex = 13;
            this.btnBezahlen.Text = "Bezahlen";
            this.btnBezahlen.UseVisualStyleBackColor = true;
            this.btnBezahlen.Click += new System.EventHandler(this.btnBezahlen_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(379, 370);
            this.btnLoeschen.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(157, 32);
            this.btnLoeschen.TabIndex = 14;
            this.btnLoeschen.Text = "Auto Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // txtKilometerstand
            // 
            this.txtKilometerstand.Location = new System.Drawing.Point(381, 293);
            this.txtKilometerstand.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilometerstand.Name = "txtKilometerstand";
            this.txtKilometerstand.Size = new System.Drawing.Size(153, 22);
            this.txtKilometerstand.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kilometerstand";
            // 
            // btnAendern
            // 
            this.btnAendern.Location = new System.Drawing.Point(381, 414);
            this.btnAendern.Margin = new System.Windows.Forms.Padding(4);
            this.btnAendern.Name = "btnAendern";
            this.btnAendern.Size = new System.Drawing.Size(149, 30);
            this.btnAendern.TabIndex = 17;
            this.btnAendern.Text = "Ändern";
            this.btnAendern.UseVisualStyleBackColor = true;
            this.btnAendern.Click += new System.EventHandler(this.btnAendern_Click);
            // 
            // txtGemieteteTage
            // 
            this.txtGemieteteTage.Location = new System.Drawing.Point(31, 436);
            this.txtGemieteteTage.Margin = new System.Windows.Forms.Padding(4);
            this.txtGemieteteTage.Name = "txtGemieteteTage";
            this.txtGemieteteTage.Size = new System.Drawing.Size(188, 22);
            this.txtGemieteteTage.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 412);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Gemietete Tage";
            // 
            // lblPreis
            // 
            this.lblPreis.AutoSize = true;
            this.lblPreis.Location = new System.Drawing.Point(31, 469);
            this.lblPreis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(152, 17);
            this.lblPreis.TabIndex = 20;
            this.lblPreis.Text = "Gesamtsumme: 0 Euro";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(31, 316);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(175, 17);
            this.lblAverage.TabIndex = 21;
            this.lblAverage.Text = "Durchschnittspreis: 0 Euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 508);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblPreis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGemieteteTage);
            this.Controls.Add(this.btnAendern);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKilometerstand);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnBezahlen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGefahreneKilometer);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreisTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreisKilometer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.Bezeichnung);
            this.Controls.Add(this.txtBezeichnung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbVerleihautoListe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbVerleihautoListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBezeichnung;
        private System.Windows.Forms.Label Bezeichnung;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreisKilometer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreisTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TextBox txtGefahreneKilometer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBezahlen;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.TextBox txtKilometerstand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAendern;
        private System.Windows.Forms.TextBox txtGemieteteTage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label lblAverage;
    }
}

