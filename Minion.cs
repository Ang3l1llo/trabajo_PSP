using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class Minion
    {
        public String Name;
        public int MaxHitPoints;
        public int CurrentHitPoints;
        public int Damage;
        public int Armor;

        public Minion(String name, int maxHitPoints, int damage, int armor)
        {
            Name = name;
            MaxHitPoints = maxHitPoints;
            CurrentHitPoints = maxHitPoints;
            Damage = damage;
            Armor = armor;

        }
        public int Attack()
        {
            return Damage;
        }
        public int Defense()
        {
            return Armor;
        }
        public int RecieveDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - Defense()); 
            CurrentHitPoints -= reducedDamage;
            if (CurrentHitPoints < 0)
            {
                CurrentHitPoints = 0;
            }
            Console.WriteLine($"{Name} takes {reducedDamage} points of damage");
            return CurrentHitPoints;

        }

    }
}
