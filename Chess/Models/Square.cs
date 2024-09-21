using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Models.Piece;
using Chess.Models;

namespace Chess.Models
{
    public class Square
    {
        public ChessPiece Piece { get; set; }
        public Color Color { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public Square() { }
        public Square(Color color)
        {
            Color = color;
        }
        public Square(Color color, ChessPiece piece = null)
        {
            Color = color;
            this.Piece = piece;
        }
    }
}
