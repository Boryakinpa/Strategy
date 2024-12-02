using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Weapons.Abstractions;

namespace StrategyPattern.Weapons
{
    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Дзынь мечом");
        }
    }
}
