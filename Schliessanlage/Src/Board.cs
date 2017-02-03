using ArduinoDriver.SerialProtocol;
using ArduinoUploader.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schliessanlage.Src
{
    public class Board
    {
        private const ArduinoModel arduinoModel = ArduinoModel.UnoR3;

        public static ArduinoDriver.ArduinoDriver driver;

        public const int PIN_REDLED = 11;
        public const int PIN_BLUELED = 10;
        public const int PIN_GREENLED = 9;
      

        public Board()
        {
            driver = new ArduinoDriver.ArduinoDriver(arduinoModel, "COM3", true);
        }

        public void setup()
        {
            driver.Send(new PinModeRequest(PIN_REDLED, PinMode.Output));
            driver.Send(new PinModeRequest(PIN_BLUELED, PinMode.Output));
            driver.Send(new PinModeRequest(PIN_GREENLED, PinMode.Output));
        }

        public void loop()
        {
            
        }

        public void close()
        {
            Board.driver.Send(new AnalogWriteRequest(Board.PIN_REDLED, 0));
            Board.driver.Send(new AnalogWriteRequest(Board.PIN_BLUELED, 0));
            Board.driver.Send(new AnalogWriteRequest(Board.PIN_GREENLED, 0));
            driver.Dispose();
        }
    }
}
