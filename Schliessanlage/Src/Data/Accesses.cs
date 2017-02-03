/*
 * Pascal "Liquidz" H.
 * 03.02.2017 / 07:10
 * 
 * Description:
 */
using System;
using System.Collections.Generic;

namespace Schliessanlage.Data
{
	/// <summary>
	/// Description of Accesses.
	/// </summary>
	public class Accesses
	{
		private readonly List<Access> accesses = new List<Access>();
		
		public Accesses()
		{
			this.load();
		}
		
		public List<Access> get()
		{
			return accesses;
		}
		
		public void load()
		{
			try
            {
                string[] read = System.IO.File.ReadAllLines(@"data\accesses.txt");
                for (int i = 0; i < read.Length / 2; i++)
                {
                    accesses.Add(new Access(Int32.Parse(read[i * 5 + 0]), Int32.Parse(read[i * 5 + 1]), Int32.Parse(read[i * 5 + 2]), Int32.Parse(read[i * 5 + 3]), Int32.Parse(read[i * 5 + 4])));
                }
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Keine Dateien gefunden, erstelle beim schliessen des Programms.");
            }
		}
		
		public void save()
		{
			string[] write = new string[accesses.Count * 2];
            for (int i = 0; i < accesses.Count; i++)
            {
            	write[i * 2 + 0] = accesses[i].id.ToString();
                write[i * 2 + 1] = accesses[i].id_room.ToString();
                write[i * 2 + 1] = accesses[i].id_user.ToString();
                write[i * 2 + 1] = accesses[i].von.ToString();
                write[i * 2 + 1] = accesses[i].bis.ToString();
            }
            System.IO.File.WriteAllLines(@"data\accesses.txt", write);
		}
	}
}
