using DungeonQuest.Core.Models.Entities.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest.Core.Models.Items.Armor
{
    internal class Armor : Item
    {
        public int DefendDice { get; private set; }

        public Armor(string name, int defendDice)
        {
            Name = name;
            DefendDice = defendDice;
        }

        public override void ApplyEffect(Hero hero)
        {
            hero.EquipArmor(this);
        }
    }
}
