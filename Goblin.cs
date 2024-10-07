using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Primerproyecto
{
    class Goblin : Target
    {   
      
        public Goblin()
        {
            Name = "Goblin";
            MaxHitPoints = 30;
            CurrentHitPoints = MaxHitPoints;
            Damage = 15;
            Armor = 10;
        }
        public int Attack()
        {
            return Damage;
        }
        public int Defense()
        {
            return Armor;
        }
        public override int RecieveDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - Defense()); 
            CurrentHitPoints -= reducedDamage;
            if (CurrentHitPoints< 0)
            {
                CurrentHitPoints = 0;
                Console.WriteLine($"{Name} ha sido eliminado");
            }
            Console.WriteLine($"{Name} ha recibido {reducedDamage} puntos de daño");
            return CurrentHitPoints;

        }
        public override string ToString()
        {
            var stats = new StringBuilder();
            stats.AppendLine("===== GOBLIN STATS =====");
            stats.AppendLine($"Name: {Name}");
            stats.AppendLine($"Hit Points: {CurrentHitPoints}/{MaxHitPoints}");
            stats.AppendLine($"Damage: {Damage}");
            stats.AppendLine($"Armor: {Armor}");
            stats.AppendLine("========================");
            return stats.ToString();
        }
    }
}
