using BattleShip.GameObjects.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects
{
    public static class Extension
    {
        public static SpaceOnBoard At(this List<SpaceOnBoard> spaceOnBoards, int row, int column)
        {
            return spaceOnBoards.Where(x => x.Coordinates.Row == row && x.Coordinates.Column == column).First();
        }
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }
}
