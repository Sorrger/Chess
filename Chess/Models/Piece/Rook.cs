using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Piece
{
    public class Rook : ChessPiece
    {
        public Rook(Color color) : base(color) { }
        public override List<Vector2> MovePattern(Vector2 position)
        {
            List<Vector2> possibleMoves = [];
            for (int i = 1; i < 8; i++)
            {
                possibleMoves.Add(position + new Vector2(0, i));
                possibleMoves.Add(position + new Vector2(0, -i));
                possibleMoves.Add(position + new Vector2(i, 0));
                possibleMoves.Add(position + new Vector2(-i, 0));
            }
            return possibleMoves;
        }
    }
}
