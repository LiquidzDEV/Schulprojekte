using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektverwaltung
{
    class Task
    {
        public string name;
        public string status;
        public int zeitaufwand;
        public int projektnummer;

        public Task(string name, string status, int zeitaufwand, int projektnummer)
        {
            this.name = name;
            this.status = status;
            this.zeitaufwand = zeitaufwand;
            this.projektnummer = projektnummer;
        }
    }
}
