using DungeonQuest.Core.Models.Entities.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest.Core.Models.Items
{
    internal abstract class Item
    {
        public string Name { get; protected set; }
        public int Value { get; protected set; }    // Items gold worth

        public abstract void ApplyEffect(Hero hero);
    }
}
