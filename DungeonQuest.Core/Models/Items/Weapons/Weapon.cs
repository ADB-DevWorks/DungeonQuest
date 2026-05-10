using DungeonQuest.Core.Models.Entities.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest.Core.Models.Items.Weapons
{
    internal class Weapon : Item 
    {
        public int AttackDice { get; private set; }
        public Weapon(string name, int attackDice)
        {
            Name = name;
            AttackDice = attackDice;
        }
        public override void ApplyEffect(Hero hero)
        {
            hero.EquipWeapon(this);
        }
    }

}
