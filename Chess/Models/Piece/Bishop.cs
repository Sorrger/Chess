using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Piece
{
    internal class Bishop : ChessPiece
    {
        public Bishop(Color color) :base(color) 
        {
            ImageSource = color == Color.White ?
              "/Chess;component/Resources/Pieces/WhiteBishop.png" :
              "/Chess;component/Resources/Pieces/BlackBishop.png";

        }
        public override List<Vector2> MovePattern(Vector2 position)
        {
            List<Vector2> possibleMoves = [];
            for (int i = 1; i < 8; i++)
            {
                possibleMoves.Add(position + new Vector2(i,i));
                possibleMoves.Add(position + new Vector2(-i,-i));
                possibleMoves.Add(position + new Vector2(i,-i));
                possibleMoves.Add(position + new Vector2(-i,i));
            }
            return possibleMoves;
        }
    }
}
