using BattleShip.GameObjects.Board;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.GameObjects.Ships;
using System;

namespace BattleShip.GameObjects
{
    public class Player
    {
        public string Name { get; set; }
        public GameBoard GameBoard { get; set; }
        public FiringBoard FiringBoard { get; set; }
        public List<Ship> Ships { get; set; }
        public bool HasLost
        {
            get
            {
                return Ships.All(x => x.IsSunk);
            }
        }
        
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
        public void PlaceShips()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var ship in Ships)
            {
                var isFree = true;
                while (isFree)
                {
                    var startRow = rand.Next(1, 11);
                    var startColumn = rand.Next(1, 11);
                    var endRow = startRow;
                    var endColumn = startColumn;
                    var mapPoint = rand.Next(1, 101) % 2;
                    var startPointTaken = GameBoard.SpaceOnBoards.GetRange(startRow, startColumn); 
                    var endPointTaken = GameBoard.SpaceOnBoards.GetRange(endRow, endColumn);


                    List<int> boardNumber = new List<int>();
                    if (mapPoint == 0)
                    {
                        for (var i = 1; i < ship.Width; i++)
                        {
                            endRow++;
                        }
                    }
                    else
                    {
                        for (var i = 1; i < ship.Width; i++)
                        {
                            endColumn++;
                        }
                    }
                    if (endRow > 10 || endColumn > 10)
                    {
                        isFree = true;
                        continue;
                    }

                    if (startPointTaken.Any(x => x.IsTaken))
                    {
                        isFree = true;
                        continue;
                    }
                    if (endPointTaken.Any(y => y.IsTaken))
                    {
                        isFree = true;
                        continue;
                    }

                    foreach(var point in startPointTaken)
                    {
                        point.MarkType = ship.MarkType;
                    }
                    isFree = false;

                    foreach(var point in endPointTaken)
                    {
                        point.MarkType = ship.MarkType;
                    }
                    isFree = false;
                }
            }
        }

    public void DrawBoards()
    {
        Console.WriteLine(Name);
        Console.WriteLine("Your board:                                                Firing Board:");
        for(var row = 1; row <= 10; row++)
            {
                for(var yourColumn = 1; yourColumn <= 10; yourColumn++)
                {
                    Console.Write(GameBoard.SpaceOnBoards.At(row, yourColumn).Status + " \t\t\t\t\t\t");
                }
                for(var fireColumn = 1; fireColumn <= 1-; fireColumn++)
                {
                    Console.Write(FiringBoard.SpaceOnBoards.At(row, fireColumn).Status + " \t\t\t\t\t\t");
                }
                Console.Write(Environment.NewLine);
            }
        Console.WriteLine(Environment.NewLine);
    }
    
    public Coordinates FireShot() { }
    public Coordinates RandShot() { }
    private Coordinates SearchForShot() { }

    }
}
