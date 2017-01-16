namespace Werkzeugverleih
{
    partial class Form1
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
            this.lstbWerkzeuge = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBezeichnung = new System.Windows.Forms.TextBox();
            this.txtTageKurzausleihe = new System.Windows.Forms.TextBox();
            this.txtPreisKurzausleihe = new System.Windows.Forms.TextBox();
            this.txtTageLangausleihe = new System.Windows.Forms.TextBox();
            this.txtPreisLangausleihe = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAusleihen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTageAusgeliehen = new System.Windows.Forms.TextBox();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbWerkzeuge
            // 
            this.lstbWerkzeuge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbWerkzeuge.FormattingEnabled = true;
            this.lstbWerkzeuge.ItemHeight = 16;
            this.lstbWerkzeuge.Location = new System.Drawing.Point(12, 12);
            this.lstbWerkzeuge.Name = "lstbWerkzeuge";
            this.lstbWerkzeuge.Size = new System.Drawing.Size(257, 308);
            this.lstbWerkzeuge.TabIndex = 0;
            this.lstbWerkzeuge.SelectedIndexChanged += new System.EventHandler(this.lstbWerkzeuge_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bezeichnung:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl Tage Kurzausleihe:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preis Kurzausleihe:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Anzahl Tage Langausleihe:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Preis Langausleihe:";
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBezeichnung.Location = new System.Drawing.Point(278, 32);
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(163, 22);
            this.txtBezeichnung.TabIndex = 6;
            // 
            // txtTageKurzausleihe
            // 
            this.txtTageKurzausleihe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTageKurzausleihe.Location = new System.Drawing.Point(279, 77);
            this.txtTageKurzausleihe.Name = "txtTageKurzausleihe";
            this.txtTageKurzausleihe.Size = new System.Drawing.Size(162, 22);
            this.txtTageKurzausleihe.TabIndex = 7;
            this.txtTageKurzausleihe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showOnlyNumbers);
            // 
            // txtPreisKurzausleihe
            // 
            this.txtPreisKurzausleihe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreisKurzausleihe.Location = new System.Drawing.Point(279, 122);
            this.txtPreisKurzausleihe.Name = "txtPreisKurzausleihe";
            this.txtPreisKurzausleihe.Size = new System.Drawing.Size(162, 22);
            this.txtPreisKurzausleihe.TabIndex = 8;
            this.txtPreisKurzausleihe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showOnlyNumbers);
            // 
            // txtTageLangausleihe
            // 
            this.txtTageLangausleihe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTageLangausleihe.Location = new System.Drawing.Point(279, 167);
            this.txtTageLangausleihe.Name = "txtTageLangausleihe";
            this.txtTageLangausleihe.Size = new System.Drawing.Size(162, 22);
            this.txtTageLangausleihe.TabIndex = 9;
            this.txtTageLangausleihe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showOnlyNumbers);
            // 
            // txtPreisLangausleihe
            // 
            this.txtPreisLangausleihe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreisLangausleihe.Location = new System.Drawing.Point(279, 212);
            this.txtPreisLangausleihe.Name = "txtPreisLangausleihe";
            this.txtPreisLangausleihe.Size = new System.Drawing.Size(162, 22);
            this.txtPreisLangausleihe.TabIndex = 10;
            this.txtPreisLangausleihe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showOnlyNumbers);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpeichern.Location = new System.Drawing.Point(279, 289);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(178, 31);
            this.btnSpeichern.TabIndex = 11;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAusleihen
            // 
            this.btnAusleihen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAusleihen.Location = new System.Drawing.Point(12, 371);
            this.btnAusleihen.Name = "btnAusleihen";
            this.btnAusleihen.Size = new System.Drawing.Size(224, 31);
            this.btnAusleihen.TabIndex = 15;
            this.btnAusleihen.Text = "Ausleihen";
            this.btnAusleihen.UseVisualStyleBackColor = true;
            this.btnAusleihen.Click += new System.EventHandler(this.btnAusleihen_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anzahl Tage der Ausleihe:";
            // 
            // txtTageAusgeliehen
            // 
            this.txtTageAusgeliehen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTageAusgeliehen.Location = new System.Drawing.Point(15, 343);
            this.txtTageAusgeliehen.Name = "txtTageAusgeliehen";
            this.txtTageAusgeliehen.Size = new System.Drawing.Size(221, 22);
            this.txtTageAusgeliehen.TabIndex = 14;
            this.txtTageAusgeliehen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showOnlyNumbers);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(9, 22);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(91, 17);
            this.lblAusgabe.TabIndex = 15;
            this.lblAusgabe.Text = "LeihAusgabe";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblAusgabe);
            this.groupBox1.Location = new System.Drawing.Point(246, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geliehen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 409);
            this.Controls.Add(this.txtTageAusgeliehen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAusleihen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtPreisLangausleihe);
            this.Controls.Add(this.txtTageLangausleihe);
            this.Controls.Add(this.txtPreisKurzausleihe);
            this.Controls.Add(this.txtTageKurzausleihe);
            this.Controls.Add(this.txtBezeichnung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbWerkzeuge);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(449, 456);
            this.Name = "Form1";
            this.Text = "Werkzeugverleih Pascal Hobza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbWerkzeuge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBezeichnung;
        private System.Windows.Forms.TextBox txtTageKurzausleihe;
        private System.Windows.Forms.TextBox txtPreisKurzausleihe;
        private System.Windows.Forms.TextBox txtTageLangausleihe;
        private System.Windows.Forms.TextBox txtPreisLangausleihe;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAusleihen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTageAusgeliehen;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

