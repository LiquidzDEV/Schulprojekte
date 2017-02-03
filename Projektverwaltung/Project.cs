using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektverwaltung
{
    class Project
    {
        public string name;
        public int number;
        public int budget;

        public Project(string name, int number, int budget)
        {
            this.name = name;
            this.number = number;
            this.budget = budget;
        }
    }
}
