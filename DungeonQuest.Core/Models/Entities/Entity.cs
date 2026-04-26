using DungeonQuest.Core.Models.Map;
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
        protected int AttackDice {  get; private set; }
        protected int DefendDice { get; private set; }
        protected int Body { get; private set;  }
        protected int Mind { get; private set; }
        protected Tile Location { get; private set; }
        private int ActionPoint { get; set; } = 1;

        public abstract void MoveEntity(Tile destionation);

        public void Attack(Entity target)
        {

            if (ActionPoint >= 1)
            {
                //TODO: Add Attack logic
                ActionPoint--;
            }
            else
            {
                //TODO: feedback: "No actions remaining"
            }

        }

        public void ResetActionPoints(int amount = 1)
        {
            ActionPoint = amount;
        } 
    }
}
