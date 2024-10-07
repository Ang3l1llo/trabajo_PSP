using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    abstract class Potion : IItem
    {
        public required String Name { get; set; }
        public abstract void Apply(Character character);
    }
}
