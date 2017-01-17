using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schadensmeldung
{
    class Damage
    {
        public int damageCategory;
        public string device;
        public string damage;
        public int status;

        public Damage(int damageCategory, string device, string damage, int status)
        {
            this.damageCategory = damageCategory;
            this.device = device;
            this.damage = damage;
            this.status = status;
        }
    }
}
