using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects.Board
{
    public class SpaceOnBoard
    {
        public MarkType MarkType { get; set; }
        public Coordinates Coordinates { get; set; }
        public SpaceOnBoard(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            MarkType = MarkType.Empty;
        }
        public string Status
        {
            get
            {
                return MarkType.GetAttributeOfType<DescriptionAttribute>().Description;
            }
        }
        public bool IsTaken
        {
            get
            {
                return MarkType == MarkType.Carrier
                    || MarkType == MarkType.Battleship
                    || MarkType == MarkType.Destroyer
                    || MarkType == MarkType.Submarine
                    || MarkType == MarkType.PatrolBoat;
            }
        }
        public bool IsRandomCoordinateAvailable
        {
            get
            {
                return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0) || (Coordinates.Row % 2 == 1 && Coordinates.Column % 1 == 0);
            }
        }
    }
}
