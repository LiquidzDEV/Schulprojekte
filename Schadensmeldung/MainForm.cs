/*
 * User: PascalHobza
 * Date: 23.12.2016
 * Time: 06:14
 */
using System;
using System.Windows.Forms;

namespace Schadensmeldung
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>Schaden -><br></br>0:"Raum" 1:"Melder" 2:"Raum von" 3:"Datum"</summary>
        string[,] damages = new string[100, 4];
        int damageIndex;

        /// <summary>Schadensmeldungen -><br></br>0:"zugehöriger Schaden" 1:"Gerät" 2:"Schaden" 3:"Status"</summary>
        string[,] damageReports = new string[1000, 4];
        int damageReportsIndex;

        /// <summary>
        /// Referenz Array:<para />
        /// Dadurch das wir durch Auswahl einer Schadenskategorie nur ein Teil der Daten des Arrays in die Listbox schreiben,<para />
        /// entspricht der SelectedIndex nicht dem Platz der Daten im Array.<para />
        /// Deswegen müssen wir uns mit einem Referenz Array merken wo im Array die Daten zu dem entsprechenden Listbox eintrag stehen.<para />
        /// </summary>
        int[] arrayReference = new int[1000];

        public MainForm()
        {
            InitializeComponent();
            lblRoom.Text = "";
            lblReporter.Text = "";
            lblOwner.Text = "";
            lblDate.Text = "";
            cboStatus.SelectedIndex = 0;
        }

        void BtnAddCatDamageClick(object sender, EventArgs e)
        {
            if (txtRoom.Text.Trim().Length < 3) return;

            damages[damageIndex, 0] = txtRoom.Text;
            damages[damageIndex, 1] = txtReporter.Text;
            damages[damageIndex, 2] = txtOwner.Text;
            damages[damageIndex, 3] = DateTime.Now.ToString();
            damageIndex++;

            refreshListBox();
            clearDamageTextBoxes();
        }

        private void refreshListBox()
        {
            lstbCatDamages.Items.Clear();

            for (int i = 0; i < damageIndex; i++)
            {
                lstbCatDamages.Items.Add("Meldung von " + damages[i, 1] + " am " + damages[i, 3]);
            }
        }

        private void clearDamageTextBoxes()
        {
            txtRoom.Clear();
            txtReporter.Clear();
            txtOwner.Clear();
        }

        void LstbCatDamages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbCatDamages.SelectedIndex;
            if (index < 0)
            {
                txtDevice.Enabled = false;
                txtDamage.Enabled = false;
                cboStatus.Enabled = false;
                btnAddDamage.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                lblRoom.Text = damages[index, 0];
                lblReporter.Text = damages[index, 1];
                lblOwner.Text = damages[index, 2];
                lblDate.Text = damages[index, 3];
                txtDevice.Enabled = true;
                txtDamage.Enabled = true;
                cboStatus.Enabled = true;
                btnAddDamage.Enabled = true;
                btnEdit.Enabled = true;
            }
            refreshListView();
            clearDamageReportsTextBoxes();
        }

        void BtnAddDamage_Click(object sender, EventArgs e)
        {
            if (txtDevice.Text.Trim().Length < 3 || txtDamage.Text.Trim().Length < 3) return;

            damageReports[damageReportsIndex, 0] = lstbCatDamages.SelectedIndex.ToString();
            damageReports[damageReportsIndex, 1] = txtDevice.Text;
            damageReports[damageReportsIndex, 2] = txtDamage.Text;
            damageReports[damageReportsIndex, 3] = cboStatus.Text;
            damageReportsIndex++;

            refreshListView();
            clearDamageReportsTextBoxes();
        }

        private void refreshListView()
        {
            lstbDamages.Items.Clear();

            for (int i = 0; i < damageReportsIndex; i++)
            {

                int category = lstbCatDamages.SelectedIndex;

                if (Int32.Parse(damageReports[i, 0]) == category)
                {
                    string item = damageReports[i, 1] + "\t" + damageReports[i, 1] + "\t" + damageReports[i, 2] + "\t" + damageReports[i, 3];

                    int index = lstbDamages.Items.Add(item);

                    arrayReference[index] = i;
                }
            }
        }

        private void clearDamageReportsTextBoxes()
        {
            txtDevice.Clear();
            txtDamage.Clear();
            cboStatus.SelectedIndex = 0;
        }


        void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstbDamages.SelectedIndex;
            if (index < 0) return;

            damageReports[arrayReference[index], 1] = txtDevice.Text;
            damageReports[arrayReference[index], 2] = txtDamage.Text;
            damageReports[arrayReference[index], 3] = cboStatus.Text;

            refreshListView();
        }


        void LstbDamagesSelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbDamages.SelectedIndex;
            if (index < 0) return;

            txtDevice.Text = damageReports[arrayReference[index], 1];
            txtDamage.Text = damageReports[arrayReference[index], 2];
            cboStatus.Text = damageReports[arrayReference[index], 3];
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            try
            {
                string[] read = System.IO.File.ReadAllLines("damages.txt");
                for (int i = 0; i < read.Length / 4; i++)
                {
                    for (int u = 0; u < 4; u++)
                    {
                        damages[i, u] = read[i * 4 + u];
                    }
                }
                damageIndex = read.Length / 4;
                refreshListBox();

                read = System.IO.File.ReadAllLines("damageReports.txt");
                for (int i = 0; i < read.Length / 4; i++)
                {
                    for (int u = 0; u < 4; u++)
                    {
                        damageReports[i, u] = read[i * 4 + u];
                    }
                }
                damageReportsIndex = read.Length / 4;
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Keine Daten gefunden!");
            }
        }

        void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            string[] write = new string[damageIndex * 4];
            for (int i = 0; i < damageIndex; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    write[i * 4 + u] = damages[i, u];
                }
            }
            System.IO.File.WriteAllLines("damages.txt", write);

            write = new string[damageReportsIndex * 4];
            for (int i = 0; i < damageReportsIndex; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    write[i * 4 + u] = damageReports[i, u];
                }
            }
            System.IO.File.WriteAllLines("damageReports.txt", write);
        }
    }
}
