using DungeonQuest.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest.Core.Models.Map
{
    internal class Tile
    {
        public int Row { get; init; }
        public int Column { get; init; }

        public TileType Type { get; init; }
        public Entity Occupant { get; private set; }
        
        public Tile(int row, int column, TileType type)
        {
            Row = row;
            Column = column;
            Type = type;
        }

        public void SetOccupant(Entity entity) { Occupant = entity; }
        public void ClearOccpant() { Occupant = null; }
    }
}
