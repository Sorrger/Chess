using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chess.Models.Piece
{
    abstract class ChessPiece
    {
        Color color;
        public ChessPiece() { }
        public ChessPiece(Color color)
        {
            this.color = color;
        }
        public Vector2 Position { get; set; }
        abstract public List<Vector2> MovePattern();
    }
}
