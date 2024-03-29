﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.GameObjects.Board;

namespace BattleShip.GameObjects.Ships
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public MarkType MarkType { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Width;
            }
        }
    }
}
