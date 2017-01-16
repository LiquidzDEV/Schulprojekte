/*
 * Created by SharpDevelop.
 * User: JannickGrisard
 * Date: 11.11.2016
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Arrayverweise
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox lstbRechnungen;
		private System.Windows.Forms.ListBox lstbPositionen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBezeichnung;
		private System.Windows.Forms.TextBox txtDatum;
		private System.Windows.Forms.TextBox txtPosBezeichnung;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMenge;
		private System.Windows.Forms.TextBox txtEinzelpreis;
		private System.Windows.Forms.TextBox txtAufRechnung;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAddPosition;
		private System.Windows.Forms.Button btnAddRechnung;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstbRechnungen = new System.Windows.Forms.ListBox();
			this.lstbPositionen = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBezeichnung = new System.Windows.Forms.TextBox();
			this.txtDatum = new System.Windows.Forms.TextBox();
			this.txtPosBezeichnung = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMenge = new System.Windows.Forms.TextBox();
			this.txtEinzelpreis = new System.Windows.Forms.TextBox();
			this.txtAufRechnung = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAddPosition = new System.Windows.Forms.Button();
			this.btnAddRechnung = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstbRechnungen
			// 
			this.lstbRechnungen.FormattingEnabled = true;
			this.lstbRechnungen.Location = new System.Drawing.Point(12, 34);
			this.lstbRechnungen.Name = "lstbRechnungen";
			this.lstbRechnungen.Size = new System.Drawing.Size(190, 251);
			this.lstbRechnungen.TabIndex = 0;
			// 
			// lstbPositionen
			// 
			this.lstbPositionen.FormattingEnabled = true;
			this.lstbPositionen.Location = new System.Drawing.Point(208, 34);
			this.lstbPositionen.Name = "lstbPositionen";
			this.lstbPositionen.Size = new System.Drawing.Size(190, 251);
			this.lstbPositionen.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Rechnungen:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(208, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Positionen:";
			// 
			// txtBezeichnung
			// 
			this.txtBezeichnung.Location = new System.Drawing.Point(102, 291);
			this.txtBezeichnung.Name = "txtBezeichnung";
			this.txtBezeichnung.Size = new System.Drawing.Size(100, 20);
			this.txtBezeichnung.TabIndex = 4;
			// 
			// txtDatum
			// 
			this.txtDatum.Location = new System.Drawing.Point(102, 317);
			this.txtDatum.Name = "txtDatum";
			this.txtDatum.Size = new System.Drawing.Size(100, 20);
			this.txtDatum.TabIndex = 5;
			// 
			// txtPosBezeichnung
			// 
			this.txtPosBezeichnung.Location = new System.Drawing.Point(298, 291);
			this.txtPosBezeichnung.Name = "txtPosBezeichnung";
			this.txtPosBezeichnung.Size = new System.Drawing.Size(100, 20);
			this.txtPosBezeichnung.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 294);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Bezeichnung:";
			// 
			// txtMenge
			// 
			this.txtMenge.Location = new System.Drawing.Point(298, 317);
			this.txtMenge.Name = "txtMenge";
			this.txtMenge.Size = new System.Drawing.Size(100, 20);
			this.txtMenge.TabIndex = 8;
			// 
			// txtEinzelpreis
			// 
			this.txtEinzelpreis.Location = new System.Drawing.Point(298, 343);
			this.txtEinzelpreis.Name = "txtEinzelpreis";
			this.txtEinzelpreis.Size = new System.Drawing.Size(100, 20);
			this.txtEinzelpreis.TabIndex = 9;
			// 
			// txtAufRechnung
			// 
			this.txtAufRechnung.Location = new System.Drawing.Point(298, 369);
			this.txtAufRechnung.Name = "txtAufRechnung";
			this.txtAufRechnung.Size = new System.Drawing.Size(100, 20);
			this.txtAufRechnung.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 320);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Datum:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(208, 294);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Bezeichnung:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(208, 320);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Menge:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(208, 346);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "Einzelpreis:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(208, 372);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Auf Rechnung:";
			// 
			// btnAddPosition
			// 
			this.btnAddPosition.Location = new System.Drawing.Point(208, 395);
			this.btnAddPosition.Name = "btnAddPosition";
			this.btnAddPosition.Size = new System.Drawing.Size(190, 23);
			this.btnAddPosition.TabIndex = 16;
			this.btnAddPosition.Text = "Hinzufügen";
			this.btnAddPosition.UseVisualStyleBackColor = true;
			this.btnAddPosition.Click += new System.EventHandler(this.BtnAddPosition_Click);
			// 
			// btnAddRechnung
			// 
			this.btnAddRechnung.Location = new System.Drawing.Point(12, 395);
			this.btnAddRechnung.Name = "btnAddRechnung";
			this.btnAddRechnung.Size = new System.Drawing.Size(190, 23);
			this.btnAddRechnung.TabIndex = 17;
			this.btnAddRechnung.Text = "Hinzufügen";
			this.btnAddRechnung.UseVisualStyleBackColor = true;
			this.btnAddRechnung.Click += new System.EventHandler(this.BtnAddRechnung_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 429);
			this.Controls.Add(this.btnAddRechnung);
			this.Controls.Add(this.btnAddPosition);
			this.Controls.Add(this.txtAufRechnung);
			this.Controls.Add(this.txtEinzelpreis);
			this.Controls.Add(this.txtMenge);
			this.Controls.Add(this.txtPosBezeichnung);
			this.Controls.Add(this.txtDatum);
			this.Controls.Add(this.txtBezeichnung);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstbPositionen);
			this.Controls.Add(this.lstbRechnungen);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.MinimumSize = new System.Drawing.Size(426, 467);
			this.Name = "MainForm";
			this.Text = "ArrayVerweise";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
