using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects.Ship
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            Width = 3;
            MarkType = MarkType.Destroyer;
        }
    }
}
