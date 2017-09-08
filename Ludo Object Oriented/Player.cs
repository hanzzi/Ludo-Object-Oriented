using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Object_Oriented
{
    class Player : Pixel
    {
        private int LargestId;
        public int Id;
        protected Char CharacterSymbol;

        public Player(ConsoleColor color, Coordinates coordinates, PixelType type, Char characterSymbol) : base(color, coordinates, type)
        {
            Color = color;
            Coordinates = coordinates;
            Type = type;
            CharacterSymbol = characterSymbol;
            Id = LargestId++;
            LargestId++;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(Coordinates.X, Coordinates.Y);
            Console.BackgroundColor = Color;
            Console.Write(CharacterSymbol);
        }
    }
}
