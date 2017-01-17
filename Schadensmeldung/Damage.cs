namespace Schadensmeldung
{
    class Damage
    {
        public int damageCategory;
        public string device;
        public string damage;
        public string status;

        public Damage(int damageCategory, string device, string damage, string status)
        {
            this.damageCategory = damageCategory;
            this.device = device;
            this.damage = damage;
            this.status = status;
        }
    }
}
