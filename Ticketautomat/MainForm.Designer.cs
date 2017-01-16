namespace TicketAutomat
{
    partial class TicketAutomat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblToPay = new System.Windows.Forms.Label();
            this.cbxTickets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMoney = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnStorno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticketautomat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Preis:";
            // 
            // lblToPay
            // 
            this.lblToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToPay.AutoSize = true;
            this.lblToPay.Location = new System.Drawing.Point(269, 125);
            this.lblToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToPay.Name = "lblToPay";
            this.lblToPay.Size = new System.Drawing.Size(149, 13);
            this.lblToPay.TabIndex = 6;
            this.lblToPay.Text = "Noch kein Ticket ausgewählt!";
            // 
            // cbxTickets
            // 
            this.cbxTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTickets.FormattingEnabled = true;
            this.cbxTickets.Items.AddRange(new object[] {
            "Einzelticket",
            "4er-Ticket"});
            this.cbxTickets.Location = new System.Drawing.Point(29, 84);
            this.cbxTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTickets.Name = "cbxTickets";
            this.cbxTickets.Size = new System.Drawing.Size(119, 21);
            this.cbxTickets.TabIndex = 7;
            this.cbxTickets.SelectedIndexChanged += new System.EventHandler(this.CbxTickets_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wähle deine Fahrkarte:";
            // 
            // cbxMoney
            // 
            this.cbxMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoney.FormattingEnabled = true;
            this.cbxMoney.Items.AddRange(new object[] {
            "10 Cent",
            "20 Cent",
            "50 Cent",
            "1 Euro",
            "2 Euro",
            "5 Euro",
            "10 Euro",
            "20 Euro"});
            this.cbxMoney.Location = new System.Drawing.Point(271, 84);
            this.cbxMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMoney.Name = "cbxMoney";
            this.cbxMoney.Size = new System.Drawing.Size(92, 21);
            this.cbxMoney.TabIndex = 9;
            this.cbxMoney.SelectedIndexChanged += new System.EventHandler(this.CbxMoney_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Eingeworfener Betrag:";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Location = new System.Drawing.Point(395, 84);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(64, 20);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Einwerfen";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 150);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Beschreibung";
            // 
            // btnStorno
            // 
            this.btnStorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStorno.Location = new System.Drawing.Point(271, 170);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(91, 20);
            this.btnStorno.TabIndex = 13;
            this.btnStorno.Text = "Geld zurück";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.BtnStorno_Click);
            // 
            // TicketAutomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 222);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTickets);
            this.Controls.Add(this.lblToPay);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(429, 261);
            this.Name = "TicketAutomat";
            this.Text = "Ticketautomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblToPay;
        private System.Windows.Forms.ComboBox cbxTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnStorno;
    }
}

