using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class LifePotion : Potion
    {
        public int Healing {  get; set; }
        public LifePotion(String name, int healing) {

            Name = name;
            Healing = healing;
        }
        
        public override void Apply(Character character)
        {
            character.Heal(this);

            Console.WriteLine($"{character.Name} used a potion and recovers {Healing} points of life. Actual life: {character.CurrentHitPoints}");

        }
    }
}
