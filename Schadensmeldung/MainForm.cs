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
        /// <summary>Schadensmeldungen -><br></br>0:"Raum" 1:"Melder" 2:"Raum von" 3:"Datum"</summary>
        string[,] damageReports = new string[100, 4];
        int damageReportsIndex;

        /// <summary>Schaeden -><br></br>0:"zugehöriger Schaden" 1:"Gerät" 2:"Schaden" 3:"Status"</summary>
        string[,] damages = new string[1000, 4];
        int damagesIndex;

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

        void BtnAddCatDamage_Click(object sender, EventArgs e)
        {
            if (txtRoom.Text.Trim().Length < 3) return;

            damageReports[damageReportsIndex, 0] = txtRoom.Text;
            damageReports[damageReportsIndex, 1] = txtReporter.Text;
            damageReports[damageReportsIndex, 2] = txtOwner.Text;
            damageReports[damageReportsIndex, 3] = DateTime.Now.ToString();
            damageReportsIndex++;

            RefreshListBox();
            ClearDamageTextBoxes();
        }

        private void RefreshListBox()
        {
            lstbCatDamages.Items.Clear();

            for (int i = 0; i < damageReportsIndex; i++)
            {
                lstbCatDamages.Items.Add("Meldung von " + damageReports[i, 1] + " am " + damageReports[i, 3]);
            }
        }

        private void ClearDamageTextBoxes()
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
                lblRoom.Text = damageReports[index, 0];
                lblReporter.Text = damageReports[index, 1];
                lblOwner.Text = damageReports[index, 2];
                lblDate.Text = damageReports[index, 3];
                txtDevice.Enabled = true;
                txtDamage.Enabled = true;
                cboStatus.Enabled = true;
                btnAddDamage.Enabled = true;
                btnEdit.Enabled = true;
            }
            RefreshListView();
            ClearDamageReportsTextBoxes();
        }

        void BtnAddDamage_Click(object sender, EventArgs e)
        {
            if (txtDevice.Text.Trim().Length < 3 || txtDamage.Text.Trim().Length < 3) return;

            damages[damagesIndex, 0] = lstbCatDamages.SelectedIndex.ToString();
            damages[damagesIndex, 1] = txtDevice.Text;
            damages[damagesIndex, 2] = txtDamage.Text;
            damages[damagesIndex, 3] = cboStatus.Text;
            damagesIndex++;

            RefreshListView();
            ClearDamageReportsTextBoxes();
        }

        private void RefreshListView()
        {
            lstbDamage.Items.Clear();

            for (int i = 0; i < damagesIndex; i++)
            {

                int category = lstbCatDamages.SelectedIndex;

                if (Int32.Parse(damages[i, 0]) == category)
                {
                    string item = damages[i, 1] + "\t" + damages[i, 1] + "\t" + damages[i, 2] + "\t" + damages[i, 3];

                    int index = lstbDamage.Items.Add(item);

                    arrayReference[index] = i;
                }
            }
        }

        private void ClearDamageReportsTextBoxes()
        {
            txtDevice.Clear();
            txtDamage.Clear();
            cboStatus.SelectedIndex = 0;
        }


        void BtnEdit_Click(object sender, EventArgs e)
        {
            int index = lstbDamage.SelectedIndex;
            if (index < 0) return;

            damages[arrayReference[index], 1] = txtDevice.Text;
            damages[arrayReference[index], 2] = txtDamage.Text;
            damages[arrayReference[index], 3] = cboStatus.Text;

            RefreshListView();
        }


        void LstbDamages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbDamage.SelectedIndex;
            if (index < 0) return;

            txtDevice.Text = damages[arrayReference[index], 1];
            txtDamage.Text = damages[arrayReference[index], 2];
            cboStatus.Text = damages[arrayReference[index], 3];
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string[] read = System.IO.File.ReadAllLines("damages.txt");
                for (int i = 0; i < read.Length / 4; i++)
                {
                    for (int u = 0; u < 4; u++)
                    {
                        damageReports[i, u] = read[i * 4 + u];
                    }
                }
                damageReportsIndex = read.Length / 4;
                RefreshListBox();

                read = System.IO.File.ReadAllLines("damageReports.txt");
                for (int i = 0; i < read.Length / 4; i++)
                {
                    for (int u = 0; u < 4; u++)
                    {
                        damages[i, u] = read[i * 4 + u];
                    }
                }
                damagesIndex = read.Length / 4;
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Keine Daten gefunden!");
            }
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] write = new string[damageReportsIndex * 4];
            for (int i = 0; i < damageReportsIndex; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    write[i * 4 + u] = damageReports[i, u];
                }
            }
            System.IO.File.WriteAllLines("damages.txt", write);

            write = new string[damagesIndex * 4];
            for (int i = 0; i < damagesIndex; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    write[i * 4 + u] = damages[i, u];
                }
            }
            System.IO.File.WriteAllLines("damageReports.txt", write);
        }
    }
}
