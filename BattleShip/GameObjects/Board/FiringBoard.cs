using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects.Board
{
    public class FiringBoard : GameBoard
    {
        public List<Coordinates> GetOpenRandomSpaceOnBoard() 
        {
            return SpaceOnBoards.Where(x => x.MarkType == MarkType.Empty && x.IsRandomCoordinateAvailable).Select(x => x.Coordinates).ToList();
        }
        public List<Coordinates> GetNearHit() 
        {
            List<SpaceOnBoard> spaces = new List<SpaceOnBoard>();
            var hits = SpaceOnBoards.Where(x => x.MarkType == MarkType.Hit);
            foreach(var hit in hits)
            {
                spaces.AddRange(GetNearShip(hit.Coordinates).ToList());
            }
            return spaces.Distinct().Where(x => x.MarkType == MarkType.Empty).Select(x => x.Coordinates).ToList();
        }
        public List<SpaceOnBoard> GetNearShip(Coordinates coordinates)
        {
            var row = coordinates.Row;
            var column = coordinates.Column;

            List<SpaceOnBoard> spaces = new List<SpaceOnBoard>();

            if (column > 1)
            {
                spaces.Add(SpaceOnBoards.At(row, column - 1));
            }
            if (row > 1)
            {
                spaces.Add(SpaceOnBoards.At(row - 1, column));
            }
            if (row < 10)
            {
                spaces.Add(SpaceOnBoards.At(row + 1, column));
            }
            if (column < 10)
            {
                spaces.Add(SpaceOnBoards.At(row, column + 1));
            }
            return spaces;
        }
    }
}
