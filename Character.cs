using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class Character
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int BaseDamage { get; set; }
        public int CurrentDamage { get; set; }
        public int BaseArmor { get; set; }
        public int CurrentArmor { get; set; }

        private List<IItem> _inventory;

        private List<Weapon> _equippedWeapon;

        private List<Protection> _equippedProtection;

        public Character(string name)
        {
            Name = name;
            Lvl = 1;
            MaxHitPoints = 100;
            CurrentHitPoints = MaxHitPoints;
            BaseDamage = 10;
            CurrentDamage = BaseDamage;
            BaseArmor = 5;
            CurrentArmor = BaseArmor;
            _inventory = [];
            _equippedWeapon = [];
            _equippedProtection = [];
        }

        public int Attack()
        {

            CurrentDamage = BaseDamage + _equippedWeapon.Sum(w => w.Damage);
            return CurrentDamage;
        }
        public int Defense()
        {
            CurrentArmor = BaseArmor + _equippedProtection.Sum(p => p.Armor);
            return CurrentArmor;

        }
        public void Heal(LifePotion potion)
        {
            CurrentHitPoints += potion.Healing;
            if (CurrentHitPoints > MaxHitPoints)
            {
                CurrentHitPoints = MaxHitPoints;
            }
            Console.WriteLine($"{Name} heals {potion.Healing} points of life");
        }
        public int RecieveDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - Defense()); //Devuelve 0 o devuelve el daño recibido una vez restada la def
            CurrentHitPoints -= reducedDamage;
            if (CurrentHitPoints < 0)
            {
                CurrentHitPoints = 0;
            }
            Console.WriteLine($"{Name} takes {reducedDamage} points of life");
            return CurrentHitPoints;

        }
        public void AddToInventory(IItem item)
        {
            _inventory.Add(item);
        }
        public void EquipWeapon(Weapon weapon)
        {
            int maxWeapons = 2;

            if(_equippedWeapon.Count < maxWeapons)
            {
                _equippedWeapon.Add(weapon);
                Console.WriteLine($"{Name} equipped {weapon.Name}, now has {Attack()} points of damage");
            }
            else
            {
                Console.WriteLine("You don't have enough hands");
            }


        }
        public void EquipProtection(Protection protection)
        {
            int maxProtection = 5;
            if(_equippedProtection.Count < maxProtection)
            {
                _equippedProtection.Add(protection);
                Console.WriteLine($"{Name} equipped {protection.Name}, now has {Defense()} points of armor");
            }
            else
            {
                Console.WriteLine("You are full equipped");
            }
                
            
        }
        public override string ToString()
        {
            var stats = new StringBuilder();
            stats.AppendLine("===== CHARACTER STATISTICS =====");
            stats.AppendLine($"Name: {Name}");
            stats.AppendLine($"Level: {Lvl}");
            stats.AppendLine($"Hit Points: {CurrentHitPoints}/{MaxHitPoints}");
            stats.AppendLine($"Base Damage: {BaseDamage}");
            stats.AppendLine($"Current Damage: {CurrentDamage}");
            stats.AppendLine($"Base Armor: {BaseArmor}");
            stats.AppendLine($"Current Armor: {CurrentArmor}");

            if (_equippedWeapon.Count > 0)
            {
                stats.AppendLine("Equipped Weapons:");
                foreach (var weapon in _equippedWeapon)
                {
                    stats.AppendLine($"{weapon.Name} (Damage: {weapon.Damage})");
                }
            }
            else
            {
                stats.AppendLine("No weapons equipped.");
            }

            if (_equippedProtection.Count > 0)
            {
                stats.AppendLine("Equipped Protections:");
                foreach (var protection in _equippedProtection)
                {
                    stats.AppendLine($"{protection.Name} (Armor: {protection.Armor})");
                }
            }
            else
            {
                stats.AppendLine("No protections equipped.");
            }

            stats.AppendLine("=================================");
            return stats.ToString();
        }
    }
}
