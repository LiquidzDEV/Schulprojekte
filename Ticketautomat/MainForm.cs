using System;
using System.Windows.Forms;

namespace TicketAutomat
{
    public partial class TicketAutomat : Form
    {
        public int EINZELTICKET = 499;
        public string EINZELTICKET_DESC = "Ein Ticket für eine Person.";
        public int VIERERTICKET = 1499;
        public string VIERERTICKET_DESC = "Ein Ticket für vier Personen\noder vier einzelne Fahrten.";

        public int[] moneyArray = new int[] {
            10, 20, 50, 100, 200, 500, 1000, 2000
        };

        /// Form (das zweite Fenster) wo das gekaufte Ticket angezeigt wird
        public TicketForm ticketFrame;

        public int price;
        public int money;

        public TicketAutomat()
        {
            InitializeComponent();
            ticketFrame = new TicketForm();
            lblDescription.Text = "";
        }

        public static string ValueToPrice(int value)
        {
            float price = value;
            price /= 100;
            return price < 0 ? "0€" : price + "€";
        }

        private void CbxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTicketLabels(this.cbxTickets.SelectedItem.ToString());
            Console.WriteLine(this.cbxTickets.SelectedIndex);
        }

        private void RefreshTicketLabels(string ticket)
        {
            if (ticket == "Einzelticket")
            {
                price = EINZELTICKET;
                lblPrice.Text = "Preis: " + TicketAutomat.ValueToPrice(EINZELTICKET);
                lblDescription.Text = EINZELTICKET_DESC;
            }
            else if (ticket == "4er-Ticket")
            {
                price = VIERERTICKET;
                lblPrice.Text = "Preis: " + TicketAutomat.ValueToPrice(VIERERTICKET);
                lblDescription.Text = VIERERTICKET_DESC;
            }
            else
            {
                this.lblPrice.Text = "Preis:";
                this.lblDescription.Text = "";
            }
            RefreshToPay();
        }

        private void CbxMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(moneyArray[cbxMoney.SelectedIndex]);
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            int index = cbxMoney.SelectedIndex;
            if (index != -1 && cbxTickets.SelectedIndex != -1)
            {
                money += moneyArray[index];
                RefreshToPay();
            }
        }

        private void BtnStorno_Click(object sender, EventArgs e)
        {
            Storno();
        }

        private void Storno()
        {
            money = 0;
            RefreshToPay();
        }

        private void RefreshToPay()
        {
            if (cbxTickets.SelectedIndex != -1)
            {
                int value = price - money;
                if (value < 0)
                {
                    Storno();
                    ticketFrame.Show(cbxTickets.SelectedItem.ToString(), ValueToPrice(value * -1));
                }
                lblToPay.Text = "Noch zu zahlen: " + ValueToPrice(price - money);
                return;
            }
            lblToPay.Text = "Noch kein Ticket ausgewählt!";
        }
    }
}
