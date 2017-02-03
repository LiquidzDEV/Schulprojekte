/*
 * Pascal "Liquidz" H.
 * 03.02.2017 / 07:10
 * 
 * Description:
 */
using System;

namespace Schliessanlage.Data
{
	/// <summary>
	/// Description of Access.
	/// </summary>
	public class Access
	{
		public int id { get; private set; }
		public int id_room { get; private set; }
		public int id_user { get; private set; }
		public int von { get; private set; }
		public int bis { get; private set; }
		
		public Access(int id, int id_room, int id_user, int von, int bis)
		{
			this.id = id;
			this.id_room = id_room;
			this.id_user = id_user;
			this.von = von;
			this.bis = bis;
		}
	}
}
