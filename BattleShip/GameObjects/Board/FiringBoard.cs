using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects.Board
{
    public class FiringBoard : GameBoard
    {
        public List<Coordinates> GetOpenRandomSpaceOnBoard() { }
        public List<Coordinates> GetNearHit() { }
        public List<SpaceOnBoard> GetNearShip(Coordinates coordinates) { }
    }
}
