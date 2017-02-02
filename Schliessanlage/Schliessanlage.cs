using System.Windows.Forms;
using ArduinoUploader.Hardware;

namespace Schliessanlage
{
	public class Schliessanlage
	{
		private static Schliessanlage _instance = new Schliessanlage();
    	
		public static Schliessanlage instance {
			get {
				return _instance;
			}
		}
		
		public MainForm mainForm;
    	
		private const ArduinoModel arduinoModel = ArduinoModel.UnoR3;

		private ArduinoDriver.ArduinoDriver driver;// = new ArduinoDriver.ArduinoDriver(arduinoModel, true)

		private Schliessanlage()
		{
			
		}
        
		private bool initialized;
		public void init()
		{
			if (initialized)
				return;
        	
			mainForm = new MainForm();
			
			Application.Run(mainForm);
        	
			initialized = true;
		}
	}
}
