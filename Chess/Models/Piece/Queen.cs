using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Piece
{
    internal class Queen : ChessPiece
    {
        public override List<Vector2> MovePattern()
        {
            List<Vector2> possibleMoves = [];
            for (int i = 1; i < 8; i++)
            {
                // diagonally
                possibleMoves.Add(Position + new Vector2(i, i));
                possibleMoves.Add(Position + new Vector2(-i, -i));
                possibleMoves.Add(Position + new Vector2(i, -i));
                possibleMoves.Add(Position + new Vector2(-i, i));

                // straight
                possibleMoves.Add(Position + new Vector2(0, i));
                possibleMoves.Add(Position + new Vector2(0, -i));
                possibleMoves.Add(Position + new Vector2(i, 0));
                possibleMoves.Add(Position + new Vector2(-i, 0));
            }
            return possibleMoves;
        }
    }
}
