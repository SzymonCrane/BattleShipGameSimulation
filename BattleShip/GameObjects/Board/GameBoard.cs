using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects.Board
{
    public class GameBoard
    {
        public List<SpaceOnBoard> SpaceOnBoards { get; set; }
        
        public GameBoard()
        {
            SpaceOnBoards = new List<SpaceOnBoard>();
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j < 10; j++)
                {
                    SpaceOnBoards.Add(new SpaceOnBoard(i, j));
                }
            }
        }
    }
}
