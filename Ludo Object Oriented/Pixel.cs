using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Object_Oriented
{
    class Pixel
    {
        public Pixel(ConsoleColor color, Coordinates coordinates, PixelType type)
        {
            Color = color;
            Coordinates = coordinates;
            Type = type;
        }

        protected ConsoleColor Color;
        protected Coordinates Coordinates;
        protected PixelType Type;

        public void ChangeColor(ConsoleColor color)
        {
            Color = color;
            Draw();
        }

        public enum PixelType
        {
            PlayerPiece,
            NonMovablePixel,
            MovablePixel
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(Coordinates.X, Coordinates.Y);
            Console.BackgroundColor = Color;
            Console.Write(" ");
        }
    }
}
