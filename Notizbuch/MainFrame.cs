using System;
using System.Windows.Forms;

namespace Notizbuch
{
    public partial class MainFrame : Form
    {

        /*
         *        0   |   1   |     2     |   3   |     4
         *      Titel | Daten | Verfasser | Datum | Kategorie
         *      ----------------------------------
         * 0 |
         * 1 |
         * 2 |
         * 3 |
         * 4 |
         */

        private string[,] notes = new string[10, 5];
        private int index;

        private int[] searchPointer = new int[10];
        private int searchIndex;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            notes[index, 0] = txtTitle.Text;
            notes[index, 1] = txtNote.Text;
            notes[index, 2] = txtCreator.Text;
            notes[index, 3] = txtDate.Text;
            notes[index, 4] = txtCategory.Text;
            index++;

            ClearForm();
            RefreshListBox();
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    notes[i, 0] = "";
                    notes[i, 1] = "";
                    notes[i, 2] = "";
                    notes[i, 3] = "";
                }

                index = 0;
            }

            lstNotes.Items.Clear();
            lstSearch.Items.Clear();

            ClearForm();
            RefreshListBox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstNotes.SelectedIndex;

            if (selectedIndex >= 0)
            {


                for (int i = selectedIndex; i < index; i++)
                {
                    notes[i, 0] = notes[i + 1, 0];
                    notes[i, 1] = notes[i + 1, 1];
                    notes[i, 2] = notes[i + 1, 2];
                    notes[i, 3] = notes[i + 1, 3];
                }
                this.index--;

                ClearForm();
                RefreshListBox();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lstSearch.Items.Clear();
            searchIndex = 0;

            for (int i = 0; i < index; i++)
            {
                if (txtSearch.Text.Equals(notes[i, 2]))
                {
                    lstSearch.Items.Add(notes[i, 0]);
                    searchPointer[searchIndex] = i;

                    searchIndex++;
                }
            }
        }

        private void LstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex < 0) return;

            int selectedIndex = lstNotes.SelectedIndex;

            txtTitle.Text = notes[selectedIndex, 0];
            txtNote.Text = notes[selectedIndex, 1];
            txtCreator.Text = notes[selectedIndex, 2];
            txtDate.Text = notes[selectedIndex, 3];
            txtCategory.Text = notes[selectedIndex, 4];
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstNotes.SelectedIndex;

            notes[selectedIndex, 0] = txtTitle.Text;
            notes[selectedIndex, 1] = txtNote.Text;
            notes[selectedIndex, 2] = txtCreator.Text;
            notes[selectedIndex, 3] = txtDate.Text;
            notes[selectedIndex, 4] = txtCategory.Text;

            ClearForm();

            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lstNotes.Items.Clear();

            for (int i = 0; i < index; i++)
            {
                lstNotes.Items.Add(notes[i, 0]);
            }
        }

        private void ClearForm()
        {
            txtTitle.Clear();
            txtNote.Clear();
            txtCreator.Clear();
            txtDate.Clear();
            txtCategory.Clear();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int pos = 0;
            string[] read = System.IO.File.ReadAllLines("notes.txt");

            for (int i = 0; i < read.Length / 5; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    notes[i, u] = read[pos];
                    pos++;
                }
            }
            index = read.Length / 5;

            RefreshListBox();
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            int pos = 0;
            string[] write = new string[index * 5];

            for (int i = 0; i < index; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    write[pos] = notes[i, u];
                    pos++;
                }
            }
            System.IO.File.WriteAllLines("notes.txt", write);
        }
    }
}
