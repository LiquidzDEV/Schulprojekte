using System.IO;
using System.Windows.Forms;
using ArduinoUploader.Hardware;
using ArduinoDriver.SerialProtocol;
using Schliessanlage.Src;

namespace Schliessanlage
{
    public class Schliessanlage
    {
        private static Schliessanlage _instance = new Schliessanlage();

        public static Schliessanlage instance
        {
            get
            {
                return _instance;
            }
        }

        public MainForm mainForm;

        public Board board;

        private Schliessanlage()
        {

        }

        private bool initialized;
        public void init()
        {
            if (initialized)
                return;

            Directory.CreateDirectory(@"data");

            board = new Board();

            mainForm = new MainForm();

            board.setup();

            Application.Run(mainForm);

            initialized = true;
        }
    }
}
