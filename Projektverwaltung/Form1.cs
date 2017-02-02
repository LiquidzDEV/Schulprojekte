using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projektverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>Array für die Projekte</summary>
        List<Project> projekte = new List<Project>();

        /// <summary>Array für die Tasks</summary>
        List<Task> tasks = new List<Task>();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] read = System.IO.File.ReadAllLines("projekte.txt");
                for (int i = 0; i < read.Length / 3; i++)
                {
                    projekte.Add(new Project(read[i * 3 + 0], Int32.Parse(read[i * 3 + 1]), Int32.Parse(read[i * 3 + 2])));
                }

                read = System.IO.File.ReadAllLines("tasks.txt");
                for (int i = 0; i < read.Length / 4; i++)
                {
                    tasks.Add(new Task(read[i * 4 + 0], read[i * 4 + 1], Int32.Parse(read[i * 4 + 2]), Int32.Parse(read[i * 4 + 3])));
                }
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Keine Dateien gefunden, erstelle beim schliessen des Programms.");
            }

            lstbProjekte_Refresh();
            lstbTasks_Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] write = new string[projekte.Count * 3];
            for (int i = 0; i < projekte.Count; i++)
            {
                write[i * 3 + 0] = projekte[i].name;
                write[i * 3 + 1] = projekte[i].number.ToString();
                write[i * 3 + 2] = projekte[i].budget.ToString();
            }
            System.IO.File.WriteAllLines("projekte.txt", write);

            write = new string[tasks.Count * 4];
            for (int i = 0; i < tasks.Count; i++)
            {
                write[i * 4 + 0] = tasks[i].name;
                write[i * 4 + 1] = tasks[i].status;
                write[i * 4 + 2] = tasks[i].zeitaufwand.ToString();
                write[i * 4 + 3] = tasks[i].projektnummer.ToString();
            }
            System.IO.File.WriteAllLines("tasks.txt", write);
        }

        private void btnProSpeichern_Click(object sender, EventArgs e)
        {
            projekte.Add(new Project(txtProName.Text, Int32.Parse(txtProNumber.Text), Int32.Parse(txtProBudget.Text)));
            clearProjectBoxes();
            lstbProjekte_Refresh();
            lstbTasks_Refresh();
        }

        private void clearProjectBoxes()
        {
            txtProBudget.Clear();
            txtProName.Clear();
            txtProNumber.Clear();
        }

        private void lstbProjekte_Refresh()
        {
            lstbProjekte.Items.Clear();
            foreach (var projekt in projekte)
            {
                lstbProjekte.Items.Add(projekt.name);
            }
        }

        private void btnTaskSpeichern_Click(object sender, EventArgs e)
        {
            tasks.Add(new Task(txtTaskName.Text, txtTaskStatus.Text, Int32.Parse(txtTaskTime.Text), Int32.Parse(txtTaskProNumber.Text)));
            clearTaskBoxes();
            lstbTasks_Refresh();
        }

        private void clearTaskBoxes()
        {
            txtTaskName.Clear();
            txtTaskProNumber.Clear();
            txtTaskStatus.Clear();
            txtTaskTime.Clear();
        }

        private void lstbTasks_Refresh()
        {
            lstbTasks.Items.Clear();

            int index = lstbProjekte.SelectedIndex;
            if (index < 0) return;

            foreach (var task in tasks)
            {
                if (projekte[index].number == task.projektnummer)
                {
                    lstbTasks.Items.Add(task.name);
                }
            }
        }

        private void btnGesamtzeitaufwand_Click(object sender, EventArgs e)
        {
            txtGesamtZeit.Text = calculateTime(lstbProjekte.SelectedIndex).ToString();
        }

        /// <summary>Berechnet in abhängigkeit der Projektnummer, den Gesamtzeitaufwand der Tasks des ausgewählten Projekts.</summary>
        /// <param name="index">Der SelectedIndex des Projekts</param>
        /// <returns>Den Gesamtzeitaufwand als int</returns>
        private int calculateTime(int index)
        {
            if (index < 0) return 0;

            int gesamtzeitaufwand = 0;

            foreach (var task in tasks)
            {
                if (projekte[index].number == task.projektnummer)
                {
                    gesamtzeitaufwand += task.zeitaufwand;
                }
            }
            return gesamtzeitaufwand;
        }

        private void lstbProjekte_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbTasks_Refresh();
            txtGesamtZeit.Text = "0"; //calculateTime(lstbProjekte_SelectedIndex).ToString();
        }

        /// <summary>KeyPress-Event, damit gewisse Textfelder nur Nummern darstellen können.</summary> 
        private void ShowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
