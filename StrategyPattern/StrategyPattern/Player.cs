using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Weapons.Abstractions;

namespace StrategyPattern
{
    public class Player
    {
        public IWeapon _weapon { get; set; }
        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            _weapon.UseWeapon();
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }
    }
}
