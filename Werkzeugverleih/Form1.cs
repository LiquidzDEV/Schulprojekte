using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Werkzeugverleih
{
    public partial class Form1 : Form
    {
        private List<Werkzeug> werkzeuge = new List<Werkzeug>();

        public Form1()
        {
            InitializeComponent();
            lblAusgabe.Text = "";
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtBezeichnung.Text.Trim().Length < 1) return;

            werkzeuge.Add(new Werkzeug(txtBezeichnung.Text, txtTageKurzausleihe.Text, txtPreisKurzausleihe.Text, txtTageLangausleihe.Text, txtPreisLangausleihe.Text));

            clearTextBoxes();
            refreshListBox();
        }

        private void clearTextBoxes()
        {
            txtBezeichnung.Clear();
            txtPreisKurzausleihe.Clear();
            txtPreisLangausleihe.Clear();
            txtTageKurzausleihe.Clear();
            txtTageLangausleihe.Clear();
        }

        private void refreshListBox()
        {
            lstbWerkzeuge.Items.Clear();

            foreach (Werkzeug werkzeug in werkzeuge)
            {
                lstbWerkzeuge.Items.Add(werkzeug.bezeichnung);
            }
        }

        private void lstbWerkzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbWerkzeuge.SelectedIndex;
            if (index < 0) return;

            txtBezeichnung.Text = werkzeuge[index].bezeichnung;
            txtTageKurzausleihe.Text = werkzeuge[index].tageKurzausleihe.ToString();
            txtPreisKurzausleihe.Text = werkzeuge[index].preisKurzausleihe.ToString();
            txtTageLangausleihe.Text = werkzeuge[index].tageLangausleihe.ToString();
            txtPreisLangausleihe.Text = werkzeuge[index].preisLangausleihe.ToString();
        }

        private void btnAusleihen_Click(object sender, EventArgs e)
        {
            int index = lstbWerkzeuge.SelectedIndex;
            if (index < 0) return;

            if (txtTageAusgeliehen.Text.Length == 0 || Int32.Parse(txtTageAusgeliehen.Text) < 1) return;

            int gelieheneTage = Int32.Parse(txtTageAusgeliehen.Text);

            int gesamtPreis;
            if (gelieheneTage > werkzeuge[index].tageKurzausleihe)
            {
                gesamtPreis = werkzeuge[index].preisLangausleihe * gelieheneTage;
                lblAusgabe.Text = werkzeuge[index].bezeichnung + "\nFür " + gelieheneTage + " Tag" + (gelieheneTage > 1 ? "e" : "") + " (Langausleihe)\nPreis: " + gesamtPreis + " €";
            }
            else
            {
                gesamtPreis = werkzeuge[index].preisKurzausleihe * gelieheneTage;
                lblAusgabe.Text = werkzeuge[index].bezeichnung + "\nFür " + gelieheneTage + " Tag" + (gelieheneTage > 1 ? "e" : "") + " (Kurzausleihe)\nPreis: " + gesamtPreis + " €";
            }

            txtTageAusgeliehen.Clear();
        }

        private void showOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

