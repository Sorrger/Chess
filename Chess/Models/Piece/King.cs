using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Piece
{
    internal class King : ChessPiece
    {
        public override List<Vector2> MovePattern()
        {
            List<Vector2> possibleMoves = [];

            Vector2[] moves = [
            new Vector2(0, 1),
            new Vector2(1, 0),
            new Vector2(0, -1),
            new Vector2(-1, 0),
            new Vector2(1, 1),
            new Vector2(-1, -1),
            new Vector2(1, -1),
            new Vector2(-1, 1),
            
           ];

            foreach (var move in moves)
            {
                possibleMoves.Add(Position + move);
            }

            return possibleMoves;

        }
    }
}
