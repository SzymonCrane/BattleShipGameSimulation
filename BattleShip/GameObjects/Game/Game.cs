using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.GameObjects
{
    public class Game
        // Create 2 player objects which are gonna save their ships coordinates etc.
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Game() 
        {
            Player1 = new Player("Josh");
            Player2 = new Player("Bobby");

            Player1.PlaceShips();
            Player2.PlaceShips();

            Player1.DrawBoards();
            Player2.DrawBoards();
        }
        public void PlayRound()
        {
            var coordiantes = Player1.FireShot();
            var result = Player2.ReactToShot(coordiantes);
            Player1.ProcessShotResult(coordiantes, result);

            if (Player2.HasLost == false)
            {
                coordiantes = Player2.FireShot();
                result = Player1.ReactToShot(coordiantes);
                Player2.ProcessShotResult(coordiantes, result);
            }
        }
        public void RoundToEnd()
        {
            while (!Player1.HasLost && !Player2.HasLost) // ! => stands for negation which is negative output of boolean -> false
            {
                PlayRound();
            }

            Player1.DrawBoards();
            Player2.DrawBoards();

            if (Player1.HasLost)
            {
                Console.WriteLine(Player2.Name + " won!");
            }
            else if (Player2.HasLost)
            {
                Console.WriteLine(Player1.Name + " won!");
            }
        }
    }
}
