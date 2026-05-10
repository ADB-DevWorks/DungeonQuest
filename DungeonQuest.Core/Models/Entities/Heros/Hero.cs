using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonQuest.Core.Models.Items.Armor;
using DungeonQuest.Core.Models.Items.Weapons;
using DungeonQuest.Core.Models.Items.Consumables;
using DungeonQuest.Core.Models.Items.Artifacts;
using DungeonQuest.Core.Models.Items;

namespace DungeonQuest.Core.Models.Entities.Heros
{
    internal abstract class Hero : Entity
    {
        public int Gold { get; protected set; }

        public List<Item> Inventory { get; protected set; } = new();

        public Weapon? EquippedWeapon { get; private set; }
        public Armor? EquippedArmor { get; private set; }

        public void EquipWeapon(Weapon weapon) { EquippedWeapon = weapon; }

        public void EquipArmor(Armor armor) { EquippedArmor = armor; }


        public void TakeItem(Item item)
        {
            Inventory.Add(item);
        }

        public void UseItem(Item item)
        {
            if (Inventory.Contains(item))
            {
                item.ApplyEffect(this);

                if (item is Consumable)
                {
                    Inventory.Remove(item);
                }
            }
        }
        
    }
}
