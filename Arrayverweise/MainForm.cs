/*
 * User: PascalHobza
 * Date: 11.11.2016
 * Time: 10:35
 */
using System;
using System.Windows.Forms;

namespace Arrayverweise
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[,] positionen = new string[20, 4];
		int zaehler_pos;
		
		string[,] rechnungen = new string[10, 3];
		int zaehler_rech;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void BtnAddPosition_Click(object sender, EventArgs e)
		{
			positionen[zaehler_pos, 0] = txtPosBezeichnung.Text;
			positionen[zaehler_pos, 1] = txtMenge.Text;
			positionen[zaehler_pos, 2] = txtEinzelpreis.Text;
			positionen[zaehler_pos, 3] = txtAufRechnung.Text;
			
			zaehler_pos++;
			
			clearTextBoxesPosition();
			refreshlstbPositionen();
			refreshRechnungen();
		}
		
		void BtnAddRechnung_Click(object sender, EventArgs e)
		{
			rechnungen[zaehler_rech, 0] = txtBezeichnung.Text;
			rechnungen[zaehler_rech, 1] = txtDatum.Text;
			rechnungen[zaehler_rech, 2] = "0";
			
			zaehler_rech++;
			
			clearTextBoxesRechnungen();
			refreshlstbRechnungen();
		}
		
		private void refreshlstbPositionen()
		{
			lstbPositionen.Items.Clear();
			
			for (int i = 0; i < zaehler_pos; i++) {
				lstbPositionen.Items.Add(positionen[i, 0] + " " + positionen[i, 1] + " " + positionen[i, 2] + " " + positionen[i, 3]);
			}
		}
		
		private void refreshlstbRechnungen()
		{
			lstbRechnungen.Items.Clear();
			
			for (int i = 0; i < zaehler_rech; i++) {
				lstbRechnungen.Items.Add(rechnungen[i, 0] + " " + rechnungen[i, 1] + " " + rechnungen[i, 2] + "€");
			}
		}
		
		private void clearTextBoxesPosition()
		{
			txtPosBezeichnung.Clear();
			txtMenge.Clear();
			txtEinzelpreis.Clear();
			txtAufRechnung.Clear();
		}
		
		private void clearTextBoxesRechnungen()
		{
			txtBezeichnung.Clear();
			txtDatum.Clear();
		}
		

		private void refreshRechnungen()
		{
			for (int i = 0; i < zaehler_rech; i++) {
				rechnungen[i, 2] = "0";
			}
			
			for (int i = 0; i < zaehler_pos; i++) {
				int rechnung = Convert.ToInt32(positionen[i, 3]);
				
				int alteRechnung = Convert.ToInt32(rechnungen[rechnung, 2]);
				
				int gesamtPreis = Convert.ToInt32(positionen[i, 1]) * Convert.ToInt32(positionen[i, 2]);
				
				int neueRechnung = alteRechnung + gesamtPreis;
				
				rechnungen[rechnung, 2] = neueRechnung.ToString();
			}
			
			refreshlstbRechnungen();
		}
	}
}
