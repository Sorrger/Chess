using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Piece
{
    public class Knight : ChessPiece
    {
        public Knight(Color color) : base(color) 
        {
            ImageSource = color == Color.White ?
             "/Chess;component/Resources/Pieces/WhiteKnight.png" :
             "/Chess;component/Resources/Pieces/BlackKnight.png";
        }
        public override List<Vector2> MovePattern(Vector2 position)
        {
            List<Vector2> possibleMoves = [];

            Vector2[] moves = [
            new Vector2(1, 2),
            new Vector2(1, -2),
            new Vector2(-1, 2),
            new Vector2(-1, -2),
            new Vector2(2, 1),
            new Vector2(2, -1),
            new Vector2(-2, 1),
            new Vector2(-2, -1)
            ];

            foreach (var move in moves)
            {
                possibleMoves.Add(position + move);
            }

            return possibleMoves;
        }
    }
}
