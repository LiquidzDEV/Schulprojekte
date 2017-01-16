using System;
using System.Linq;
using System.Windows.Forms;

namespace TicketAutomat
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        public void Show(string ticketName, string cashBack)
        {
            this.Text = "Dein " + ticketName;

            lblName.Text = ticketName;

            // Das aktuelle Datum bestimmen
            DateTime dateTime = DateTime.Now;
            lblDate.Text = dateTime.ToString("D") +" "+ dateTime.ToLongTimeString();

            lblCashBack.Text = "Rückgeld: " + cashBack;

            this.ShowDialog();
        }

        private void TicketFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
