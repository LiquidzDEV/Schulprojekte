/*
 * Pascal "Liquidz" H.
 * 03.02.2017 / 07:06
 * 
 * Description:
 */
using System;
using System.Collections.Generic;

namespace Schliessanlage.Data
{
	/// <summary>
	/// Description of Users.
	/// </summary>
	public class Users
	{
		private readonly List<User> users = new List<User>();
		
		public Users()
		{
			this.load();
		}
		
		public List<User> get()
		{
			return users;
		}
		
		public void load()
		{
			try
            {
                string[] read = System.IO.File.ReadAllLines(@"data\users.txt");
                for (int i = 0; i < read.Length / 4; i++)
                {
                    users.Add(new User(Int32.Parse(read[i * 4 + 0]), Int32.Parse(read[i * 4 + 1]), read[i * 4 + 2], read[i * 4 + 3]));
                }
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Keine Dateien gefunden, erstelle beim schliessen des Programms.");
            }
		}
		
		public void save()
		{
			string[] write = new string[users.Count * 4];
            for (int i = 0; i < users.Count; i++)
            {
            	write[i * 4 + 0] = users[i].id.ToString();
            	write[i * 4 + 1] = users[i].rfid.ToString();
                write[i * 4 + 2] = users[i].vorname;
                write[i * 4 + 3] = users[i].nachname;
            }
            System.IO.File.WriteAllLines(@"data\users.txt", write);
		}
	}
}
