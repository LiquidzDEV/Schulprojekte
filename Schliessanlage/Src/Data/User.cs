/*
 * Pascal "Liquidz" H.
 * 03.02.2017 / 07:04
 * 
 * Description:
 */
using System;

namespace Schliessanlage.Data
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User
	{
		public int id { get; private set; }
		public int rfid { get; private set; }
		public string vorname{ get; set; }
		public string nachname{ get; set; }
		
		public User(int id, int rfid, string vorname, string nachname)
		{
			this.id = id;
			this.rfid = rfid;
			this.vorname = vorname;
			this.nachname = nachname;
		}
	}
}
