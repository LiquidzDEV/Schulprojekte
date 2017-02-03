/*
 * Pascal "Liquidz" H.
 * 03.02.2017 / 06:52
 * 
 * Description:
 */
using System;
using System.Collections.Generic;

namespace Schliessanlage
{
	/// <summary>
	/// Description of Rooms.
	/// </summary>
	public class Rooms
	{
		private readonly List<Room> rooms = new List<Room>();
		
		public Rooms()
		{
			this.load();
		}
		
		public List<Room> get()
		{
			return rooms;
		}
		
		public void load()
		{
			try
            {
                string[] read = System.IO.File.ReadAllLines(@"data\rooms.txt");
                for (int i = 0; i < read.Length / 2; i++)
                {
                    rooms.Add(new Room(Int32.Parse(read[i * 2 + 0]), read[i * 2 + 1]));
                }
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Keine Dateien gefunden, erstelle beim schliessen des Programms.");
            }
		}
		
		public void save()
		{
			string[] write = new string[rooms.Count * 2];
            for (int i = 0; i < rooms.Count; i++)
            {
            	write[i * 2 + 0] = rooms[i].id.ToString();
                write[i * 2 + 1] = rooms[i].roomnumber;
            }
            System.IO.File.WriteAllLines(@"data\rooms.txt", write);
		}
	}
}
