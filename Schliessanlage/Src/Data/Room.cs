/*
 * Pascal "Liquidz" H.
 * 03.02.2017 / 06:49
 * 
 * Description:
 */
using System;

namespace Schliessanlage
{
	/// <summary>
	/// Description of Room.
	/// </summary>
	public class Room
	{
		public int id { get; private set; }
		public string roomnumber { get; private set; }
		
		public Room(int id, string roomnumber)
		{
			this.id = id;
			this.roomnumber = roomnumber;
		}
	}
}
