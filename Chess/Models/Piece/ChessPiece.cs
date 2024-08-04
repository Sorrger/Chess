using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chess.Models.Piece
{
    public abstract class ChessPiece
    {
        Color Color { get;}
        public ChessPiece() { }
        public ChessPiece(Color color)
        {
            this.Color = color;
        }
        abstract public List<Vector2> MovePattern(Vector2 position);
    }
}
