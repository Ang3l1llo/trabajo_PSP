using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class LifePotion : Potion
    {
        public String name = "LifePotion";
        public int Healing = 20;
        public LifePotion() {

            String Name = "LifePotion";
            int Healing = 20;
        }
        
        public override void Apply(Character character)
        {
            character.Heal(Healing);

            Console.WriteLine($"{character.Name} used a potion and recovers {Healing} points of life. Actual life: {character.CurrentHitPoints}");

        }
    }
}
