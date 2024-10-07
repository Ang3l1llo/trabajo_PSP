using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class InvokerCane : Weapon
    {
        public List<Minion> _minions;
        public int MaxMinions;

        public InvokerCane(String name, int damage, int maxMinions)
        {
            Name = name;
            Damage = damage;
            MaxMinions = maxMinions;
            _minions = [];
        }

        public override void Apply(Character character)
        {
            character.EquipWeapon(this);
        }
        public void SummonMinion(String name, int maxHitPoints, int damage, int armor)
        {
            if(_minions.Count < MaxMinions)
            {
                Minion minion = new Minion(name, maxHitPoints, damage, armor);    
                _minions.Add(minion);
                Console.WriteLine("Summon complete");

            }
            else
            {
                Console.WriteLine("You cannot summon more minions");
            }
        }
        public void OrderAttack(Target target)
        {
            foreach(Minion minion in _minions)
            {
                minion.Attack();
                target.RecieveDamage(minion.Damage);
            }
        }

    }
}
