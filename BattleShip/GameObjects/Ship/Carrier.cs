using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects.Ship
{
    public class Carrier : Ship
    {
       public Carrier()
        {
            Name = "Carrier";
            Width = 5;
            MarkType = MarkType.Carrier;
        }
    }
}
