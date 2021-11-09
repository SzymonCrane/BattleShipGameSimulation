using BattleShip.GameObjects.Board;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.GameObjects.Ships;

namespace BattleShip.GameObjects
{
    public class Player
    {
        public string Name { get; set; }
        public GameBoard GameBoard { get; set; }
        public FiringBoard FiringBoard { get; set; }
        public List<Ship> Ships { get; set; }
        public bool HasLost { get; set; }
        //{
        //    get
        //    {
        //        return Ships.All(x => x.IsSunk);
        //    }
        
        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>()
            {
                new Battleship(),
                new Carrier(),
                new Destroyer(),
                new Patrol(),
                new Submarine()
            };
            GameBoard = new GameBoard();
            FiringBoard = new FiringBoard();
        }
    }
}
