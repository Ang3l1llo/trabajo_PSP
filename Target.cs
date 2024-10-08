using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Primerproyecto
{
    abstract class Target
    {
        public String Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int Damage {  get; set; }
        public int Armor {  get; set; }

        public abstract int RecieveDamage(int damage);
        public abstract bool IsAlive();
    }
     
}
