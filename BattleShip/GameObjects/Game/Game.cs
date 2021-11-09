using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects
{
    public class Game
        // Create 2 player objects which are gonna save their ships coordinates etc.
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Game() { }
        public void PlayRound() { }
        public void RoundToEnd() { }
    }
}
