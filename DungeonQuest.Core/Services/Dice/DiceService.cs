using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest.Core.Services.Dice
{
    internal class DiceService
    {
        private readonly Random _random = new Random();

        public int RollMovementDice(int numberOfDice)
        {
            int totalMovement = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                totalMovement += _random.Next(1, 7); // Simulate a 6-sided die
            }
            return totalMovement;
        }

        public List<DiceIcon> RollCombatDice(int numberOfDice)
        {
            List<DiceIcon> rollResults = new List<DiceIcon> ();
            for (int i = 0; i < numberOfDice; i++)
            {
                int diceRoll = _random.Next(1, 7);
                switch (diceRoll)
                {
                    case 1:
                    case 2:
                    case 3:
                        rollResults.Add(DiceIcon.Skull);
                        break;
                    case 4:
                    case 5:
                        rollResults.Add(DiceIcon.WhiteShield);
                        break;
                    case 6:
                        rollResults.Add(DiceIcon.BlackShield);
                        break;
                }
            }
            return rollResults;
            
        }

    }

    enum DiceIcon
    {
        Skull,
        WhiteShield,
        BlackShield
    }
}
