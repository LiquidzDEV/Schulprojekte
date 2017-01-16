using System;
using System.Windows.Forms;

namespace Autoverleih
{
    public partial class Form1 : Form
	{
		// Bildung eines Arrays mit 5 Spalten und 10 Zeilen
		string[,] auto = new string[10, 5];
		int zaehler = 0;

		public Form1()
		{
			InitializeComponent();
		}

		// Aufgabe 1
		private void BtnSpeichern_Click(object sender, EventArgs e)
		{
			auto[zaehler, 0] = txtBezeichnung.Text;
			auto[zaehler, 1] = txtTyp.Text;
			auto[zaehler, 2] = txtPreisKilometer.Text;
			auto[zaehler, 3] = txtPreisTag.Text;
			auto[zaehler, 4] = txtKilometerstand.Text;

			ClearTextBoxes();

			zaehler++;

			RefreshListBox();
			RefreshAveragePrice();
		}

		private void ClearTextBoxes()
		{
			txtBezeichnung.Text = "";
			txtTyp.Text = "";
			txtPreisKilometer.Text = "";
			txtPreisTag.Text = "";
			txtKilometerstand.Text = "";
		}

		// Hält die lstb Aktuell; Diese Funktion wird an verschiedenen Programmpunkte verwendet.
		private void RefreshListBox()
		{
			lstbVerleihautoListe.Items.Clear();

			for (int i = 0; i < zaehler; i++) {
				lstbVerleihautoListe.Items.Add(auto[i, 0]);
			}
		}

		private void LstbVerleihautoListe_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = lstbVerleihautoListe.SelectedIndex;
			if (index >= 0) {
				txtBezeichnung.Text = auto[index, 0];
				txtTyp.Text = auto[index, 1];
				txtPreisKilometer.Text = auto[index, 2];
				txtPreisTag.Text = auto[index, 3];
				txtKilometerstand.Text = auto[index, 4];
			}
		}

		// Aufgabe 2
		private void BtnBezahlen_Click(object sender, EventArgs e)
		{
			int index = lstbVerleihautoListe.SelectedIndex;
			if (index >= 0) {
				int gemieteteTage = Int32.Parse(txtGemieteteTage.Text);
				int gefahreneKilometer = Int32.Parse(txtGefahreneKilometer.Text);
				int preisProTag = Int32.Parse(auto[index, 3]);
				int preisProKilometer = Int32.Parse(auto[index, 2]);

				int gesamtsumme = gefahreneKilometer * preisProKilometer + gemieteteTage * preisProTag;

				lblPreis.Text = "Gesamtsumme: " + gesamtsumme + " Euro";

				int neuerKilometerstand = Int32.Parse(auto[index, 4]) + gefahreneKilometer;

				/* auto[index, 4] = neuerKilometerstand.ToString();
                 * Beide Zuweisungen bewirken das selbe*/
				auto[index, 4] = "" + neuerKilometerstand;

				// gleich wie txtGefahreneKilometer.Text = "";
				txtGefahreneKilometer.Clear();
				txtGemieteteTage.Clear();

				txtKilometerstand.Text = auto[index, 4];
			}
		}

		// Aufgabe 3
		private void BtnLoeschen_Click(object sender, EventArgs e)
		{
			int index = lstbVerleihautoListe.SelectedIndex;
			if (index >= 0) {
				for (int i = index; i < zaehler; i++) {
					auto[i, 0] = auto[i + 1, 0];
					auto[i, 1] = auto[i + 1, 1];
					auto[i, 2] = auto[i + 1, 2];
					auto[i, 3] = auto[i + 1, 3];
					auto[i, 4] = auto[i + 1, 4];
				}
				zaehler--;
				ClearTextBoxes();
				RefreshListBox();
				RefreshAveragePrice();
			}
		}

		//Aufgabe 4
		private void BtnAendern_Click(object sender, EventArgs e)
		{
			int index = lstbVerleihautoListe.SelectedIndex;
			if (index >= 0) {
				auto[index, 3] = txtPreisTag.Text;

				ClearTextBoxes();

				RefreshAveragePrice();
			}
		}

		// Aufgabe 5
		private void RefreshAveragePrice()
		{
			if (zaehler > 0) {
				int gesamtPreisProTag = 0;
				for (int i = 0; i < zaehler; i++) {
					gesamtPreisProTag += Int32.Parse(auto[i, 3]);
				}

				gesamtPreisProTag /= zaehler;

				lblAverage.Text = "Durschnittspreis: " + gesamtPreisProTag + " Euro";
			} else {
				lblAverage.Text = "Durschnittspreis: 0 Euro";
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			string[] write = new string[zaehler * 5];
			for (int i = 0; i < zaehler; i++) {
				for (int u = 0; u < 5; u++) {
					write[i * 5 + u] = auto[i, u];
				}
			}
			System.IO.File.WriteAllLines("vehicles.txt", write);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] read = System.IO.File.ReadAllLines("vehicles.txt");
			for (int i = 0; i < read.Length / 5; i++) {
				for (int u = 0; u < 5; u++) {
					auto[i, u] = read[i * 5 + u];
				}
			}
			zaehler = read.Length / 5;
			RefreshListBox();
			RefreshAveragePrice();    
		}
	}
}
