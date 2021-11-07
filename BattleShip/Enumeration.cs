using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public enum MarkType
    {
        // Assign a name of battleship to it's easier recognition on board - using 2002 naming version created by Hasbro

        [Description("o")]
        Empty,

        [Description("C")]
        Carrier,

        [Description("B")]
        Battleship,

        [Description("D")]
        Destroyer,

        [Description("S")]
        Submarine,

        [Description("P")]
        PatrolBoat,

        [Description("X")]
        Hit,

        [Description("M")]
        Miss,
    }
    public enum ShotResult
    {
        Miss,
        Hit
    }
}
