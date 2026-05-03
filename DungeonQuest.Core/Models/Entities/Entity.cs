using DungeonQuest.Core.Models.Map;
using DungeonQuest.Core.Services.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest.Core.Models.Entities
{
    internal abstract class Entity
    {
        public int AttackDice {  get; protected set; }
        public int DefendDice { get; protected set; }
        public int Body { get; protected set;  }
        public int Mind { get; protected set; }
        public Tile Location { get; private set; }
        private int ActionPoint { get; set; } = 1;

        public abstract void MoveEntity(Tile destionation);
        public bool CanAct => ActionPoint > 0;

        public abstract void Attack(DiceService dice);
        public abstract void Defend(DiceService dice);

        public void ResetActionPoints(int amount = 1)
        {
            ActionPoint = amount;
        }

        public void SetLocation(Tile tile)
        {
            Location = tile;
        }
    }
}
