using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects.Ship
{
    public class Patrol : Ship
    {
        public Patrol()
        {
            Name = "Patrol Boat";
            Width = 2;
            MarkType = MarkType.PatrolBoat;
        }
    }
}
