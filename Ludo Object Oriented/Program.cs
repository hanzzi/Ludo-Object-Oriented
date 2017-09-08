using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Object_Oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(ConsoleColor.Blue, new Coordinates(1, 1), Pixel.PixelType.NonMovablePixel, '@');
            player.Draw();
            Console.ReadLine();
        }

        private void InitializeGame()
        {
            
        }

        private void NextTurn()
        {
            
        }

        private void PlayerTurn()
        {
            
        }

        private void DrawPlayField()
        {
            
        }
    }
}
