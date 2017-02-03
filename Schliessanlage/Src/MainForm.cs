using ArduinoDriver;
using ArduinoDriver.SerialProtocol;
using Schliessanlage.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schliessanlage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Schliessanlage.instance.board.close();
        }

        private void loop_Tick(object sender, EventArgs e)
        {
            Schliessanlage.instance.board.loop();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            Board.driver.Send(new AnalogWriteRequest(Board.PIN_REDLED, Convert.ToByte(tbRed.Value)));
            Board.driver.Send(new AnalogWriteRequest(Board.PIN_BLUELED, Convert.ToByte(tbBlue.Value)));
            Board.driver.Send(new AnalogWriteRequest(Board.PIN_GREENLED, Convert.ToByte(tbGreen.Value)));
        }
    }
}
