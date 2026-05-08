using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonQuest.Core.Models.Items.Armor;
using DungeonQuest.Core.Models.Items.Weapons;
using DungeonQuest.Core.Models.Items.Consumables;
using DungeonQuest.Core.Models.Items.Artifacts;

namespace DungeonQuest.Core.Models.Entities.Heros
{
    internal abstract class Hero : Entity
    {
        public int Gold { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Armor> Armor { get; set; }
        public List<Consumable> Consumables { get; set; }
        public List<Artifact> Artifacts { get; set; }
    }
}
